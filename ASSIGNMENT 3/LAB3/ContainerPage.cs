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
    public partial class ContainerPage : Form
    {
        public ContainerPage()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            AddProduct form1 = new AddProduct("username");
            form1.MdiParent = this;
            form1.Show();
            form1.Dock = DockStyle.Fill;
           
            
        }

        private void ContainerPage_Load(object sender, EventArgs e)
        {
            

        }

        private void viewAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            View_Products view_Products = new View_Products();
            view_Products.MdiParent = this;
            view_Products.Show();   
            view_Products.Dock = DockStyle.Fill;
        }

        private void searchProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            SearchProduct searchproducts = new SearchProduct();
            searchproducts.MdiParent = this;
            searchproducts.Show();

        }
    }
}
