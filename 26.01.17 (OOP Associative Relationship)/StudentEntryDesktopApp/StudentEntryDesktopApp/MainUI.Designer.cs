namespace StudentEntryDesktopApp
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
            this.departmentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.studentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.departmentCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentInfoSaveButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentRegNoTextBox = new System.Windows.Forms.TextBox();
            this.studentEmailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentInfoSaveButton = new System.Windows.Forms.Button();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.departmentInfoGroupBox.SuspendLayout();
            this.studentInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentInfoGroupBox
            // 
            this.departmentInfoGroupBox.Controls.Add(this.departmentInfoSaveButton);
            this.departmentInfoGroupBox.Controls.Add(this.label2);
            this.departmentInfoGroupBox.Controls.Add(this.label1);
            this.departmentInfoGroupBox.Controls.Add(this.departmentNameTextBox);
            this.departmentInfoGroupBox.Controls.Add(this.departmentCodeTextBox);
            this.departmentInfoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.departmentInfoGroupBox.Name = "departmentInfoGroupBox";
            this.departmentInfoGroupBox.Size = new System.Drawing.Size(414, 127);
            this.departmentInfoGroupBox.TabIndex = 0;
            this.departmentInfoGroupBox.TabStop = false;
            this.departmentInfoGroupBox.Text = "Department Info";
            // 
            // studentInfoGroupBox
            // 
            this.studentInfoGroupBox.Controls.Add(this.studentInfoSaveButton);
            this.studentInfoGroupBox.Controls.Add(this.label5);
            this.studentInfoGroupBox.Controls.Add(this.label3);
            this.studentInfoGroupBox.Controls.Add(this.label4);
            this.studentInfoGroupBox.Controls.Add(this.studentEmailTextBox);
            this.studentInfoGroupBox.Controls.Add(this.studentNameTextBox);
            this.studentInfoGroupBox.Controls.Add(this.studentRegNoTextBox);
            this.studentInfoGroupBox.Location = new System.Drawing.Point(12, 164);
            this.studentInfoGroupBox.Name = "studentInfoGroupBox";
            this.studentInfoGroupBox.Size = new System.Drawing.Size(414, 175);
            this.studentInfoGroupBox.TabIndex = 1;
            this.studentInfoGroupBox.TabStop = false;
            this.studentInfoGroupBox.Text = "Student Info";
            // 
            // departmentCodeTextBox
            // 
            this.departmentCodeTextBox.Location = new System.Drawing.Point(107, 25);
            this.departmentCodeTextBox.Name = "departmentCodeTextBox";
            this.departmentCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.departmentCodeTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // departmentInfoSaveButton
            // 
            this.departmentInfoSaveButton.Location = new System.Drawing.Point(308, 93);
            this.departmentInfoSaveButton.Name = "departmentInfoSaveButton";
            this.departmentInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.departmentInfoSaveButton.TabIndex = 2;
            this.departmentInfoSaveButton.Text = "Save";
            this.departmentInfoSaveButton.UseVisualStyleBackColor = true;
            this.departmentInfoSaveButton.Click += new System.EventHandler(this.departmentInfoSaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(107, 64);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(276, 23);
            this.departmentNameTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Reg No";
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(125, 70);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(258, 23);
            this.studentNameTextBox.TabIndex = 2;
            // 
            // studentRegNoTextBox
            // 
            this.studentRegNoTextBox.Location = new System.Drawing.Point(125, 31);
            this.studentRegNoTextBox.Name = "studentRegNoTextBox";
            this.studentRegNoTextBox.Size = new System.Drawing.Size(159, 23);
            this.studentRegNoTextBox.TabIndex = 3;
            // 
            // studentEmailTextBox
            // 
            this.studentEmailTextBox.Location = new System.Drawing.Point(125, 110);
            this.studentEmailTextBox.Name = "studentEmailTextBox";
            this.studentEmailTextBox.Size = new System.Drawing.Size(258, 23);
            this.studentEmailTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // studentInfoSaveButton
            // 
            this.studentInfoSaveButton.Location = new System.Drawing.Point(308, 139);
            this.studentInfoSaveButton.Name = "studentInfoSaveButton";
            this.studentInfoSaveButton.Size = new System.Drawing.Size(75, 23);
            this.studentInfoSaveButton.TabIndex = 2;
            this.studentInfoSaveButton.Text = "Save";
            this.studentInfoSaveButton.UseVisualStyleBackColor = true;
            this.studentInfoSaveButton.Click += new System.EventHandler(this.studentInfoSaveButton_Click);
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(157, 354);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(114, 23);
            this.showDetailsButton.TabIndex = 2;
            this.showDetailsButton.Text = "Show Details";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 389);
            this.Controls.Add(this.showDetailsButton);
            this.Controls.Add(this.studentInfoGroupBox);
            this.Controls.Add(this.departmentInfoGroupBox);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainUI";
            this.Text = "Main UI";
            this.departmentInfoGroupBox.ResumeLayout(false);
            this.departmentInfoGroupBox.PerformLayout();
            this.studentInfoGroupBox.ResumeLayout(false);
            this.studentInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox departmentInfoGroupBox;
        private System.Windows.Forms.Button departmentInfoSaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.TextBox departmentCodeTextBox;
        private System.Windows.Forms.GroupBox studentInfoGroupBox;
        private System.Windows.Forms.Button studentInfoSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentEmailTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentRegNoTextBox;
        private System.Windows.Forms.Button showDetailsButton;
    }
}

