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
    public partial class athleteStudentView: Form
    {
        public athleteStudentView()
        {
            InitializeComponent();
        }

        private void athleteStudentView_Load(object sender, EventArgs e)
        {
            List<Student> athletes = DatabaseConnection.getAthleteStudents();
            athleteDataGridView.DataSource = null;
            athleteDataGridView.DataSource = athletes;

            for (int i = 0; i < athletes.Count; i++)
            {
                int studentid = athletes[i].StudentID;
                List<Course> courses = DatabaseConnection.getStudentCourses(studentid);

                for (int j = 0; j < courses.Count; j++)
                {
                    if (j == 0)
                    {
                        athleteDataGridView.Rows[i].Cells["Courses"].Value = courses[j].CourseName + " , ";
                    }
                    else
                    {
                        athleteDataGridView.Rows[i].Cells["Courses"].Value = athleteDataGridView.Rows[i].Cells["Courses"].Value + courses[j].CourseName + " , ";
                    }
                }
            }
        }
    }
}
