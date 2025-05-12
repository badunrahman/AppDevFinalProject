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
            SetLanguage(AppSettings.CurrentLanguage); 

            var students = getFullTimeStudents();
            fullTimeDataGridView.AutoGenerateColumns = true;
            fullTimeDataGridView.DataSource = students;
        }

        private void SetLanguage(string langCode)
        {
            CultureInfo ci = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = ci;

            Title.Text = rm.GetString("FullTimeTitle", ci);
            groupBox1.Text = rm.GetString("FullTimeGroupBox", ci);
        }
    }
}
