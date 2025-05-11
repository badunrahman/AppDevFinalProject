using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public static class AppSettings
    {
        private static string _currentLanguage = "en"; // Default to English

        public static string CurrentLanguage
        {
            get => _currentLanguage;
            set => _currentLanguage = value;
        }
    }
}
