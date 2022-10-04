namespace TicketPurchaseApp
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
            this.PurchaseTicketGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detailsButton = new System.Windows.Forms.Button();
            this.PurchaseTicketGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PurchaseTicketGroupBox
            // 
            this.PurchaseTicketGroupBox.Controls.Add(this.detailsButton);
            this.PurchaseTicketGroupBox.Controls.Add(this.totalPriceButton);
            this.PurchaseTicketGroupBox.Controls.Add(this.numberOfTicketsTextBox);
            this.PurchaseTicketGroupBox.Controls.Add(this.customerNameTextBox);
            this.PurchaseTicketGroupBox.Controls.Add(this.label2);
            this.PurchaseTicketGroupBox.Controls.Add(this.label3);
            this.PurchaseTicketGroupBox.Controls.Add(this.label1);
            this.PurchaseTicketGroupBox.Location = new System.Drawing.Point(12, 12);
            this.PurchaseTicketGroupBox.Name = "PurchaseTicketGroupBox";
            this.PurchaseTicketGroupBox.Size = new System.Drawing.Size(591, 232);
            this.PurchaseTicketGroupBox.TabIndex = 0;
            this.PurchaseTicketGroupBox.TabStop = false;
            this.PurchaseTicketGroupBox.Text = "Purchase your ticket(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(229, 55);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(236, 25);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // totalPriceButton
            // 
            this.totalPriceButton.Location = new System.Drawing.Point(229, 175);
            this.totalPriceButton.Name = "totalPriceButton";
            this.totalPriceButton.Size = new System.Drawing.Size(110, 27);
            this.totalPriceButton.TabIndex = 2;
            this.totalPriceButton.Text = "Total Price";
            this.totalPriceButton.UseVisualStyleBackColor = true;
            this.totalPriceButton.Click += new System.EventHandler(this.totalPriceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of ticket(s)";
            // 
            // numberOfTicketsTextBox
            // 
            this.numberOfTicketsTextBox.Location = new System.Drawing.Point(229, 112);
            this.numberOfTicketsTextBox.Name = "numberOfTicketsTextBox";
            this.numberOfTicketsTextBox.Size = new System.Drawing.Size(236, 25);
            this.numberOfTicketsTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(345, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "10TK per ticket";
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(355, 175);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(110, 27);
            this.detailsButton.TabIndex = 2;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 252);
            this.Controls.Add(this.PurchaseTicketGroupBox);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.PurchaseTicketGroupBox.ResumeLayout(false);
            this.PurchaseTicketGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PurchaseTicketGroupBox;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Button totalPriceButton;
        private System.Windows.Forms.TextBox numberOfTicketsTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

