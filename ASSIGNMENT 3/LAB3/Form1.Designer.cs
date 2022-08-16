namespace LAB3
{
    partial class AddProduct
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.grpbox_payment = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_ItemName = new System.Windows.Forms.TextBox();
            this.txt_SKU = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.grpbox_payment.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(61, 65);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(196, 20);
            this.txt_Number.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(157)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.grpbox_payment);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.date1);
            this.panel1.Controls.Add(this.btn_Cancel);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Qty);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.txt_ItemName);
            this.panel1.Controls.Add(this.txt_SKU);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_Number);
            this.panel1.Location = new System.Drawing.Point(-3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 452);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Username";
            // 
            // grpbox_payment
            // 
            this.grpbox_payment.Controls.Add(this.radioButton4);
            this.grpbox_payment.Controls.Add(this.radioButton3);
            this.grpbox_payment.Location = new System.Drawing.Point(327, 246);
            this.grpbox_payment.Name = "grpbox_payment";
            this.grpbox_payment.Size = new System.Drawing.Size(216, 54);
            this.grpbox_payment.TabIndex = 22;
            this.grpbox_payment.TabStop = false;
            this.grpbox_payment.Text = "Payment";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(115, 22);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Credit Card";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(101, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Pay-On Delivery";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(327, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 46);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 17);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Free Shipping";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(115, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quick Hour ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(327, 65);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(216, 20);
            this.date1.TabIndex = 15;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(396, 372);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.AutoSize = true;
            this.btn_add.Location = new System.Drawing.Point(217, 372);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SKU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(59, 208);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(198, 20);
            this.txt_Qty.TabIndex = 7;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(59, 278);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(198, 20);
            this.txt_price.TabIndex = 6;
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Location = new System.Drawing.Point(61, 136);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(196, 20);
            this.txt_ItemName.TabIndex = 5;
            // 
            // txt_SKU
            // 
            this.txt_SKU.Location = new System.Drawing.Point(327, 136);
            this.txt_SKU.Name = "txt_SKU";
            this.txt_SKU.Size = new System.Drawing.Size(216, 20);
            this.txt_SKU.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpbox_payment.ResumeLayout(false);
            this.grpbox_payment.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_ItemName;
        private System.Windows.Forms.TextBox txt_SKU;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grpbox_payment;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label7;
    }
}

