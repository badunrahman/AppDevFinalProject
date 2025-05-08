using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255, ErrorMessage = "Password cannot exceed 255 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }

        // Constructors
        public User() { }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        // Helper methods to validate
        // cant have empty string or whitespaces
        public bool IsValid(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(Username))
            {
                errorMessage = "Username is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                errorMessage = "Password is required.";
                return false;
            }

            if (!IsValidRole(Role))
            {
                errorMessage = "Invalid role. Must be Admin or Teacher.";
                return false;
            }

            return true;
        }

        private bool IsValidRole(string role)
        {
            return role == "Admin" || role == "Teacher";
        }

        public bool IsAdmin()
        {
            return Role == "Admin";
        }

        public bool IsTeacher()
        {
            return Role == "Teacher";
        }
    }
}