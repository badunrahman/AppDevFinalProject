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
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Forms
{
    public partial class FullTimeStudent : Form
    {
        private ResourceManager rm = new ResourceManager("StudentManagementSystem.Strings", typeof(FullTimeStudent).Assembly);

        public FullTimeStudent()
        {
            InitializeComponent();
        }

        public class Student
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string EmergencyContact { get; set; }
            public string StudentType { get; set; }
        }

        public static List<Student> getFullTimeStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Students WHERE StudentType = 'FullTime'", conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    students.Add(new Student
                    {
                        StudentID = (int)reader["StudentID"],
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        EmergencyContact = reader["EmergencyContact"].ToString(),
                        StudentType = reader["StudentType"].ToString()
                    });
                }
            }

            return students;
        }

        private void FullTimeStudent_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            if (ThemeManager.IsDarkTheme)
            {
                fullTimeDataGridView.BackgroundColor = Color.FromArgb(30, 30, 30);
                fullTimeDataGridView.ForeColor = Color.FromArgb(30, 30, 30);
                fullTimeDataGridView.GridColor = Color.DimGray;
                fullTimeDataGridView.RowsDefaultCellStyle.ForeColor = Color.White;
                fullTimeDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                fullTimeDataGridView.EnableHeadersVisualStyles = false;
                fullTimeDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                fullTimeDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                fullTimeDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                fullTimeDataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            SetLanguage(AppSettings.CurrentLanguage);

            var students = getFullTimeStudents();
            fullTimeDataGridView.AutoGenerateColumns = true;
            fullTimeDataGridView.DataSource = students;

            SetColumnHeaders();
        }

        private void SetLanguage(string langCode)
        {
            CultureInfo ci = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = ci;

            Title.Text = rm.GetString("FullTimeTitle", ci);
            groupBox1.Text = rm.GetString("FullTimeGroupBox", ci);
        }

        private void SetColumnHeaders()
        {
            CultureInfo ci = Thread.CurrentThread.CurrentUICulture;

            if (fullTimeDataGridView.Columns.Contains("StudentID"))
                fullTimeDataGridView.Columns["StudentID"].HeaderText = rm.GetString("Header_StudentID", ci);

            if (fullTimeDataGridView.Columns.Contains("Name"))
                fullTimeDataGridView.Columns["Name"].HeaderText = rm.GetString("Header_Name", ci);

            if (fullTimeDataGridView.Columns.Contains("Address"))
                fullTimeDataGridView.Columns["Address"].HeaderText = rm.GetString("Header_Address", ci);

            if (fullTimeDataGridView.Columns.Contains("EmergencyContact"))
                fullTimeDataGridView.Columns["EmergencyContact"].HeaderText = rm.GetString("Header_Contact", ci);

            if (fullTimeDataGridView.Columns.Contains("StudentType"))
                fullTimeDataGridView.Columns["StudentType"].HeaderText = rm.GetString("Header_StudentType", ci);
        }
    }
}
