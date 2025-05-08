using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [StringLength(100, ErrorMessage = "Course name cannot exceed 100 characters")]
        public string CourseName { get; set; }

        // Constructors
        public Course() { }

        public Course(string courseName)
        {
            CourseName = courseName;
        }

        // Helper methods
        public bool IsValid(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(CourseName))
            {
                errorMessage = "Course name is required.";
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return CourseName;
        }
    }
}