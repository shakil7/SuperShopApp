namespace SuperShopApp
{
    partial class ShopAppUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shopAddressTextBox = new System.Windows.Forms.TextBox();
            this.shopNameTextBox = new System.Windows.Forms.TextBox();
            this.saveShopButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qtyTextBox = new System.Windows.Forms.TextBox();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.shopAddressTextBox);
            this.groupBox1.Controls.Add(this.shopNameTextBox);
            this.groupBox1.Controls.Add(this.saveShopButton);
            this.groupBox1.Location = new System.Drawing.Point(22, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // shopAddressTextBox
            // 
            this.shopAddressTextBox.Location = new System.Drawing.Point(177, 71);
            this.shopAddressTextBox.Name = "shopAddressTextBox";
            this.shopAddressTextBox.Size = new System.Drawing.Size(172, 20);
            this.shopAddressTextBox.TabIndex = 1;
            // 
            // shopNameTextBox
            // 
            this.shopNameTextBox.Location = new System.Drawing.Point(177, 36);
            this.shopNameTextBox.Name = "shopNameTextBox";
            this.shopNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.shopNameTextBox.TabIndex = 0;
            // 
            // saveShopButton
            // 
            this.saveShopButton.Location = new System.Drawing.Point(274, 97);
            this.saveShopButton.Name = "saveShopButton";
            this.saveShopButton.Size = new System.Drawing.Size(75, 23);
            this.saveShopButton.TabIndex = 2;
            this.saveShopButton.Text = "Save";
            this.saveShopButton.UseVisualStyleBackColor = true;
            this.saveShopButton.Click += new System.EventHandler(this.saveShopButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.qtyTextBox);
            this.groupBox2.Controls.Add(this.itemIdTextBox);
            this.groupBox2.Controls.Add(this.addItemButton);
            this.groupBox2.Location = new System.Drawing.Point(21, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 149);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Item ID";
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new System.Drawing.Point(178, 62);
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new System.Drawing.Size(172, 20);
            this.qtyTextBox.TabIndex = 1;
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(178, 19);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(172, 20);
            this.itemIdTextBox.TabIndex = 0;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(275, 108);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // ShopAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShopAppUI";
            this.Text = "Super Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shopAddressTextBox;
        private System.Windows.Forms.TextBox shopNameTextBox;
        private System.Windows.Forms.Button saveShopButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qtyTextBox;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.Button addItemButton;
    }
}

