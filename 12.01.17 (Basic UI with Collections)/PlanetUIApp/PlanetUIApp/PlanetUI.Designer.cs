namespace PlanetUIApp
{
    partial class PlanetUI
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
            this.planetComboBox = new System.Windows.Forms.ComboBox();
            this.showPlanetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // planetComboBox
            // 
            this.planetComboBox.FormattingEnabled = true;
            this.planetComboBox.Items.AddRange(new object[] {
            "Planet",
            "Saturn",
            "Mars"});
            this.planetComboBox.Location = new System.Drawing.Point(202, 65);
            this.planetComboBox.Name = "planetComboBox";
            this.planetComboBox.Size = new System.Drawing.Size(159, 23);
            this.planetComboBox.TabIndex = 0;
            // 
            // showPlanetButton
            // 
            this.showPlanetButton.Location = new System.Drawing.Point(270, 106);
            this.showPlanetButton.Name = "showPlanetButton";
            this.showPlanetButton.Size = new System.Drawing.Size(91, 23);
            this.showPlanetButton.TabIndex = 1;
            this.showPlanetButton.Text = "Show Planet";
            this.showPlanetButton.UseVisualStyleBackColor = true;
            this.showPlanetButton.Click += new System.EventHandler(this.showPlanetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Planet Name:";
            // 
            // PlanetUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPlanetButton);
            this.Controls.Add(this.planetComboBox);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PlanetUI";
            this.Text = "PlanetUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox planetComboBox;
        private System.Windows.Forms.Button showPlanetButton;
        private System.Windows.Forms.Label label1;
    }
}