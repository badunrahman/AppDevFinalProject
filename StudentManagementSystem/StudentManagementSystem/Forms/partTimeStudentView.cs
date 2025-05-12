using StudentManagementSystem.Database;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace StudentManagementSystem.Forms
{
    public partial class PartTimeStudentView : Form
    {
        private ResourceManager rm = new ResourceManager("StudentManagementSystem.Strings", typeof(PartTimeStudentView).Assembly);

        public PartTimeStudentView()
        {
            InitializeComponent();
        }

        private void SetLanguage(string langCode)
        {
            CultureInfo ci = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = ci;

            label1.Text = rm.GetString("PartTimeInfoHeader", ci);
            partTimeDataGridView.Columns["Courses"].HeaderText = rm.GetString("CoursesColumn", ci);
        }

        private void PartTimeStudentView_Load(object sender, EventArgs e)
        {
            SetLanguage(AppSettings.CurrentLanguage);

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
                        partTimeDataGridView.Rows[i].Cells["Courses"].Value += courses[j].CourseName + " , ";
                    }
                }
            }
        }
    }
}
