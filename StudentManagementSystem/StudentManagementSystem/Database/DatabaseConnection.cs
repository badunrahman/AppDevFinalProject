using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Configuration;
using StudentManagementSystem.Models;
using StudentManagementSystem.Models.StudentManagementSystem.Models;
using System.Windows.Forms;
using System.Web;

namespace StudentManagementSystem.Database
{
    public class DatabaseConnection
    {
        // Get connection string from App.config
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["StudentManagementDB"].ConnectionString;

        /// <summary>
        /// Creates and returns a new SqlConnection object
        /// </summary>
        /// <returns>An open SqlConnection</returns>
        public static SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                throw new Exception("Database connection failed: " + ex.Message);
            }
        }

        /// <summary>
        /// Executes a non-query SQL command
        /// </summary>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>Number of rows affected</returns>
        public static int ExecuteNonQuery(string commandText, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    return command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Executes a SQL query and returns a single value
        /// </summary>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>The first column of the first row in the result set</returns>
        public static object ExecuteScalar(string commandText, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    return command.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Executes a SQL query and returns a DataTable
        /// </summary>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>A DataTable containing the query results</returns>
        public static DataTable ExecuteQuery(string commandText, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection connection = GetConnection())
            {
                using (SqlCommand command = new SqlCommand(commandText, connection))
                {
                    if (parameters != null)
                    {
                        foreach (KeyValuePair<string, object> param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }

                    return dataTable;
                }
            }
        }

        /// <summary>
        /// Executes a SQL query and returns a SqlDataReader
        /// </summary>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>A SqlDataReader containing the query results</returns>
        public static SqlDataReader ExecuteReader(string commandText, Dictionary<string, object> parameters = null)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(commandText, connection);

            if (parameters != null)
            {
                foreach (KeyValuePair<string, object> param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                }
            }

            // Note: CommandBehavior.CloseConnection will close the connection when the reader is closed
            return command.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// Begins a SQL transaction
        /// </summary>
        /// <returns>A SqlTransaction object</returns>
        public static SqlTransaction BeginTransaction()
        {
            SqlConnection connection = GetConnection();
            return connection.BeginTransaction();
        }

        /// <summary>
        /// Executes a SQL command as part of a transaction
        /// </summary>
        /// <param name="transaction">The transaction to use</param>
        /// <param name="commandText">The SQL command to execute</param>
        /// <param name="parameters">Optional SQL parameters</param>
        /// <returns>Number of rows affected</returns>
        public static int ExecuteTransactionNonQuery(SqlTransaction transaction, string commandText, Dictionary<string, object> parameters = null)
        {
            using (SqlCommand command = new SqlCommand(commandText, transaction.Connection, transaction))
            {
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }
                }

                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Tests the database connection
        /// </summary>
        /// <returns>True if the connection is successful</returns>
        public static bool TestConnection()
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    return connection.State == ConnectionState.Open;
                }
            }
            catch
            {
                return false;
            }
        }

        // Login Validation
        public static Boolean isValidLogin(string username, string password)
        {
            using (SqlConnection connnection = GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";
                using (SqlCommand cmd = new SqlCommand(query, connnection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public static Boolean checkUsernameExists(string username)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0) > 0;
                    }
                }
            }

            return false;
        }

        public static void createUser(string username, string password, string role)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);

                cmd.ExecuteNonQuery();
            }
        }

        // Get UserID by login username and password
        public static int getUserIdByLogin(string username, string password)
        {
            using (SqlConnection connnection = GetConnection())
            {
                string query = "SELECT UserID FROM Users WHERE Username = @username AND Password = @password";
                using (SqlCommand cmd = new SqlCommand(query, connnection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int id = (int)cmd.ExecuteScalar();
                    return id;
                }
            }
        }

        // Get TeacherID by UserID
        public static int getTeacherIdByUserId(int userId)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT TeacherID FROM Teachers WHERE UserID = " + userId;
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    int id = (int)cmd.ExecuteScalar();
                    return id;
                }

            }
        }

        public static Teacher getTeacherByID(int teacherId)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Teachers WHERE TeacherID = " + teacherId;
                SqlCommand cmd = new SqlCommand(query, connection);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(1);
                        string name = reader.GetString(2);

                        return new Teacher(name, userId);
                    }
                }
            }

            return null;
        }

        public static List<Course> getTeacherCourses(int teacherId)
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Courses WHERE TeacherID = " + teacherId;
                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string courseName = reader.GetString(1);
                        int courseId = reader.GetInt32(0);
                        courses.Add(new Course(courseName, courseId));
                    }
                }

                return courses;
            }
        }

        public static List<Course> getStudentCourses(int studentid)
        {
            List<Course> courses = new List<Course>();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Courses WHERE CourseID IN (SELECT CourseID FROM Enrollments WHERE StudentID = @studentid)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@studentid", studentid);
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string courseName = reader.GetString(1);
                        int courseId = reader.GetInt32(0);
                        courses.Add(new Course(courseName, courseId));
                    }
                }
            }

            return courses;
        }

        public static List<Student> getCourseStudents(int courseID)
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Students WHERE StudentID IN " +
                    "(SELECT StudentID FROM Enrollments WHERE CourseID = @CourseID)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@CourseID", courseID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int studentID = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string address = reader.GetString(2);
                        string contact = reader.GetString(3);
                        string type = reader.GetString(4);
                        students.Add(new Student(studentID, name, address, contact, type));
                    }
                }

                return students;
            }
        }

        public static List<Student> getAthleteStudents()
        {
            List<Student> students = new List<Student>();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT * FROM Students WHERE StudentType = @type";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@type", "Athlete");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int studentID = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string address = reader.GetString(2);
                        string contact = reader.GetString(3);
                        string type = reader.GetString(4);
                        students.Add(new Student(studentID, name, address, contact, type));
                    }
                }
            }

            return students;
        }

        public static string getUserRole(int userId)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT Role FROM Users WHERE UserID = @userId";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userId", userId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
            }
            return null;
        }

        public static int getEnrollmentID(int studentId, int courseId)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT EnrollmentID FROM Enrollments WHERE StudentID = @studentid AND CourseID = @courseid";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@studentid", studentId);
                command.Parameters.AddWithValue("@courseid", courseId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }

            return 0;
        }

        public static int getStudentGrade(int enrollmentId)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT Grade FROM Grades WHERE EnrollmentID = @enrollid";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@enrollid", enrollmentId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            return 0;
        }

        public static void updateStudentGrade(int enrollmentid, int grade)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "UPDATE Grades SET Grade = @grade WHERE EnrollmentID = @enrollmentid";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.Parameters.AddWithValue("@enrollmentid", enrollmentid);

                cmd.ExecuteNonQuery();
            }
        }

        public static int getFeedbackID(int enrollmentid)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT FeedbackID FROM Feedback WHERE EnrollmentID = @enrollid";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("enrollid", enrollmentid);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }

            return 0;
        }

        public static void updateFeedback(int feedbackid, string feedback)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "UPDATE Feedback SET Comment = @comment WHERE FeedbackID = @feedbackid";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@comment", feedback);
                cmd.Parameters.AddWithValue("@feedbackid", feedbackid);

                cmd.ExecuteNonQuery();
            }
        }

        public static void createFeedback(int enrollmentid, string feedback)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO Feedback (EnrollmentID, Comment, DateAdded) VALUES (@enrollmentid, @comment, @date)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@enrollmentid", enrollmentid);
                cmd.Parameters.AddWithValue("@comment", feedback);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                cmd.ExecuteNonQuery();
            }
        }

        public static string getFeedbackComment(int feedbackid)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT Comment FROM Feedback WHERE FeedbackID = @feedbackid";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@feedbackid", feedbackid);
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
            }

            return "";
        }

        public static void createTeacher(int userId, string name)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "INSERT INTO Teachers (UserID, Name) VALUES (@userid, @name)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userid", userId);
                cmd.Parameters.AddWithValue("@name", name);

                cmd.ExecuteNonQuery();
            }
        }
    }
}