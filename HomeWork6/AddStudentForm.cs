using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork6
{
    public partial class AddStudentForm : Form
    {
        private string connectionString = "Data Source=student_management.db;Version=3;";

        public string StudentName
        {
            get { return txtStudentName.Text; }
            set { txtStudentName.Text = value; }
        }

        public int Age
        {
            get { return (int)nudAge.Value; }
            set { nudAge.Value = value; }
        }

        public int ClassId { get; set; }

        public AddStudentForm()
        {
            InitializeComponent();
            LoadClasses();
        }

        private void LoadClasses()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Class", connection);
                var adapter = new SQLiteDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                cmbClasses.DataSource = dataTable;
                cmbClasses.DisplayMember = "ClassName";
                cmbClasses.ValueMember = "Id";
            }
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StudentName))
            {
                MessageBox.Show("Student name cannot be empty!");
                return;
            }
            if (cmbClasses.SelectedValue != null && cmbClasses.SelectedValue != DBNull.Value)
            {
                ClassId = Convert.ToInt32(cmbClasses.SelectedValue);
            }
            else
            {
                MessageBox.Show("Please select a valid class.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
