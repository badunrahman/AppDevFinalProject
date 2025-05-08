using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    namespace StudentManagementSystem.Models
    {
        public class Teacher
        {
            public int TeacherID { get; set; }

            public int UserID { get; set; }

            [Required(ErrorMessage = "Teacher name is required")]
            [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
            public string Name { get; set; }

            public int CourseID { get; set; }

            // Navigation property
            public Course Course { get; set; }

            // Constructors
            public Teacher() { }

            public Teacher(string name, int courseID, int userID)
            {
                Name = name;
                CourseID = courseID;
                UserID = userID;
            }

            // Helper methods to check the validation
            // name the courseId and the userId cant be empty or be less than 0
            public bool IsValid(out string errorMessage)
            {
                errorMessage = string.Empty;

                if (string.IsNullOrWhiteSpace(Name))
                {
                    errorMessage = "Teacher name is required.";
                    return false;
                }

                if (CourseID <= 0)
                {
                    errorMessage = "Valid course assignment is required.";
                    return false;
                }

                if (UserID <= 0)
                {
                    errorMessage = "Teacher must be associated with a user account.";
                    return false;
                }

                return true;
            }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}