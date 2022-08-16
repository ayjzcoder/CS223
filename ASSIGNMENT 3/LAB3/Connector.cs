using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LAB3
{
    internal class Connector
    {
       
        public static SqlConnection ConnectDb() {
            string ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            return con;
        }
    }
}
