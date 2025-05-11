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
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Forms
{
    public partial class FullTimeStudent : Form
    {
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
            var students = getFullTimeStudents();

           
            fullTimeDataGridView.AutoGenerateColumns = true;

            fullTimeDataGridView.DataSource = students; ;
        }
    }
}