using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            if(username.Equals("admin") && password.Equals("admin"))
            {
                // new Form1(username).Show();
                
                

               
                

                this.Hide();
                ContainerPage containerPage = new ContainerPage();
                containerPage.Closed += (s, args) => this.Close();
                containerPage.Show();


            }
            else
            {
                MessageBox.Show("Error");
            }
        }
                

    }
}
