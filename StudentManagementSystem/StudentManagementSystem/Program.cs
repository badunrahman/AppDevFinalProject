using System;
using System.Windows.Forms;
using StudentManagementSystem.Database;
using StudentManagementSystem.Forms;
using StudentManagementSystem.Models;

namespace StudentManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 🔍 Test DB connection before starting app
            TestDatabaseConnection();

            Application.Run(new StudentProfileView()); // continue to login screen
        }

        /// <summary>
        /// Tries to connect to the database and shows a message.
        /// </summary>
        private static void TestDatabaseConnection()
        {
            try
            {
                bool isConnected = DatabaseConnection.TestConnection();
                if (isConnected)
                {
                    MessageBox.Show("✅ Database connection successful!", "Connection Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("❌ Failed to connect to the database.", "Connection Test",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error testing connection:\n{ex.Message}", "Connection Test",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
