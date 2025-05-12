using StudentManagementSystem.Database;
using System;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class createAccountForm : Form
    {
        private ResourceManager rm = new ResourceManager("StudentManagementSystem.Strings", typeof(createAccountForm).Assembly);

        public createAccountForm()
        {
            InitializeComponent();
            this.Load += createAccountForm_Load;
        }

        private void createAccountForm_Load(object sender, EventArgs e)
        {
            SetLanguage(AppSettings.CurrentLanguage);
        }

        private void SetLanguage(string langCode)
        {
            CultureInfo ci = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = ci;

            this.Text = rm.GetString("CreateFormTitle", ci);
            titleLabel.Text = rm.GetString("CreateFormTitle", ci);
            personalInfoGroupBox.Text = rm.GetString("GroupBoxPersonalInfo", ci);
            accountInfoGroupBox.Text = rm.GetString("GroupBoxAccountInfo", ci);
            firstNameLabel.Text = rm.GetString("FirstNameLabel", ci);
            lastNameTextBox.Text = rm.GetString("LastNameLabel", ci);
            usernameLabel.Text = rm.GetString("UsernameLabel", ci);
            passwordLabel.Text = rm.GetString("PasswordLabel", ci);
            createAccountButton.Text = rm.GetString("CreateBtn", ci);
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            string name = firstNameTextBox.Text + " " + lastNameText.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameText.Text) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(rm.GetString("AllFieldsWarning", CultureInfo.CurrentUICulture),
                                rm.GetString("InvalidFieldsTitle", CultureInfo.CurrentUICulture),
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DatabaseConnection.checkUsernameExists(username))
            {
                MessageBox.Show(rm.GetString("UsernameExists", CultureInfo.CurrentUICulture),
                                rm.GetString("UsernameExistsTitle", CultureInfo.CurrentUICulture),
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DatabaseConnection.createUser(username, password, "Teacher");
                int userId = DatabaseConnection.getUserIdByLogin(username, password);
                DatabaseConnection.createTeacher(userId, name);
                MessageBox.Show(rm.GetString("TeacherCreated", CultureInfo.CurrentUICulture));
            }
        }
    }
}
