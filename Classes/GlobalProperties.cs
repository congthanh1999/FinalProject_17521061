using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_17521061.Classes
{
    public static class GlobalProperties
    {
        public static string curUsername;
        public static string curUserPassword;
        public static string curName;
        public static int maTK;
        public static int diaChi;
        public static bool isLoggedIn = false;
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");
    }
}
