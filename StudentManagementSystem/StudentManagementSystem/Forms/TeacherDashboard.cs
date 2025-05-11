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
        private Course currentCourse;
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
            currentCourse = course;

            if (course != null)
            {
                List<Student> students = DatabaseConnection.getCourseStudents(course.CourseID);
                studentDataGridView.DataSource = null;
                studentDataGridView.DataSource = students;

                for (int i = 0; i < students.Count; i++)
                {
                    int studentid = students[i].StudentID;
                    int courseid = course.CourseID;
                    int enrollmentid = DatabaseConnection.getEnrollmentID(studentid, courseid);

                    if (enrollmentid != 0)
                    {
                        int grade = DatabaseConnection.getStudentGrade(enrollmentid);
                        if (grade != 0)
                        {
                           studentDataGridView.Rows[i].Cells["Grade"].Value = grade; 
                        }
                    }
                }
            }
        }

        private void updateGradesButton_Click(object sender, EventArgs e)
        {
            if (studentDataGridView.DataSource != null)
            {
                foreach (DataGridViewRow row in studentDataGridView.Rows)
                {
                    var cellVal = row.Cells["Grade"].Value;
                    if (cellVal != null)
                    {
                        int grade;
                        if (int.TryParse(cellVal.ToString(), out grade))
                        {
                            var studentidVal = row.Cells["StudentID"].Value;
                            int studentid = int.Parse(studentidVal.ToString());
                            int enrollmentid = DatabaseConnection.getEnrollmentID(studentid, currentCourse.CourseID);
                            DatabaseConnection.updateStudentGrade(enrollmentid, grade);
                        }
                        else
                        {
                            MessageBox.Show("Invalid grade value");
                        }
                    }
                }
            }
        }

        private void sendFeedbackButton_Click(object sender, EventArgs e)
        {
            string feedback = feedbackTextBox.Text;
            if (!feedback.Equals(""))
            {
                DataGridViewRow selectedRow = studentDataGridView.SelectedRows[0];
                int studentId = int.Parse(selectedRow.Cells["StudentID"].Value.ToString());
                int enrollmentId = DatabaseConnection.getEnrollmentID(studentId, currentCourse.CourseID);
                int feedbackId = DatabaseConnection.getFeedbackID(enrollmentId);

                if (feedbackId != 0)
                {
                    DatabaseConnection.updateFeedback(feedbackId, feedback);
                }
                else
                {
                    DatabaseConnection.createFeedback(enrollmentId, feedback);
                }
            }
            else
            {
                MessageBox.Show("Nothing provided in feedback!");
            }
        }

        private void studentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (studentDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = studentDataGridView.SelectedRows[0];
                int studentId = int.Parse(selectedRow.Cells["StudentID"].Value.ToString());
                int enrollmentId = DatabaseConnection.getEnrollmentID(studentId, currentCourse.CourseID);
                int feedbackId = DatabaseConnection.getFeedbackID(enrollmentId);
                if (feedbackId != 0)
                {
                    string message = DatabaseConnection.getFeedbackComment(feedbackId);
                    feedbackTextBox.Text = message;
                }
                else
                {
                    feedbackTextBox.Text = "There is currently no feedback for this student on this course";
                }
            }
        }
    }
}
