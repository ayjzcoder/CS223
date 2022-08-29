using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LAB3
{
    internal class Database : Item
    {
        public static void Load()
        {
            SqlConnection con = Connector.ConnectDb();
            con.Open();
            string querystring = "Select * from Item";
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Item item = new Item();
                item.Id = (int)reader["id"];
                item.item_name = (string)reader["name"];
                item.date = reader["dateAdded"].ToString();
                item.quantity = (int)reader["quantity"];
                item.price = Double.Parse(reader["price"].ToString());
                item.isAvailable = (bool)reader["available"];



                items.Add(item);

            }
        }

        public static int Add(Item item)
        {

            int available;
            if (item.isAvailable)
                available = 1;
            else available = 0;

            DateTime date = Convert.ToDateTime(item.date);


            SqlConnection con = new SqlConnection();
            con = Connector.ConnectDb();
            con.Open();
        
            SqlCommand sqlCommand = new SqlCommand("spInsertItem", con);
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@name",item.item_name);
            sqlCommand.Parameters.AddWithValue("@dateAdded", date);
            sqlCommand.Parameters.AddWithValue("@quantity", item.quantity);
            sqlCommand.Parameters.AddWithValue("@price", item.price);
            sqlCommand.Parameters.AddWithValue("@available", available);

            int added = sqlCommand.ExecuteNonQuery();
            con.Close();
            return added;
        }
    }
}
