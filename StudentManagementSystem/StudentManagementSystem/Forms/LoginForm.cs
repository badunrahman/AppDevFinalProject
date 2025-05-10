using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.StudentDBDataSetTableAdapters;

namespace StudentManagementSystem
{
    public partial class loginPageForm : Form
    {
        public loginPageForm()
        {
            InitializeComponent();
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            incorrectInfoLabel.Visible = false;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            incorrectInfoLabel.Visible = false;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            StudentDBDataSet db = new StudentDBDataSet();
            var adapter = new StudentDBDataSetTableAdapters.UsersTableAdapter();
            adapter.Fill(db.Users);

            int count = db.Users.Count(row => row.Username == usernameTextBox.Text && row.Password == passwordTextBox.Text);

            if (count > 0)
            {
                MessageBox.Show("Succesfull login");
            }
            else if (true)
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                incorrectInfoLabel.Visible = true;
                MessageBox.Show("Incorrect username or password!", "Error", button, icon);
            }
        }
    }
}
