using StudentManagementSystem.Database;
using StudentManagementSystem.Models;
using StudentManagementSystem.Models.StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class TeacherDashboard : Form
    {
        private int userId;
        private int teacherId;
        public TeacherDashboard(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            //this.studentsTableAdapter.Fill(this.studentDBDataSet.Students);
            int teachID = DatabaseConnection.getTeacherIdByUserId(userId);
            teacherId = teachID;
            Teacher teacher = DatabaseConnection.getTeacherByID(teacherId);

            if (teacher  == null)
            {
                MessageBox.Show("No teacher found");
            }

            IdLabel.Text = "User ID: " + teacher.UserID;
            nameLabel.Text = "Name: " + teacher.Name;

            List<Course> courses = DatabaseConnection.getTeacherCourses(teacherId);
            foreach (var course in courses)
            {
                coursesListBox.Items.Add(course);
                courseComboBox.Items.Add(course);
            }
        }

        private void courseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course course = courseComboBox.SelectedItem as Course;

            if (course != null)
            {
                List<Student> students = DatabaseConnection.getCourseStudents(course.CourseID);
                studentDataGridView.DataSource = null;
                studentDataGridView.DataSource = students;
            }
        }
    }
}
