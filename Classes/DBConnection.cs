using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_17521061.Classes
{
    class DBConnection
    {
        private static SqlConnection instance;

        private DBConnection()
        {
            instance = new SqlConnection(@"Data Source=DESKTOP-VF82UHS;Initial Catalog=ACCOUNTMANAGEMENT;Integrated Security=True");
        }

        public static SqlConnection GetConnection()
        {
            if (instance == null)
            {
                new DBConnection();
                instance.Open();
            }
            return instance;
        }

        public static SqlConnection CloseConnection()
        {
            instance.Close();
            instance = null;
            return instance;
        }
    }

    //public class ClassSingleton
    //{
    //    public static void main(String[] args)
    //    {
    //        System.Console.WriteLine("--- Singleton Pattern ---");
    //        Singleton single1 = Singleton.getInstance();
    //        Singleton single2 = Singleton.getInstance();
    //        if (single1==single2)
    //        {
    //            System.Console.WriteLine("Unique Instance");
    //        }
    //    }
    //}
}
