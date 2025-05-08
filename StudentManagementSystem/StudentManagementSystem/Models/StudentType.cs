using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public static class StudentType
    {
        public const string FullTime = "FullTime";
        public const string PartTime = "PartTime";
        public const string Athlete = "Athlete";

        public static string[] GetAllTypes()
        {
            return new[] { FullTime, PartTime, Athlete };
        }

        public static bool IsValid(string type)
        {
            return type == FullTime || type == PartTime || type == Athlete;
        }
    }
}