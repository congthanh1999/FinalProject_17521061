using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_17521061.DatabaseCore
{
    class DBSQLServerUtils
    {
        public static SqlConnection GetDBConnection(string datasource, string database)
        {
            //no password
            string connString = "Data Source = " + datasource + @"; Initial Catalog = " + database + @"; Integrated Security = True";

            //Data Source=.\SQLEXPRESS;Initial Catalog=THPT;Integrated Security=True
            SqlConnection connect = new SqlConnection(connString);
            return connect;
        }
    }
}
