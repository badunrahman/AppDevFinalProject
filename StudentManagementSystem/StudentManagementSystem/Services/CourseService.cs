using System.Collections.Generic;
using System.Data.SqlClient;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Services
{
    public static class CourseService
    {
        public static List<string> GetCoursesByStudentId(int studentId)
        {
            List<string> courses = new List<string>();

            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = @"SELECT c.CourseName 
                                 FROM Enrollments e
                                 JOIN Courses c ON e.CourseID = c.CourseID
                                 WHERE e.StudentID = @studentId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@studentId", studentId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    courses.Add(reader["CourseName"].ToString());
                }
            }

            return courses;
        }
    }
}
