using System.Data.SqlClient;
using StudentManagementSystem.Models;
using StudentManagementSystem.Database;

namespace StudentManagementSystem.Services
{
    public static class StudentService
    {
        public static Student GetStudentById(int id)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT * FROM Students WHERE StudentID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new Student
                    {
                        StudentID = (int)reader["StudentID"],
                        Name = reader["Name"].ToString(),
                        Address = reader["Address"].ToString(),
                        EmergencyContact = reader["EmergencyContact"].ToString(),
                        StudentType = reader["StudentType"].ToString()
                    };
                }
            }

            return null;
        }
    }
}
