using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Forms
{
    public partial class StudentManagementForm : Form
    {
        private bool isDarkTheme = false;
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

            // so the CheckedListBox will show CourseName
            public override string ToString() => CourseName;
        }

        // will hold all courses once we load them
        private List<CourseItem> _courseItems;


        private void creatStudnetTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void createStudentGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void partTimeRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void athleteRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }



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
                MessageBox.Show("Please fill in Name and select a Student Type.");
                return;
            }

            if (coursesCheckedListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one course.");
                return;
            }

            int newStudentId;

            using (var conn = DatabaseConnection.GetConnection())
            {
                // 1) Insert student and grab new ID
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

                // 2) Enroll in each checked course
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

            MessageBox.Show("✅ Student created and enrolled successfully.");

            // clear form
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
            // ─── LOAD COURSES & WIRE UP ────────────────────────────────────
            _courseItems = new List<CourseItem>();
            using (var conn = DatabaseConnection.GetConnection())
            using (var cmd = new SqlCommand(@"
        SELECT c.CourseID, c.CourseName, t.Name AS TeacherName
          FROM Courses c
          JOIN Teachers t ON c.TeacherID = t.TeacherID
    ", conn))
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

            // bind to CheckedListBox
            coursesCheckedListBox.DataSource = _courseItems;
            coursesCheckedListBox.DisplayMember = nameof(CourseItem.CourseName);

            // update teacher list whenever a course is checked/unchecked
            coursesCheckedListBox.ItemCheck += coursesCheckedListBox_ItemCheck;
        }




        private void coursesCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // CheckedItems is updated *after* this event, so defer:
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

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.ForeColor = Color.White;

            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = Color.FromArgb(45, 45, 45);
                ctrl.ForeColor = Color.White;
            }
        }

        private void ApplyLightTheme()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;

            foreach (Control ctrl in this.Controls)
            {
                ctrl.BackColor = Color.White;
                ctrl.ForeColor = Color.Black;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void teachersCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coursesCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void teachersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            if (isDarkTheme)
            {
                ApplyLightTheme();
            }
            else
            {
                ApplyDarkTheme();
            }
            isDarkTheme = !isDarkTheme;
        }
    }
}
