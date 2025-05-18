using StudentManagementSystem.Database;
using StudentManagementSystem.Models;
using StudentManagementSystem.Models.StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class TeacherDashboard : Form
    {
        private int userId;
        private int teacherId;
        private Course currentCourse;
        private ResourceManager rm = new ResourceManager("StudentManagementSystem.Strings", typeof(TeacherDashboard).Assembly);

        public TeacherDashboard(int id)
        {
            InitializeComponent();
            userId = id;
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            if (ThemeManager.IsDarkTheme)
            {
                studentDataGridView.BackgroundColor = Color.FromArgb(30, 30, 30);
                studentDataGridView.ForeColor = Color.FromArgb(30, 30, 30);
                studentDataGridView.GridColor = Color.DimGray;
                studentDataGridView.RowsDefaultCellStyle.ForeColor = Color.White;
                studentDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                studentDataGridView.EnableHeadersVisualStyles = false;
                studentDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                studentDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                studentDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                studentDataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            SetLanguage(AppSettings.CurrentLanguage);

            int teachID = DatabaseConnection.getTeacherIdByUserId(userId);
            teacherId = teachID;
            Teacher teacher = DatabaseConnection.getTeacherByID(teacherId);

            if (teacher == null)
            {
                MessageBox.Show("No teacher found");
            }

            IdLabel.Text = rm.GetString("LabelTeacherID", CultureInfo.CurrentUICulture) + ": " + teacher.UserID;
            nameLabel.Text = rm.GetString("LabelName", CultureInfo.CurrentUICulture) + ": " + teacher.Name;

            List<Course> courses = DatabaseConnection.getTeacherCourses(teacherId);
            foreach (var course in courses)
            {
                coursesListBox.Items.Add(course);
                courseComboBox.Items.Add(course);
            }
        }

        private void SetLanguage(string langCode)
        {
            CultureInfo ci = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = ci;

            this.Text = rm.GetString("TeacherDashboardTitle", ci);
            titleLabel.Text = rm.GetString("Title", ci);
            chooseCourseLabel.Text = rm.GetString("ChooseCourse", ci);
            label2.Text = rm.GetString("StudentsLabel", ci);
            teacherProfileGroupBox.Text = rm.GetString("TeacherProfileGroupBox", ci);
            coursesLabel.Text = rm.GetString("CoursesTaught", ci);
            feedbackLabel.Text = rm.GetString("FeedbackLabel", ci);
            sendFeedbackButton.Text = rm.GetString("SendFeedbackButton", ci);
            updateGradesButton.Text = rm.GetString("UpdateGradesButton", ci);

            if (studentDataGridView.Columns.Contains("Grade"))
            {
                studentDataGridView.Columns["Grade"].HeaderText = rm.GetString("GradeColumn", ci);
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
            MessageBox.Show(rm.GetString("ProvidedGrades", CultureInfo.CurrentUICulture));
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

                MessageBox.Show(rm.GetString("FeedbackSent", CultureInfo.CurrentUICulture));
            }
            else
            {
                MessageBox.Show(rm.GetString("EmptyFeedback", CultureInfo.CurrentUICulture));
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
                    feedbackTextBox.Text = rm.GetString("NoFeedbackMessage", CultureInfo.CurrentUICulture);
                }
            }
        }
    }
}
