using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Gym
{
    class Connection
    {
        public static string StringConnection = @"Data Source=DESKTOP-DCI7V8V\SQLEXPRESS;Initial Catalog = gymmanagement; Integrated Security = True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(StringConnection);
        }
    }
}
