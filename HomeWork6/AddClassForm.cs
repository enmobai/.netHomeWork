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
    public partial class AddClassForm : Form
    {
        private string connectionString = "Data Source=student_management.db;Version=3;";

        public string ClassName
        {
            get { return txtClassName.Text; }
            set { txtClassName.Text = value; }
        }
        public int SchoolId { get; set; }

        public AddClassForm()
        {
            InitializeComponent();
            LoadSchools();
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
                cmbSchools.DataSource = dataTable;
                cmbSchools.DisplayMember = "Name";
                cmbSchools.ValueMember = "Id";
            }
        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClassName))
            {
                MessageBox.Show("Class name cannot be empty!");
                return;
            }
            if (cmbSchools.SelectedValue != null)
            {
                SchoolId = Convert.ToInt32(cmbSchools.SelectedValue);
            }
            else
            {
                MessageBox.Show("Please select a school.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
