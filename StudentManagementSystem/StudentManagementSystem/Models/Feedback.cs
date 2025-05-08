using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    using System;

    namespace StudentManagementSystem.Models
    {
        public class Feedback
        {
            public int FeedbackID { get; set; }
            public int EnrollmentID { get; set; }
            public string Comment { get; set; }
            public DateTime DateAdded { get; set; }

            // Navigation property
            public Enrollment Enrollment { get; set; }

            // Constructors
            public Feedback()
            {
                DateAdded = DateTime.Now;
            }

            public Feedback(int enrollmentID, string comment)
            {
                EnrollmentID = enrollmentID;
                Comment = comment;
                DateAdded = DateTime.Now;
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

                if (string.IsNullOrWhiteSpace(Comment))
                {
                    errorMessage = "Feedback comment is required.";
                    return false;
                }

                return true;
            }
        }
    }
}