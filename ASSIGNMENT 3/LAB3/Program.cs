
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LAB3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string ConString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(ConString);
            string querystring = "Select * from Student";
            con.Open();
            SqlCommand cmd = new SqlCommand(querystring, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString());
            }
            Application.Run(new Login());
        }
    }
}
    