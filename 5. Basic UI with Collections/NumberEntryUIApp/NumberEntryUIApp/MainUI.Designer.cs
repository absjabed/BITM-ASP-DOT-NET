namespace NumberEntryUIApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.addNumberButton = new System.Windows.Forms.Button();
            this.showAllNumberButton = new System.Windows.Forms.Button();
            this.sumResultTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(118, 26);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(200, 23);
            this.numberTextBox.TabIndex = 1;
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.ItemHeight = 15;
            this.numberListBox.Location = new System.Drawing.Point(118, 117);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(200, 169);
            this.numberListBox.TabIndex = 2;
            // 
            // addNumberButton
            // 
            this.addNumberButton.Location = new System.Drawing.Point(243, 55);
            this.addNumberButton.Name = "addNumberButton";
            this.addNumberButton.Size = new System.Drawing.Size(75, 23);
            this.addNumberButton.TabIndex = 3;
            this.addNumberButton.Text = "Add";
            this.addNumberButton.UseVisualStyleBackColor = true;
            this.addNumberButton.Click += new System.EventHandler(this.addNumberButton_Click);
            // 
            // showAllNumberButton
            // 
            this.showAllNumberButton.Location = new System.Drawing.Point(174, 88);
            this.showAllNumberButton.Name = "showAllNumberButton";
            this.showAllNumberButton.Size = new System.Drawing.Size(144, 23);
            this.showAllNumberButton.TabIndex = 3;
            this.showAllNumberButton.Text = "Show All Number";
            this.showAllNumberButton.UseVisualStyleBackColor = true;
            this.showAllNumberButton.Click += new System.EventHandler(this.showAllNumberButton_Click);
            // 
            // sumResultTextBox
            // 
            this.sumResultTextBox.Location = new System.Drawing.Point(225, 296);
            this.sumResultTextBox.Name = "sumResultTextBox";
            this.sumResultTextBox.Size = new System.Drawing.Size(93, 23);
            this.sumResultTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sum Result:";
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 331);
            this.Controls.Add(this.showAllNumberButton);
            this.Controls.Add(this.addNumberButton);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.sumResultTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainUI";
            this.Text = "Number Entry UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.Button addNumberButton;
        private System.Windows.Forms.Button showAllNumberButton;
        private System.Windows.Forms.TextBox sumResultTextBox;
        private System.Windows.Forms.Label label2;
    }
}

