using StudentManagementSystem.Database;
using StudentManagementSystem.Models;
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
    public partial class PartTimeStudentView: Form
    {
        public PartTimeStudentView()
        {
            InitializeComponent();
        }

        private void PartTimeStudentView_Load(object sender, EventArgs e)
        {
            List<Student> partTimeStudents = DatabaseConnection.getPartTimeStudents();
            partTimeDataGridView.DataSource = null;
            partTimeDataGridView.DataSource = partTimeStudents;

            for (int i = 0; i < partTimeStudents.Count; i++)
            {
                int studentid = partTimeStudents[i].StudentID;
                List<Course> courses = DatabaseConnection.getStudentCourses(studentid);

                for (int j = 0; j < courses.Count; j++)
                {
                    if (j == 0)
                    {
                        partTimeDataGridView.Rows[i].Cells["Courses"].Value = courses[j].CourseName + " , ";
                    }
                    else
                    {
                        partTimeDataGridView.Rows[i].Cells["Courses"].Value = partTimeDataGridView.Rows[i].Cells["Courses"].Value + courses[j].CourseName + " , ";
                    }
                }
            }
        }
    }
}
