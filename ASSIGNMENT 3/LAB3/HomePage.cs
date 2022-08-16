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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            Indicator.Location = new Point(3, 159);
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
            Indicator.Location = new Point(3, 203);
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {
            Indicator.Location = new Point(3, 246);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
