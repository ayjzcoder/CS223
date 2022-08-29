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
    public partial class View_Products : Form
    {
        public View_Products()
        {
            InitializeComponent();
            Database.Load();
            bunifuDataGridView2.DataSource = null;
            bunifuDataGridView2.DataSource = Item.getAllItems();

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void View_Products_Load(object sender, EventArgs e)
        {  /*
            foreach (var item in Item.getAllItems())
            {
                ProductCard productcard =    new ProductCard();
                productcard.ItemName = item.item_name;
                productcard.Quantity = item.quantity;
                productcard.Price = item.price.ToString();

                productcard.Click += (object s, EventArgs ex)=>{
                    MessageBox.Show($"Product name: {item.item_name}\nQuantity: {item.quantity}");

                }
;
                flowLayoutPanel1.Controls.Add( productcard);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
