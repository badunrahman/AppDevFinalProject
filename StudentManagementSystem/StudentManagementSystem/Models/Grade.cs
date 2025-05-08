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
        public class Grade
        {
            public int GradeID { get; set; }
            public int EnrollmentID { get; set; }

            [StringLength(5, ErrorMessage = "Grade cannot exceed 5 characters")]
            public string Value { get; set; }

            // Navigation property
            public Enrollment Enrollment { get; set; }

            // Constructors
            public Grade() { }

            public Grade(int enrollmentID, string value)
            {
                EnrollmentID = enrollmentID;
                Value = value;
            }

            // Helper methods
            public bool IsValid(out string errorMessage)
            {
                errorMessage = string.Empty;

                if (EnrollmentID <= 0)
                {
                    errorMessage = "Valid enrollment is required.";
                    return false;
                }

                if (string.IsNullOrWhiteSpace(Value))
                {
                    errorMessage = "Grade value is required.";
                    return false;
                }

                return true;
            }
        }
    }
}