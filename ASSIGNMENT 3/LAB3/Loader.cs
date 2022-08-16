using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LAB3
{
    internal class Loader
    {
        public static void Load(List<Item> items)
        {
            SqlConnection con = Connector.ConnectDb();
            con.Open();
            string querystring = "Select * from Item";
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               
            }
        }
    }
}
