using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagementSystem.Models.StudentManagementSystem.Models;

namespace StudentManagementSystem.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public int TeacherID { get; set; }

        // Navigation properties
        public Student Student { get; set; }
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }

        // Constructors
        public Enrollment() { }

        public Enrollment(int studentID, int courseID, int teacherID)
        {
            StudentID = studentID;
            CourseID = courseID;
            TeacherID = teacherID;
        }

        // Helper methods
        public bool IsValid(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (StudentID <= 0)
            {
                errorMessage = "Valid student is required.";
                return false;
            }

            if (CourseID <= 0)
            {
                errorMessage = "Valid course is required.";
                return false;
            }

            if (TeacherID <= 0)
            {
                errorMessage = "Valid teacher is required.";
                return false;
            }

            return true;
        }
    }
}