using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage = "Student name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        public string Name { get; set; }

        [StringLength(255, ErrorMessage = "Address cannot exceed 255 characters")]
        public string Address { get; set; }

        [StringLength(50, ErrorMessage = "Emergency contact cannot exceed 50 characters")]
        public string EmergencyContact { get; set; }

        [Required(ErrorMessage = "Student type is required")]
        public string StudentType { get; set; }

        // Constructors
        public Student() { }

        public Student(string name, string address, string emergencyContact, string studentType)
        {
            Name = name;
            Address = address;
            EmergencyContact = emergencyContact;
            StudentType = studentType;
        }

        // Helper methods
        public bool IsValid(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(Name))
            {
                errorMessage = "Student name is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(StudentType))
            {
                errorMessage = "Student type is required.";
                return false;
            }

            if (!IsValidStudentType(StudentType))
            {
                errorMessage = "Invalid student type. Must be FullTime, PartTime, or Athlete.";
                return false;
            }

            return true;
        }

        private bool IsValidStudentType(string type)
        {
            return type == "FullTime" || type == "PartTime" || type == "Athlete";
        }

        public override string ToString()
        {
            return $"{StudentID}: {Name} ({StudentType})";
        }
    }
}