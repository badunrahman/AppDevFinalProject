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

            if (partTimeDataGridView.Columns.Contains("Courses"))
                partTimeDataGridView.Columns["Courses"].HeaderText = rm.GetString("CoursesColumn", ci);

            if (partTimeDataGridView.Columns.Contains("StudentID"))
                partTimeDataGridView.Columns["StudentID"].HeaderText = rm.GetString("Header_StudentID", ci);

            if (partTimeDataGridView.Columns.Contains("Name"))
                partTimeDataGridView.Columns["Name"].HeaderText = rm.GetString("Header_Name", ci);

            if (partTimeDataGridView.Columns.Contains("Address"))
                partTimeDataGridView.Columns["Address"].HeaderText = rm.GetString("Header_Address", ci);

            if (partTimeDataGridView.Columns.Contains("EmergencyContact"))
                partTimeDataGridView.Columns["EmergencyContact"].HeaderText = rm.GetString("Header_Contact", ci);

            if (partTimeDataGridView.Columns.Contains("StudentType"))
                partTimeDataGridView.Columns["StudentType"].HeaderText = rm.GetString("Header_StudentType", ci);
        }

        private void PartTimeStudentView_Load(object sender, EventArgs e)
        {
            ThemeManager.ApplyTheme(this);
            if (ThemeManager.IsDarkTheme)
            {
                partTimeDataGridView.BackgroundColor = Color.FromArgb(30, 30, 30);
                partTimeDataGridView.ForeColor = Color.FromArgb(30, 30, 30);
                partTimeDataGridView.GridColor = Color.DimGray;
                partTimeDataGridView.RowsDefaultCellStyle.ForeColor = Color.White;
                partTimeDataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                partTimeDataGridView.EnableHeadersVisualStyles = false;
                partTimeDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                partTimeDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                partTimeDataGridView.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 50);
                partTimeDataGridView.RowHeadersDefaultCellStyle.ForeColor = Color.White;
            }

            List<Student> partTimeStudents = DatabaseConnection.getPartTimeStudents();
            partTimeDataGridView.DataSource = null;
            partTimeDataGridView.AutoGenerateColumns = true; // Important for header translation
            partTimeDataGridView.DataSource = partTimeStudents;

            // Add course names manually to the custom column
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

           
            SetLanguage(AppSettings.CurrentLanguage);
        }
    }
}
