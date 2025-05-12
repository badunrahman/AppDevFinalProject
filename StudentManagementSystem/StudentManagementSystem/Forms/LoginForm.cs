using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Threading;
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
        private ResourceManager rm = new ResourceManager("StudentManagementSystem.Strings", typeof(loginPageForm).Assembly);

        public loginPageForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(loginPageForm_Load);
            lightModeButton.Click += lightModeButton_Click;
        }

        private void loginPageForm_Load(object sender, EventArgs e)
        {
            if (languageComboBox.Items.Count == 0)
            {
                languageComboBox.Items.Add("En");
                languageComboBox.Items.Add("Fr");
                languageComboBox.Items.Add("Es");
            }

            switch (AppSettings.CurrentLanguage)
            {
                case "fr": languageComboBox.SelectedItem = "Fr"; break;
                case "es": languageComboBox.SelectedItem = "Es"; break;
                default: languageComboBox.SelectedItem = "En"; break;
            }

            SetLanguage(AppSettings.CurrentLanguage);
            ThemeManager.ApplyTheme(this); 
        }

        private void SetLanguage(string langCode)
        {
            CultureInfo ci = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = ci;

            logInButton.Text = rm.GetString("LoginBtn", ci);
            incorrectInfoLabel.Text = rm.GetString("LoginWelcome", ci);
            noAccountInfoLabel.Text = rm.GetString("NoAccountLabel", ci);
            createAccountLinkLabel.Text = rm.GetString("CreateAccountLink", ci);
        }

        private void lightModeButton_Click(object sender, EventArgs e)
        {
            ThemeManager.ToggleTheme(this);
        }
        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = languageComboBox.SelectedItem.ToString();

            if (selected == "Fr")
                AppSettings.CurrentLanguage = "fr";
            else if (selected == "Es")
                AppSettings.CurrentLanguage = "es";
            else
                AppSettings.CurrentLanguage = "en";

            SetLanguage(AppSettings.CurrentLanguage);
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
                MessageBox.Show(rm.GetString("LoginSuccess", CultureInfo.CurrentUICulture));
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
                MessageBox.Show(rm.GetString("LoginError", CultureInfo.CurrentUICulture), "Error", button, icon);
            }
        }
    }
}
