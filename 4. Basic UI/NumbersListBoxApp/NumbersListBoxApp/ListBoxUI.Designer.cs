namespace NumbersListBoxApp
{
    partial class ListBoxUI
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
            this.NumbersGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numbersButton = new System.Windows.Forms.Button();
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.NumbersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumbersGroupBox
            // 
            this.NumbersGroupBox.Controls.Add(this.numbersListBox);
            this.NumbersGroupBox.Controls.Add(this.numbersButton);
            this.NumbersGroupBox.Controls.Add(this.numberTextBox);
            this.NumbersGroupBox.Controls.Add(this.label1);
            this.NumbersGroupBox.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumbersGroupBox.Location = new System.Drawing.Point(12, 13);
            this.NumbersGroupBox.Name = "NumbersGroupBox";
            this.NumbersGroupBox.Size = new System.Drawing.Size(477, 377);
            this.NumbersGroupBox.TabIndex = 0;
            this.NumbersGroupBox.TabStop = false;
            this.NumbersGroupBox.Text = "Numbers List App";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.Location = new System.Drawing.Point(165, 53);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(236, 23);
            this.numberTextBox.TabIndex = 1;
            // 
            // numbersButton
            // 
            this.numbersButton.Location = new System.Drawing.Point(326, 103);
            this.numbersButton.Name = "numbersButton";
            this.numbersButton.Size = new System.Drawing.Size(75, 23);
            this.numbersButton.TabIndex = 2;
            this.numbersButton.Text = "Show All";
            this.numbersButton.UseVisualStyleBackColor = true;
            this.numbersButton.Click += new System.EventHandler(this.numbersButton_Click);
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.ItemHeight = 15;
            this.numbersListBox.Location = new System.Drawing.Point(77, 153);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(324, 199);
            this.numbersListBox.TabIndex = 3;
            // 
            // ListBoxUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 402);
            this.Controls.Add(this.NumbersGroupBox);
            this.Name = "ListBoxUI";
            this.Text = "List Box UI";
            this.NumbersGroupBox.ResumeLayout(false);
            this.NumbersGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NumbersGroupBox;
        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.Button numbersButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
    }
}

