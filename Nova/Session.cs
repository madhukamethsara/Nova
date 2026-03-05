using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova
{
    public static class Session
    {
        public static string LoggedInUsername { get; private set; }
        public static string LoggedInPassword { get; private set; }
        public static string LoggedInPhotoPath { get; private set; }  

        public static void SetLoggedInUser(string username, string password, string photoPath)
        {
            LoggedInUsername = username;
            LoggedInPassword = password;
            LoggedInPhotoPath = photoPath;
        }

        public static string GetLoggedInUsername() => LoggedInUsername;
        public static string GetLoggedInPassword() => LoggedInPassword;
        public static string GetLoggedInPhotoPath() => LoggedInPhotoPath;
    }

}
