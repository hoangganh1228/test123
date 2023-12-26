using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Manager_Hotel.ClassLoin
{
    class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-84GR9J9\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
