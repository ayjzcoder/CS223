namespace LAB3
{
    partial class ContainerPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.careToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.careToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.editProductToolStripMenuItem,
            this.searchProductToolStripMenuItem,
            this.viewAllProductsToolStripMenuItem});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewProductToolStripMenuItem.Text = "Add New Product";
            this.addNewProductToolStripMenuItem.Click += new System.EventHandler(this.addNewProductToolStripMenuItem_Click);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editProductToolStripMenuItem.Text = "Edit Product";
            // 
            // searchProductToolStripMenuItem
            // 
            this.searchProductToolStripMenuItem.Name = "searchProductToolStripMenuItem";
            this.searchProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.searchProductToolStripMenuItem.Text = "Search Product";
            this.searchProductToolStripMenuItem.Click += new System.EventHandler(this.searchProductToolStripMenuItem_Click);
            // 
            // viewAllProductsToolStripMenuItem
            // 
            this.viewAllProductsToolStripMenuItem.Name = "viewAllProductsToolStripMenuItem";
            this.viewAllProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewAllProductsToolStripMenuItem.Text = "View All Products";
            this.viewAllProductsToolStripMenuItem.Click += new System.EventHandler(this.viewAllProductsToolStripMenuItem_Click);
            // 
            // careToolStripMenuItem
            // 
            this.careToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCategoryToolStripMenuItem,
            this.editCategoryToolStripMenuItem,
            this.deleteCategoryToolStripMenuItem});
            this.careToolStripMenuItem.Name = "careToolStripMenuItem";
            this.careToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.careToolStripMenuItem.Text = "Categories";
            // 
            // addNewCategoryToolStripMenuItem
            // 
            this.addNewCategoryToolStripMenuItem.Name = "addNewCategoryToolStripMenuItem";
            this.addNewCategoryToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.addNewCategoryToolStripMenuItem.Text = "Add New Category";
            // 
            // editCategoryToolStripMenuItem
            // 
            this.editCategoryToolStripMenuItem.Name = "editCategoryToolStripMenuItem";
            this.editCategoryToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editCategoryToolStripMenuItem.Text = "Edit Category";
            // 
            // deleteCategoryToolStripMenuItem
            // 
            this.deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            this.deleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteCategoryToolStripMenuItem.Text = "Delete Category";
            // 
            // ContainerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ContainerPage";
            this.Text = "ContainerPage";
            this.Load += new System.EventHandler(this.ContainerPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem careToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryToolStripMenuItem;
    }
}