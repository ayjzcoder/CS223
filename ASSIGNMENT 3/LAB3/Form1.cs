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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Good Morning {txt_Number.Text}");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.number = Convert.ToInt32(txt_Number.Text);
            item.date = date1.Text;
            item.SKU= Convert.ToInt32((txt_SKU).Text);
            item.item_name = txt_ItemName.Text;
            item.quantity= Convert.ToInt32(txt_Qty.Text);
            item.price = Convert.ToDouble(txt_price.Text);

            Table.Rows.Add(item.number, item.item_name, item.quantity, item.price,item.date,item.SKU);

            item.save();

            MessageBox.Show($"{item.item_name} Added Successfully");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
