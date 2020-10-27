using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement
{
    class Globals
    {
        public static string version = "1.0";
        public static Boolean isLogged = false;
        public static int accessLevel = 0;
        public static string localPath = System.Environment.CurrentDirectory;
        //public static string localPath = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string DBName = "StoreManagement.db";
        public static string DBPath = localPath + @"\db\";
        public static string photoPath = localPath + @"\photos\";
    }
}
