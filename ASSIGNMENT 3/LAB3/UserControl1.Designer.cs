namespace LAB3
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.lbl_name = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_price = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_quantity = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AllowParentOverrides = false;
            this.lbl_name.AutoEllipsis = false;
            this.lbl_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_name.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_name.Location = new System.Drawing.Point(60, 87);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_name.Size = new System.Drawing.Size(66, 28);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name: ";
            this.lbl_name.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_name.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_name.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // lbl_price
            // 
            this.lbl_price.AllowParentOverrides = false;
            this.lbl_price.AutoEllipsis = false;
            this.lbl_price.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_price.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_price.Location = new System.Drawing.Point(70, 132);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_price.Size = new System.Drawing.Size(56, 28);
            this.lbl_price.TabIndex = 2;
            this.lbl_price.Text = "Price: ";
            this.lbl_price.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_price.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lbl_price.Click += new System.EventHandler(this.lbl_price_Click);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AllowParentOverrides = false;
            this.lbl_quantity.AutoEllipsis = false;
            this.lbl_quantity.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_quantity.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_quantity.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_quantity.Location = new System.Drawing.Point(32, 178);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_quantity.Size = new System.Drawing.Size(94, 28);
            this.lbl_quantity.TabIndex = 3;
            this.lbl_quantity.Text = "Quantity: ";
            this.lbl_quantity.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_quantity.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_name);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(352, 264);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel lbl_name;
        private Bunifu.UI.WinForms.BunifuLabel lbl_price;
        private Bunifu.UI.WinForms.BunifuLabel lbl_quantity;
    }
}
