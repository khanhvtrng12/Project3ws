using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAL
{
    internal class DBAccess
    {
        public static SqlConnection
               GetDBConnection(string datasource, string database, string username, string password)
        {
            //
            // Data Source=TEST\SQLEXPRESS;Initial Catalog=khanhcute;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
