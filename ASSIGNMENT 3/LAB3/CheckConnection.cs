using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LAB3
{
    public partial class CheckConnection : Form
    {
        public CheckConnection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string ConString = @"Data Source=DESKTOP-TQN91H6\SQLEXPRESS;Initial Catalog= LABDATA ;Integrated Security=True";

                SqlConnection con = new SqlConnection(ConString);
                con.Open();
                MessageBox.Show("Connection Successful");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
        }
    }
}
