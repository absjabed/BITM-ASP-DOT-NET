namespace SuperShopDesktopApp
{
    partial class MainUI
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
            this.shopInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shopNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.shopAddressTextBox = new System.Windows.Forms.TextBox();
            this.productInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.shopInfoGroupBox.SuspendLayout();
            this.productInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // shopInfoGroupBox
            // 
            this.shopInfoGroupBox.Controls.Add(this.saveButton);
            this.shopInfoGroupBox.Controls.Add(this.shopAddressTextBox);
            this.shopInfoGroupBox.Controls.Add(this.label3);
            this.shopInfoGroupBox.Controls.Add(this.shopNameTextBox);
            this.shopInfoGroupBox.Controls.Add(this.label1);
            this.shopInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.shopInfoGroupBox.Name = "shopInfoGroupBox";
            this.shopInfoGroupBox.Size = new System.Drawing.Size(407, 145);
            this.shopInfoGroupBox.TabIndex = 0;
            this.shopInfoGroupBox.TabStop = false;
            this.shopInfoGroupBox.Text = "Shop Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // shopNameTextBox
            // 
            this.shopNameTextBox.Location = new System.Drawing.Point(142, 41);
            this.shopNameTextBox.Name = "shopNameTextBox";
            this.shopNameTextBox.Size = new System.Drawing.Size(201, 23);
            this.shopNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(268, 99);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // shopAddressTextBox
            // 
            this.shopAddressTextBox.Location = new System.Drawing.Point(142, 70);
            this.shopAddressTextBox.Name = "shopAddressTextBox";
            this.shopAddressTextBox.Size = new System.Drawing.Size(201, 23);
            this.shopAddressTextBox.TabIndex = 1;
            // 
            // productInfoGroupBox
            // 
            this.productInfoGroupBox.Controls.Add(this.addItemButton);
            this.productInfoGroupBox.Controls.Add(this.productQuantityTextBox);
            this.productInfoGroupBox.Controls.Add(this.label2);
            this.productInfoGroupBox.Controls.Add(this.productIdTextBox);
            this.productInfoGroupBox.Controls.Add(this.label4);
            this.productInfoGroupBox.Location = new System.Drawing.Point(12, 163);
            this.productInfoGroupBox.Name = "productInfoGroupBox";
            this.productInfoGroupBox.Size = new System.Drawing.Size(407, 145);
            this.productInfoGroupBox.TabIndex = 3;
            this.productInfoGroupBox.TabStop = false;
            this.productInfoGroupBox.Text = "Product Information";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(268, 99);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(142, 70);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(201, 23);
            this.productQuantityTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(142, 41);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(201, 23);
            this.productIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product/Item Id";
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(101, 318);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(236, 23);
            this.showDetailsButton.TabIndex = 2;
            this.showDetailsButton.Text = "Add Show DetailsItem";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 353);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.productInfoGroupBox);
            this.Controls.Add(this.shopInfoGroupBox);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainUI";
            this.Text = "Main UI";
            this.shopInfoGroupBox.ResumeLayout(false);
            this.shopInfoGroupBox.PerformLayout();
            this.productInfoGroupBox.ResumeLayout(false);
            this.productInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox shopInfoGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox shopAddressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shopNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox productInfoGroupBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showDetailsButton;
    }
}

