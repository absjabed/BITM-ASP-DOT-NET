namespace StudentsYearlyCostApp
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
            this.yearlyCostCalculatorGroupBox = new System.Windows.Forms.GroupBox();
            this.calculateTotalAmountButton = new System.Windows.Forms.Button();
            this.getDiscountCheckBox = new System.Windows.Forms.CheckBox();
            this.selectClassLabel = new System.Windows.Forms.Label();
            this.classListComboBox = new System.Windows.Forms.ComboBox();
            this.yearlyCostCalculatorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearlyCostCalculatorGroupBox
            // 
            this.yearlyCostCalculatorGroupBox.Controls.Add(this.classListComboBox);
            this.yearlyCostCalculatorGroupBox.Controls.Add(this.calculateTotalAmountButton);
            this.yearlyCostCalculatorGroupBox.Controls.Add(this.getDiscountCheckBox);
            this.yearlyCostCalculatorGroupBox.Controls.Add(this.selectClassLabel);
            this.yearlyCostCalculatorGroupBox.Location = new System.Drawing.Point(12, 12);
            this.yearlyCostCalculatorGroupBox.Name = "yearlyCostCalculatorGroupBox";
            this.yearlyCostCalculatorGroupBox.Size = new System.Drawing.Size(480, 252);
            this.yearlyCostCalculatorGroupBox.TabIndex = 0;
            this.yearlyCostCalculatorGroupBox.TabStop = false;
            this.yearlyCostCalculatorGroupBox.Text = "Calculator for yearly cost of a student";
            // 
            // calculateTotalAmountButton
            // 
            this.calculateTotalAmountButton.Location = new System.Drawing.Point(109, 169);
            this.calculateTotalAmountButton.Name = "calculateTotalAmountButton";
            this.calculateTotalAmountButton.Size = new System.Drawing.Size(263, 48);
            this.calculateTotalAmountButton.TabIndex = 3;
            this.calculateTotalAmountButton.Text = "Calculate total amount for one year";
            this.calculateTotalAmountButton.UseVisualStyleBackColor = true;
            this.calculateTotalAmountButton.Click += new System.EventHandler(this.calculateTotalAmountButton_Click);
            // 
            // getDiscountCheckBox
            // 
            this.getDiscountCheckBox.AutoSize = true;
            this.getDiscountCheckBox.Location = new System.Drawing.Point(109, 114);
            this.getDiscountCheckBox.Name = "getDiscountCheckBox";
            this.getDiscountCheckBox.Size = new System.Drawing.Size(271, 19);
            this.getDiscountCheckBox.TabIndex = 2;
            this.getDiscountCheckBox.Text = "Get 5% discount for early admission";
            this.getDiscountCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.AutoSize = true;
            this.selectClassLabel.Location = new System.Drawing.Point(73, 58);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(105, 15);
            this.selectClassLabel.TabIndex = 1;
            this.selectClassLabel.Text = "Select Class :";
            // 
            // classListComboBox
            // 
            this.classListComboBox.FormattingEnabled = true;
            this.classListComboBox.Location = new System.Drawing.Point(180, 55);
            this.classListComboBox.Name = "classListComboBox";
            this.classListComboBox.Size = new System.Drawing.Size(192, 23);
            this.classListComboBox.TabIndex = 4;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 276);
            this.Controls.Add(this.yearlyCostCalculatorGroupBox);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainUI";
            this.Text = "Yearly Cost Calculator";
            this.yearlyCostCalculatorGroupBox.ResumeLayout(false);
            this.yearlyCostCalculatorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox yearlyCostCalculatorGroupBox;
        private System.Windows.Forms.Button calculateTotalAmountButton;
        private System.Windows.Forms.CheckBox getDiscountCheckBox;
        private System.Windows.Forms.Label selectClassLabel;
        private System.Windows.Forms.ComboBox classListComboBox;
    }
}

