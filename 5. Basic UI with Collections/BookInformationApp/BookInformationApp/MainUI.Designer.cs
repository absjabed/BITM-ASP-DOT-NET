namespace BookInformationApp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ISBNaddTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.addBookDetailsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.findButton = new System.Windows.Forms.Button();
            this.searchBookTextBox = new System.Windows.Forms.TextBox();
            this.searchISBNTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addBookDetailsTextBox);
            this.groupBox1.Controls.Add(this.ISBNaddTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add book info";
            // 
            // ISBNaddTextBox
            // 
            this.ISBNaddTextBox.Location = new System.Drawing.Point(83, 33);
            this.ISBNaddTextBox.Name = "ISBNaddTextBox";
            this.ISBNaddTextBox.Size = new System.Drawing.Size(182, 23);
            this.ISBNaddTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(271, 83);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addBookDetailsTextBox
            // 
            this.addBookDetailsTextBox.Location = new System.Drawing.Point(83, 62);
            this.addBookDetailsTextBox.Multiline = true;
            this.addBookDetailsTextBox.Name = "addBookDetailsTextBox";
            this.addBookDetailsTextBox.Size = new System.Drawing.Size(182, 44);
            this.addBookDetailsTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.findButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.searchBookTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.searchISBNTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 130);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search book";
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(271, 83);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // searchBookTextBox
            // 
            this.searchBookTextBox.Location = new System.Drawing.Point(83, 62);
            this.searchBookTextBox.Multiline = true;
            this.searchBookTextBox.Name = "searchBookTextBox";
            this.searchBookTextBox.Size = new System.Drawing.Size(182, 44);
            this.searchBookTextBox.TabIndex = 0;
            // 
            // searchISBNTextBox
            // 
            this.searchISBNTextBox.Location = new System.Drawing.Point(83, 33);
            this.searchISBNTextBox.Name = "searchISBNTextBox";
            this.searchISBNTextBox.Size = new System.Drawing.Size(182, 23);
            this.searchISBNTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Details";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainUI";
            this.Text = "Book Information App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addBookDetailsTextBox;
        private System.Windows.Forms.TextBox ISBNaddTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox searchBookTextBox;
        private System.Windows.Forms.TextBox searchISBNTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

