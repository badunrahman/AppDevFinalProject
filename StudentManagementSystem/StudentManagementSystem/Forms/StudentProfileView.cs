using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Forms
{
    public partial class StudentProfileView : Form
    {
        public StudentProfileView()
        {
            InitializeComponent();

            // wire up events
            this.Load += StudentProfileView_Load;
            searchButton.Click += searchButton_Click;
            teachersNameComboBox.SelectedIndexChanged += teachersNameComboBox_SelectedIndexChanged;
            teacherIdComboBox.SelectedIndexChanged += teacherIdComboBox_SelectedIndexChanged;
            chooseCoursesComboBox.SelectedIndexChanged += chooseCoursesComboBox_SelectedIndexChanged;
        }

        private void StudentProfileView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDBDataSet.Grades' table. You can move, or remove it, as needed.
            this.gradesTableAdapter.Fill(this.studentDBDataSet.Grades);
            // make the profile picture circular
            studentProfilePictureBox.Paint += studentProfilePictureBox_Paint;
        }

        private void studentProfilePictureBox_Paint(object sender, PaintEventArgs e)
        {
            var pic = (PictureBox)sender;
            using (var gp = new GraphicsPath())
            using (var pen = new Pen(Color.Black, 4))
            {
                gp.AddEllipse(0, 0, pic.Width - 1, pic.Height - 1);
                pic.Region = new Region(gp);

                e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;
                e.Graphics.DrawEllipse(pen, 1, 1, pic.Width - 3, pic.Height - 3);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // 1) parse student ID
            int studentId;
            if (!int.TryParse(idTextBox.Text.Trim(), out studentId))
            {
                MessageBox.Show("Please enter a valid numeric Student ID.");
                return;
            }

            // 2) load basic student info
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT Name, Address, EmergencyContact, StudentType
                  FROM Students
                 WHERE StudentID = @sid", conn))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (!r.Read())
                    {
                        MessageBox.Show("Student not found.");
                        return;
                    }

                    nameTextBox.Text = r["Name"].ToString();
                    addressTextBox.Text = r["Address"].ToString();
                    contactTextBox.Text = r["EmergencyContact"].ToString();
                    studentTypeTextBox.Text = r["StudentType"].ToString();
                }
            }

            // 3) load distinct teachers for this student
            var teachers = new List<Tuple<int, string>>();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT DISTINCT t.TeacherID, t.Name
                  FROM Enrollments e
                  JOIN Courses  c ON e.CourseID  = c.CourseID
                  JOIN Teachers t ON c.TeacherID = t.TeacherID
                 WHERE e.StudentID = @sid", conn))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                        teachers.Add(Tuple.Create((int)r["TeacherID"], r["Name"].ToString()));
                }
            }

            // bind teacher-name ComboBox
            teachersNameComboBox.DataSource = teachers;
            teachersNameComboBox.DisplayMember = "Item2";
            teachersNameComboBox.ValueMember = "Item1";

            // bind teacher-ID ComboBox
            teacherIdComboBox.DataSource = teachers;
            teacherIdComboBox.DisplayMember = "Item1";
            teacherIdComboBox.ValueMember = "Item2";

            // 4) load all feedback
            var allFeedback = new List<string>();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT c.CourseName, f.Comment
                  FROM Feedback    f
                  JOIN Enrollments e ON f.EnrollmentID = e.EnrollmentID
                  JOIN Courses     c ON e.CourseID     = c.CourseID
                 WHERE e.StudentID = @sid", conn))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                using (SqlDataReader r = cmd.ExecuteReader())
                    while (r.Read())
                        allFeedback.Add($"{r["CourseName"]}: {r["Comment"]}");
            }
            feedBackTextBox.Lines = allFeedback.ToArray();

            // 5) load all grades into the DataGridView
            DataTable dtGrades = new DataTable();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT
                    c.CourseName AS Course,
                    g.Value      AS Grade
                  FROM Grades g
                  JOIN Enrollments e ON g.EnrollmentID = e.EnrollmentID
                  JOIN Courses     c ON e.CourseID     = c.CourseID
                 WHERE e.StudentID  = @sid", conn))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dtGrades);
                }
            }
            gradesDataGridView.DataSource = dtGrades;
            gradesDataGridView.AutoResizeColumns();
        }

        private void teachersNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sync the ID ComboBox
            var selected = teachersNameComboBox.SelectedItem as Tuple<int, string>;
            if (selected != null)
                teacherIdComboBox.SelectedValue = selected.Item1;

            LoadCoursesForSelectedTeacher();
        }

        private void teacherIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sync the Name ComboBox
            var selected = teacherIdComboBox.SelectedItem as Tuple<int, string>;
            if (selected != null)
                teachersNameComboBox.SelectedIndex =
                    teachersNameComboBox.FindStringExact(selected.Item2);

            LoadCoursesForSelectedTeacher();
        }

        private void LoadCoursesForSelectedTeacher()
        {
            var teacher = teachersNameComboBox.SelectedItem as Tuple<int, string>;
            if (teacher == null) return;
            int teacherId = teacher.Item1;

            int studentId;
            if (!int.TryParse(idTextBox.Text, out studentId)) return;

            var courses = new List<Tuple<int, string>>();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT c.CourseID, c.CourseName
                  FROM Enrollments e
                  JOIN Courses     c ON e.CourseID = c.CourseID
                 WHERE e.StudentID = @sid
                   AND c.TeacherID = @tid", conn))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@tid", teacherId);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                        courses.Add(Tuple.Create((int)r["CourseID"], r["CourseName"].ToString()));
                }
            }

            chooseCoursesComboBox.DataSource = courses;
            chooseCoursesComboBox.DisplayMember = "Item2";
            chooseCoursesComboBox.ValueMember = "Item1";
        }

        private void chooseCoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var course = chooseCoursesComboBox.SelectedItem as Tuple<int, string>;
            if (course == null) return;
            int courseId = course.Item1;

            int studentId;
            if (!int.TryParse(idTextBox.Text, out studentId)) return;

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT Comment
                  FROM Feedback    f
                  JOIN Enrollments e ON f.EnrollmentID = e.EnrollmentID
                 WHERE e.StudentID = @sid
                   AND e.CourseID  = @cid", conn))
            {
                cmd.Parameters.AddWithValue("@sid", studentId);
                cmd.Parameters.AddWithValue("@cid", courseId);
                object o = cmd.ExecuteScalar();
                feedBackForEachCourseTextBox.Text =
                    (o == null ? "(no feedback yet)" : o.ToString());
            }
        }
    }
}
