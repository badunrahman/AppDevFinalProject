using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Database;
using StudentManagementSystem.Forms;
using StudentManagementSystem.Models;
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
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            bool isValid = DatabaseConnection.isValidLogin(username, password);
            if (isValid)
            {
                MessageBox.Show("Successfull login!");
                int userID = DatabaseConnection.getUserIdByLogin(username, password);
                string role = DatabaseConnection.getUserRole(userID);

                if (role == "Teacher")
                {
                    TeacherDashboard teacherDashboard = new TeacherDashboard(userID);
                    teacherDashboard.Show();
                }
                else if (role == "Admin")
                {
                    User admin = new User(username, password, role);
                    AdminDashboard adminDashboard = new AdminDashboard(admin);
                    adminDashboard.Show();
                }
                else
                {
                    MessageBox.Show("An error occurred while logging in");
                }
            }
            else
            {
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                incorrectInfoLabel.Visible = true;
                MessageBox.Show("Incorrect username or password!", "Error", button, icon);
            }
        }
    }
}
