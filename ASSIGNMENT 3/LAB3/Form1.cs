using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1(String user)
        {
          
            InitializeComponent();
            label7.Text = user;
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

           
                
            
            

            try
            {
                item.number = Convert.ToInt32(txt_Number.Text);
                errorProvider1.SetError(txt_Number, "");

            }
            catch (FormatException)
            {
                if (txt_Number.Text.Equals(""))
                    errorProvider1.SetError(txt_Number, "Number Required");
                else
                    errorProvider1.SetError(txt_Number, "Integers Only");

            }
            Regex r = new Regex(@"^[0-9]{3}$");
            try
            {

                item.SKU = Convert.ToInt32(txt_SKU.Text);

                ;            }
            catch (FormatException)
            {
              
                if (txt_SKU.Text.Equals(""))
                    errorProvider1.SetError(txt_SKU, "SKU Required");
                else 
                    errorProvider1.SetError(txt_SKU, "Integers Only");
            }

            try
            {
                item.quantity = Convert.ToInt32(txt_Qty.Text);
                errorProvider1.SetError(txt_Qty, "");
            }
            catch (Exception)
            {
                if (txt_Qty.Text.Equals(""))
                    errorProvider1.SetError(txt_Qty, "Quantity Required");
                else
                    errorProvider1.SetError(txt_Qty, "Integers Only");
            }

            try
            {
                item.price = Convert.ToInt32(txt_price.Text);
                errorProvider1.SetError(txt_price, "");
            }
            catch (Exception)
            {

                if (txt_price.Text.Equals(""))
                    errorProvider1.SetError(txt_price, "Price Required");
                else
                    errorProvider1.SetError(txt_price, "Integers Only");
            }

            item.date = date1.Text;
            item.item_name = txt_ItemName.Text;

            item.payment = grpbox_payment.Text;
            item.shipping = groupBox1.Text;





            //Validate Empty Fields
            if (txt_ItemName.Text.Equals(""))
            {
                errorProvider1.SetError(txt_ItemName, "Name Required");
            }
            else
                errorProvider1.SetError(txt_ItemName, "");


            if (!r.IsMatch(txt_SKU.Text))
             errorProvider1.SetError(txt_SKU, "Only Three Digits");
            else
                errorProvider1.SetError(txt_SKU, "");


            bool valid = false;

            List<TextBox> list = new List<TextBox>() {
                txt_Number,txt_ItemName,txt_price,txt_Qty,txt_SKU 
            };
           
        
            for (int i = 0; i < list.Count; i++)
            {
                if (!errorProvider1.GetError(list[i]).Equals(""))
                {
                    valid = false;
                    break;

                }
                else
                    valid = true;

            }

         
            if (valid)
            {

                item.save();

                Table.DataSource = null;
                Table.DataSource = Item.getAllItems();

                String message = "";
               
                MessageBox.Show(message);
                MessageBox.Show($"{item.item_name} Added Successfully");
            }
            //Table.Rows.Add(item.number, item.item_name, item.quantity, item.price,item.date,item.SKU);

            

            
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
