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
    public partial class LogForm : Form
    {
        private string connectionString = "Data Source=student_management.db;Version=3;";

        public LogForm()
        {
            InitializeComponent();
            LoadLogs();
        }

        private void LoadLogs()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var command = new SQLiteCommand("SELECT * FROM Log", connection);
                var adapter = new SQLiteDataAdapter(command);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvLogs.DataSource = dataTable;
            }
        }
    }
}
