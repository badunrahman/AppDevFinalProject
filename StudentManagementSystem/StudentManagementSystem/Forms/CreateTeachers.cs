using StudentManagementSystem.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class createAccountForm : Form
    {
        public createAccountForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string name = firstNameTextBox.Text + " " + lastNameText.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (username.Equals("") || firstNameTextBox.Text.Equals("") || lastNameText.Text.Equals("") || password.Equals(""))
            {
                MessageBox.Show("You must enter values in all fields!", "Invalid fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (DatabaseConnection.checkUsernameExists(username) == true)
                {
                    MessageBox.Show("Username already exists!", "Username Exists Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DatabaseConnection.createUser(username, password, "Teacher");
                    int userId = DatabaseConnection.getUserIdByLogin(username, password);
                    DatabaseConnection.createTeacher(userId, name);
                    MessageBox.Show("Succesfully created the teacher!");
                }
            }
        }
    }
}
