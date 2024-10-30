using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HomeWork6
{
    public partial class Form1: Form
    {
        private string connectionString = "Data Source=student_management.db;Version=3;";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadSchools();

        }

        private void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand(@"
                CREATE TABLE IF NOT EXISTS School (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT
                );
                CREATE TABLE IF NOT EXISTS Class (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ClassName TEXT,
                    SchoolId INTEGER,
                    FOREIGN KEY(SchoolId) REFERENCES School(Id)
                );
                CREATE TABLE IF NOT EXISTS Student (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    Age INTEGER,
                    ClassId INTEGER,
                    FOREIGN KEY(ClassId) REFERENCES Class(Id)
                );
                CREATE TABLE IF NOT EXISTS Log (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Action TEXT,
                    Timestamp DATETIME DEFAULT CURRENT_TIMESTAMP
                );", connection);
                command.ExecuteNonQuery();
            }
        }

        private void LogAction(string action)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("INSERT INTO Log (Action) VALUES (@action)", connection);
                command.Parameters.AddWithValue("@action", action);
                command.ExecuteNonQuery();
            }
        }

        private void LoadSchools()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM School", connection);
                var adapter = new SQLiteDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvSchools.DataSource = dataTable;
            }
        }

        private void LoadClasses(int schoolId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Class WHERE SchoolId = @schoolId", connection);
                command.Parameters.AddWithValue("@schoolId", schoolId);
                var adapter = new SQLiteDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvClasses.DataSource = dataTable;
            }
        }

        private void LoadStudents(int classId)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Student WHERE ClassId = @classId", connection);
                command.Parameters.AddWithValue("@classId", classId);
                var adapter = new SQLiteDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvStudents.DataSource = dataTable;
            }
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            using (var form = new AddSchoolForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var schoolName = form.SchoolName;
                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        var command = new SQLiteCommand("INSERT INTO School (Name) VALUES (@name)", connection);
                        command.Parameters.AddWithValue("@name", schoolName);
                        command.ExecuteNonQuery();
                        LogAction($"Added School: {schoolName}");
                        MessageBox.Show("School added successfully!");
                    }
                    LoadSchools();
                }
            }
        }

        private void btnEditSchool_Click(object sender, EventArgs e)
        {
            if (dgvSchools.CurrentRow != null)
            {
                object cellValue = dgvSchools.CurrentRow.Cells["Id"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int schoolId = Convert.ToInt32(cellValue);
                    using (var form = new AddSchoolForm())
                    {
                        form.SchoolName = dgvSchools.CurrentRow.Cells["Name"].Value.ToString();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var schoolName = form.SchoolName;
                            try
                            {
                                using (var connection = new SQLiteConnection(connectionString))
                                {
                                    connection.Open();
                                    var command = new SQLiteCommand("UPDATE School SET Name = @name WHERE Id = @id", connection);
                                    command.Parameters.AddWithValue("@name", schoolName);
                                    command.Parameters.AddWithValue("@id", schoolId);
                                    command.ExecuteNonQuery();
                                    LogAction($"Updated School: {schoolName}");
                                    MessageBox.Show("School updated successfully!");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error updating school: {ex.Message}");
                            }
                            LoadSchools();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid school ID.");
                }
            }
        }



        private void btnDeleteSchool_Click(object sender, EventArgs e)
        {
            if (dgvSchools.CurrentRow != null)
            {
                object cellValue = dgvSchools.CurrentRow.Cells["Id"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int schoolId = Convert.ToInt32(cellValue);  // 安全转换为 int 类型
                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        var command = new SQLiteCommand("DELETE FROM School WHERE Id = @id", connection);
                        command.Parameters.AddWithValue("@id", schoolId);
                        command.ExecuteNonQuery();
                        LogAction($"Deleted School with ID: {schoolId}");
                        MessageBox.Show("School deleted successfully!");
                    }
                    LoadSchools();
                }
                else
                {
                    MessageBox.Show("Invalid school ID.");
                }
            }
            else
            {
                MessageBox.Show("No school selected.");
            }
        }


        private void btnAddClass_Click(object sender, EventArgs e)
        {
            using (var form = new AddClassForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var className = form.ClassName;
                    var schoolId = form.SchoolId;
                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        var command = new SQLiteCommand("INSERT INTO Class (ClassName, SchoolId) VALUES (@name, @schoolId)", connection);
                        command.Parameters.AddWithValue("@name", className);
                        command.Parameters.AddWithValue("@schoolId", schoolId);
                        command.ExecuteNonQuery();
                        LogAction($"Added Class: {className}");
                        MessageBox.Show("Class added successfully!");
                    }
                    LoadClasses(schoolId);
                }
            }
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow != null)
            {
                object cellValue = dgvClasses.CurrentRow.Cells["Id"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int classId = Convert.ToInt32(cellValue);
                    using (var form = new AddClassForm())
                    {
                        form.ClassName = dgvClasses.CurrentRow.Cells["ClassName"].Value.ToString();
                        // 选择学校
                        object schoolCellValue = dgvClasses.CurrentRow.Cells["SchoolId"].Value;
                        if (schoolCellValue != null && schoolCellValue != DBNull.Value)
                        {
                            form.SchoolId = Convert.ToInt32(schoolCellValue);
                        }

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var className = form.ClassName;
                            try
                            {
                                using (var connection = new SQLiteConnection(connectionString))
                                {
                                    connection.Open();
                                    var command = new SQLiteCommand("UPDATE Class SET ClassName = @className, SchoolId = @schoolId WHERE Id = @id", connection);
                                    command.Parameters.AddWithValue("@className", className);
                                    command.Parameters.AddWithValue("@schoolId", form.SchoolId);
                                    command.Parameters.AddWithValue("@id", classId);
                                    command.ExecuteNonQuery();
                                    LogAction($"Updated Class: {className}");
                                    MessageBox.Show("Class updated successfully!");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error updating class: {ex.Message}");
                            }
                            LoadClasses(form.SchoolId);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid class ID.");
                }
            }
        }



        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow != null)
            {
                object cellValue = dgvClasses.CurrentRow.Cells["Id"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int classId = Convert.ToInt32(cellValue);

                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        var command = new SQLiteCommand("DELETE FROM Class WHERE Id = @id", connection);
                        command.Parameters.AddWithValue("@id", classId);
                        command.ExecuteNonQuery();
                        LogAction($"Deleted Class with ID: {classId}");
                        MessageBox.Show("Class deleted successfully!");
                    }

                    // 确保安全转换 SchoolId
                    object schoolIdValue = dgvClasses.CurrentRow.Cells["SchoolId"].Value;
                    if (schoolIdValue != null && schoolIdValue != DBNull.Value)
                    {
                        try
                        {
                            int schoolId = Convert.ToInt32(schoolIdValue);
                            LoadClasses(schoolId);
                        }
                        catch (InvalidCastException)
                        {
                            MessageBox.Show("Invalid school ID format.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid school ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid class ID.");
                }
            }
            else
            {
                MessageBox.Show("No class selected.");
            }
        }





        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            using (var form = new AddStudentForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var studentName = form.StudentName;
                    var age = form.Age;
                    var classId = form.ClassId;
                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        var command = new SQLiteCommand("INSERT INTO Student (Name, Age, ClassId) VALUES (@name, @age, @classId)", connection);
                        command.Parameters.AddWithValue("@name", studentName);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@classId", classId);
                        command.ExecuteNonQuery();
                        LogAction($"Added Student: {studentName}");
                        MessageBox.Show("Student added successfully!");
                    }
                    LoadStudents(classId);
                }
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                object cellValue = dgvStudents.CurrentRow.Cells["Id"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int studentId = Convert.ToInt32(cellValue);
                    using (var form = new AddStudentForm())
                    {
                        form.StudentName = dgvStudents.CurrentRow.Cells["Name"].Value.ToString();
                        form.Age = Convert.ToInt32(dgvStudents.CurrentRow.Cells["Age"].Value);

                        object classCellValue = dgvStudents.CurrentRow.Cells["ClassId"].Value;
                        if (classCellValue != null && classCellValue != DBNull.Value)
                        {
                            form.ClassId = Convert.ToInt32(classCellValue);
                        }

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var studentName = form.StudentName;
                            var age = form.Age;
                            try
                            {
                                using (var connection = new SQLiteConnection(connectionString))
                                {
                                    connection.Open();
                                    var command = new SQLiteCommand("UPDATE Student SET Name = @name, Age = @age WHERE Id = @id", connection);
                                    command.Parameters.AddWithValue("@name", studentName);
                                    command.Parameters.AddWithValue("@age", age);
                                    command.Parameters.AddWithValue("@id", studentId);
                                    command.ExecuteNonQuery();
                                    LogAction($"Updated Student: {studentName}");
                                    MessageBox.Show("Student updated successfully!");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error updating student: {ex.Message}");
                            }
                            LoadStudents(form.ClassId);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid student ID.");
                }
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                object cellValue = dgvStudents.CurrentRow.Cells["Id"].Value;

                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int studentId = Convert.ToInt32(cellValue);
                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        var command = new SQLiteCommand("DELETE FROM Student WHERE Id = @id", connection);
                        command.Parameters.AddWithValue("@id", studentId);
                        command.ExecuteNonQuery();
                        LogAction($"Deleted Student with ID: {studentId}");
                        MessageBox.Show("Student deleted successfully!");
                    }

                    // 确保安全转换 ClassId
                    object classIdValue = dgvStudents.CurrentRow.Cells["ClassId"].Value;
                    if (classIdValue != null && classIdValue != DBNull.Value)
                    {
                        try
                        {
                            int classId = Convert.ToInt32(classIdValue);
                            LoadStudents(classId); // 调用 LoadStudents 方法
                        }
                        catch (InvalidCastException)
                        {
                            MessageBox.Show("Invalid class ID format.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid class ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid student ID.");
                }
            }
            else
            {
                MessageBox.Show("No student selected.");
            }
        }







        private void btnViewClasses_Click(object sender, EventArgs e)
        {
            if (dgvSchools.CurrentRow != null)
            {
                object cellValue = dgvSchools.CurrentRow.Cells["Id"].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int schoolId = Convert.ToInt32(cellValue);
                    LoadClasses(schoolId);
                }
                else
                {
                    MessageBox.Show("Invalid school ID.");
                }
            }
            else
            {
                MessageBox.Show("No school selected.");
            }
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            if (dgvClasses.CurrentRow != null)
            {
                object cellValue = dgvClasses.CurrentRow.Cells["Id"].Value;
                if (cellValue != null && cellValue != DBNull.Value)
                {
                    int classId = Convert.ToInt32(cellValue);
                    LoadStudents(classId);
                }
                else
                {
                    MessageBox.Show("Invalid class ID.");
                }
            }
            else
            {
                MessageBox.Show("No class selected.");
            }
        }


        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            using (var form = new LogForm())
            {
                form.ShowDialog();
            }
        }


    }
}
