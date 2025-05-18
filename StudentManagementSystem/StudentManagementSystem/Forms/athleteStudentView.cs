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
    public partial class athleteStudentView : Form
    {
        private ResourceManager rm = new ResourceManager("StudentManagementSystem.Strings", typeof(athleteStudentView).Assembly);

        public athleteStudentView()
        {
            InitializeComponent();
        }

        private void SetLanguage(string langCode)
        {
            CultureInfo ci = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentUICulture = ci;

            label1.Text = rm.GetString("AthleteInfoHeader", ci);
            athleteDataGridView.Columns["Courses"].HeaderText = rm.GetString("CoursesColumn", ci);
        }

        private void athleteStudentView_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            if (ThemeManager.IsDarkTheme)
            {
                athleteDataGridView.BackgroundColor = Color.FromArgb(30, 30, 30);
                athleteDataGridView.ForeColor = Color.FromArgb(30, 30, 30);
                athleteDataGridView.GridColor = Color.DimGray;
                athleteDataGridView.RowsDefaultCellStyle.ForeColor = Color.White;
                athleteDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                athleteDataGridView.EnableHeadersVisualStyles = false;
                athleteDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                athleteDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                athleteDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                athleteDataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            }
            SetLanguage(AppSettings.CurrentLanguage);

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
                        athleteDataGridView.Rows[i].Cells["Courses"].Value += courses[j].CourseName + " , ";
                    }
                }
            }
        }
    }
}
