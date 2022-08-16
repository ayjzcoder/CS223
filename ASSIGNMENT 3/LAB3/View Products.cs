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
    public partial class View_Products : Form
    {
        public View_Products()
        {
            InitializeComponent();

            bunifuDataGridView1.DataSource = null;
            bunifuDataGridView1.DataSource = Item.getAllItems();

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void View_Products_Load(object sender, EventArgs e)
        {
            foreach (var item in Item.getAllItems())
            {
                UserControl1 userControl1 =    new UserControl1();
                userControl1.ItemName = item.item_name;
                userControl1.Quantity = item.quantity;
                userControl1.Price = item.price.ToString();
;
                flowLayoutPanel1.Controls.Add( userControl1);
            }
        }
    }
}
