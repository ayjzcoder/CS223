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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private String name;

        public String ItemName 
        {
            get { return name; }
            set { name = value; lbl_name.Text += name; }
        }


        private String price;

        public String Price

        {
            get { return price; }
            set { price = value; lbl_price.Text += price; }
        }

        private  int quantity;

        public  int Quantity 
        {
            get { return quantity; }
            set { quantity = value; lbl_quantity.Text += quantity;  }
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_price_Click(object sender, EventArgs e)
        {

        }
    }
}
