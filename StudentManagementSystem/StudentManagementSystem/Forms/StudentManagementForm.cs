using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Forms
{
    public partial class StudentManagementForm : Form
    {
        private bool isDarkTheme = false;
        private ResourceManager rm = new ResourceManager("StudentManagementSystem.Strings", typeof(StudentManagementForm).Assembly);

        public StudentManagementForm()
        {
            InitializeComponent();
        }

        private class CourseItem
        {
            public int CourseID { get; }
            public string CourseName { get; }
            public string TeacherName { get; }

            public CourseItem(int id, string name, string teacher)
            {
                CourseID = id;
                CourseName = name;
                TeacherName = teacher;
            }

            public override string ToString() => CourseName;
        }

        private List<CourseItem> _courseItems;


        private void savebutton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.Trim();
            string address = addressTextBox.Text.Trim();
            string contact = contactTextBox.Text.Trim();
            string studentType = fullTimeRadioButton.Checked ? "FullTime"
                               : partTimeRadioButton.Checked ? "PartTime"
                               : athleteRadioButton.Checked ? "Athlete"
                               : "";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(studentType))
            {
                MessageBox.Show(rm.GetString("FillFields", CultureInfo.CurrentUICulture));
                return;
            }

            if (coursesCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show(rm.GetString("SelectCourse", CultureInfo.CurrentUICulture));
                return;
            }

            int newStudentId;

            using (var conn = DatabaseConnection.GetConnection())
            {
                using (var insertCmd = new SqlCommand(@"
                INSERT INTO Students(Name,Address,EmergencyContact,StudentType)
                OUTPUT INSERTED.StudentID
                VALUES(@n,@a,@c,@t)", conn))
                {
                    insertCmd.Parameters.AddWithValue("@n", name);
                    insertCmd.Parameters.AddWithValue("@a", address);
                    insertCmd.Parameters.AddWithValue("@c", contact);
                    insertCmd.Parameters.AddWithValue("@t", studentType);
                    newStudentId = (int)insertCmd.ExecuteScalar();
                }

                using (var enrollCmd = new SqlCommand(
                    "INSERT INTO Enrollments(StudentID,CourseID) VALUES(@sid,@cid)", conn))
                {
                    enrollCmd.Parameters.AddWithValue("@sid", newStudentId);
                    var p = enrollCmd.Parameters.Add("@cid", SqlDbType.Int);

                    foreach (CourseItem ci in coursesCheckedListBox.CheckedItems)
                    {
                        p.Value = ci.CourseID;
                        enrollCmd.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show(rm.GetString("StudentSaved", CultureInfo.CurrentUICulture));

            nameTextBox.Clear();
            addressTextBox.Clear();
            contactTextBox.Clear();
            fullTimeRadioButton.Checked =
            partTimeRadioButton.Checked =
            athleteRadioButton.Checked = false;
            coursesCheckedListBox.ClearSelected();
            teachersListBox.Items.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

        }

        private void StudentManagementForm_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            SetLanguage(AppSettings.CurrentLanguage);

            _courseItems = new List<CourseItem>();
            using (var conn = DatabaseConnection.GetConnection())
            using (var cmd = new SqlCommand(@"
                SELECT c.CourseID, c.CourseName, t.Name AS TeacherName
                FROM Courses c
                JOIN Teachers t ON c.TeacherID = t.TeacherID", conn))
            using (var rdr = cmd.ExecuteReader())
            {
                while (rdr.Read())
                {
                    _courseItems.Add(new CourseItem(
                        (int)rdr["CourseID"],
                        rdr["CourseName"].ToString(),
                        rdr["TeacherName"].ToString()
                    ));
                }
            }

            coursesCheckedListBox.DataSource = _courseItems;
            coursesCheckedListBox.DisplayMember = nameof(CourseItem.CourseName);
            coursesCheckedListBox.ItemCheck += coursesCheckedListBox_ItemCheck;
        }

        private void SetLanguage(string langCode)
        {
            CultureInfo ci = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = ci;

            createStudentTitleLabel.Text = rm.GetString("CreateStudentTitle", ci);
            
            nameLabel.Text = rm.GetString("LabelName", ci);
            addressLabel.Text = rm.GetString("LabelAddress", ci);
            contactLabel.Text = rm.GetString("LabelContact", ci);
            studentTypeLabel.Text = rm.GetString("LabelStudentType", ci);
            fullTimeRadioButton.Text = rm.GetString("RadioFullTime", ci);
            partTimeRadioButton.Text = rm.GetString("RadioPartTime", ci);
            athleteRadioButton.Text = rm.GetString("RadioAthletes", ci);
            coursesLabel.Text = rm.GetString("LabelCourses", ci);
            teacherLabel.Text = rm.GetString("LabelTeacher", ci);
            savebutton.Text = rm.GetString("SaveBtn", ci);
            clearButton.Text = rm.GetString("ClearBtn", ci);
        }

        private void coursesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)UpdateTeachersList);
        }

        private void UpdateTeachersList()
        {
            teachersListBox.Items.Clear();
            var seen = new HashSet<string>();

            foreach (CourseItem ci in coursesCheckedListBox.CheckedItems)
                if (seen.Add(ci.TeacherName))
                    teachersListBox.Items.Add(ci.TeacherName);
        }

    }
}