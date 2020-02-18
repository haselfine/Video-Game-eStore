using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //this is necessary for SQL connection

namespace uShop1
{
    class uStoreDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=LUNA-00\\SQLEXPRESS;Initial Catalog=Nintendo_eShop;Integrated Security=True"; //connection to database
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
