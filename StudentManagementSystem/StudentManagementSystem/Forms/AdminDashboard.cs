using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Forms;
using StudentManagementSystem.Services;

namespace StudentManagementSystem.Models
{
    public partial class AdminDashboard : Form
    {
        private User _loggedInAdmin;
        public AdminDashboard(User admin)
        {
            InitializeComponent();
            _loggedInAdmin = admin;
        }

        private void CircularPictureBox(PictureBox picBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, picBox.Width - 1, picBox.Height - 1);
            picBox.Region = new Region(gp);
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            CircularPictureBox(adminPictureBox);
            adminNameLabel.Text = $"Welcome, {_loggedInAdmin.Username}";

        }

        private void adminPictureBox_Paint(object sender, PaintEventArgs e)
        {
            PictureBox picBox = sender as PictureBox;

            using (Pen pen = new Pen(Color.Black, 4)) // Color + thickness
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
                e.Graphics.DrawEllipse(pen, 1, 1, picBox.Width - 3, picBox.Height - 3);
            }
        }

        private void adminNameLabel_Click(object sender, EventArgs e)
        {
            //this.adminNameLabel.Text = $"Welcome,{User.Username}";
        }

        private void studentIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentIdTextBox_Enter(object sender, EventArgs e)
        {
            if (studentIdTextBox.Text == "Enter Student ID")
            {
                studentIdTextBox.Text = "";
                studentIdTextBox.ForeColor = Color.Black;

            }
        }

        private void studentIdTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(studentIdTextBox.Text))
            {
                studentIdTextBox.Text = "Enter Student ID";
                studentIdTextBox.ForeColor = Color.Gray;
            }
        }

        private void studnetManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentForm = new StudentManagementForm();
            studentForm.ShowDialog();
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void athletesStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            athleteStudentView athleteStudent = new athleteStudentView();
            athleteStudent.Show();
        }

        private void teacherManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createAccountForm createAccount = new createAccountForm();
            createAccount.Show();
        }

        private void academicTrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void partTimeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fullTimeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void grpQuickSearchGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(studentIdTextBox.Text, out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            Student student = StudentService.GetStudentById(studentId);

            if (student == null)
            {
                MessageBox.Show("Student not found.");
                return;
            }

            string[] nameParts = student.Name.Split(' ');
            fNameTextBoxt.Text = nameParts[0];// for the first name
            lNameTextBox.Text = nameParts.Length > 1 ? string.Join(" ", nameParts.Skip(1)) : "";
            contactTextBox.Text = student.EmergencyContact;
            gpaTextBox.Text = "N/A";            // Only if GPA is available later
            coursesTextBox.Text = string.Join(", ", CourseService.GetCoursesByStudentId(studentId));
        }

        private void fNameTextBoxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void gpaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void coursesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }
