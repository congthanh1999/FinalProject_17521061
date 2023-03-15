using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_17521061.DatabaseCore
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection(string severName = @"DESKTOP-VF82UHS", string dbName = "ACCOUNTMANAGEMENT")
        {
            string datasource = severName;
            string database = dbName;
            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }
    }
}
