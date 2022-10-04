namespace PersonalInformationApp
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
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fathersNameTextBox = new System.Windows.Forms.TextBox();
            this.mothersNameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showInformationButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.parentsNameButton = new System.Windows.Forms.Button();
            this.addressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(148, 87);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(266, 27);
            this.firstNameTextBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(105, 391);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 27);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(148, 133);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(266, 27);
            this.lastNameTextBox.TabIndex = 1;
            // 
            // fathersNameTextBox
            // 
            this.fathersNameTextBox.Location = new System.Drawing.Point(148, 179);
            this.fathersNameTextBox.Name = "fathersNameTextBox";
            this.fathersNameTextBox.Size = new System.Drawing.Size(266, 27);
            this.fathersNameTextBox.TabIndex = 2;
            // 
            // mothersNameTextBox
            // 
            this.mothersNameTextBox.Location = new System.Drawing.Point(148, 225);
            this.mothersNameTextBox.Name = "mothersNameTextBox";
            this.mothersNameTextBox.Size = new System.Drawing.Size(266, 27);
            this.mothersNameTextBox.TabIndex = 3;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(148, 271);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(266, 89);
            this.addressTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Father\'s Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mother\'s Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Address:";
            // 
            // showInformationButton
            // 
            this.showInformationButton.Location = new System.Drawing.Point(242, 391);
            this.showInformationButton.Name = "showInformationButton";
            this.showInformationButton.Size = new System.Drawing.Size(172, 27);
            this.showInformationButton.TabIndex = 6;
            this.showInformationButton.Text = "Show All Information";
            this.showInformationButton.UseVisualStyleBackColor = true;
            this.showInformationButton.Click += new System.EventHandler(this.showInformationButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(105, 435);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 27);
            this.nameButton.TabIndex = 7;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // parentsNameButton
            // 
            this.parentsNameButton.Location = new System.Drawing.Point(198, 435);
            this.parentsNameButton.Name = "parentsNameButton";
            this.parentsNameButton.Size = new System.Drawing.Size(119, 27);
            this.parentsNameButton.TabIndex = 8;
            this.parentsNameButton.Text = "Parent\'s Name";
            this.parentsNameButton.UseVisualStyleBackColor = true;
            this.parentsNameButton.Click += new System.EventHandler(this.parentsNameButton_Click);
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(339, 435);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(75, 27);
            this.addressButton.TabIndex = 9;
            this.addressButton.Text = "Address";
            this.addressButton.UseVisualStyleBackColor = true;
            this.addressButton.Click += new System.EventHandler(this.addressButton_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 499);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.parentsNameButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.showInformationButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.mothersNameTextBox);
            this.Controls.Add(this.fathersNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainUI";
            this.Text = "MainUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fathersNameTextBox;
        private System.Windows.Forms.TextBox mothersNameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showInformationButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button parentsNameButton;
        private System.Windows.Forms.Button addressButton;
    }
}

