﻿using System;
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
    public partial class SearchProduct : Form
    {
        public SearchProduct()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            String search;
            search = bunifuTextBox1.Text;

            searchtable.Columns.Add("n","");
            
            searchtable.DataSource = null;
            searchtable.DataSource = Item.search(search);



        }
    }
}
