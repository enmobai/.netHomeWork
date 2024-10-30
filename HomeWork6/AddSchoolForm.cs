
using System;
using System.Windows.Forms;

namespace HomeWork6
{
    public partial class AddSchoolForm : Form
    {
        public string SchoolName
        {
            get { return txtSchoolName.Text; }
            set { txtSchoolName.Text = value; }
        }
        public AddSchoolForm()
        {
            InitializeComponent();
        }

        private void btnSaveSchool_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SchoolName))
            {
                MessageBox.Show("School name cannot be empty!");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
