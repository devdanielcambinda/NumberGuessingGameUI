namespace WindowsFormsApp1
{
    partial class SettingButtonMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DifficultyChoice = new System.Windows.Forms.GroupBox();
            this.LowDifficultyButton = new System.Windows.Forms.RadioButton();
            this.MediumDifficultyButton = new System.Windows.Forms.RadioButton();
            this.HardDifficultyButton = new System.Windows.Forms.RadioButton();
            this.labelSettingMenu = new System.Windows.Forms.Label();
            this.DifficultyChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // DifficultyChoice
            // 
            this.DifficultyChoice.Controls.Add(this.HardDifficultyButton);
            this.DifficultyChoice.Controls.Add(this.MediumDifficultyButton);
            this.DifficultyChoice.Controls.Add(this.LowDifficultyButton);
            this.DifficultyChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyChoice.Location = new System.Drawing.Point(92, 160);
            this.DifficultyChoice.Name = "DifficultyChoice";
            this.DifficultyChoice.Size = new System.Drawing.Size(323, 229);
            this.DifficultyChoice.TabIndex = 0;
            this.DifficultyChoice.TabStop = false;
            this.DifficultyChoice.Text = "Each difficulty do you want ? ";
            // 
            // LowDifficultyButton
            // 
            this.LowDifficultyButton.AutoSize = true;
            this.LowDifficultyButton.Location = new System.Drawing.Point(24, 52);
            this.LowDifficultyButton.Name = "LowDifficultyButton";
            this.LowDifficultyButton.Size = new System.Drawing.Size(69, 29);
            this.LowDifficultyButton.TabIndex = 0;
            this.LowDifficultyButton.TabStop = true;
            this.LowDifficultyButton.Text = "Low";
            this.LowDifficultyButton.UseVisualStyleBackColor = true;
            // 
            // MediumDifficultyButton
            // 
            this.MediumDifficultyButton.AutoSize = true;
            this.MediumDifficultyButton.Location = new System.Drawing.Point(24, 114);
            this.MediumDifficultyButton.Name = "MediumDifficultyButton";
            this.MediumDifficultyButton.Size = new System.Drawing.Size(103, 29);
            this.MediumDifficultyButton.TabIndex = 1;
            this.MediumDifficultyButton.TabStop = true;
            this.MediumDifficultyButton.Text = "Medium";
            this.MediumDifficultyButton.UseVisualStyleBackColor = true;
            // 
            // HardDifficultyButton
            // 
            this.HardDifficultyButton.AutoSize = true;
            this.HardDifficultyButton.Location = new System.Drawing.Point(24, 170);
            this.HardDifficultyButton.Name = "HardDifficultyButton";
            this.HardDifficultyButton.Size = new System.Drawing.Size(75, 29);
            this.HardDifficultyButton.TabIndex = 2;
            this.HardDifficultyButton.TabStop = true;
            this.HardDifficultyButton.Text = "Hard";
            this.HardDifficultyButton.UseVisualStyleBackColor = true;
            // 
            // labelSettingMenu
            // 
            this.labelSettingMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSettingMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettingMenu.Location = new System.Drawing.Point(80, 39);
            this.labelSettingMenu.Name = "labelSettingMenu";
            this.labelSettingMenu.Size = new System.Drawing.Size(426, 78);
            this.labelSettingMenu.TabIndex = 4;
            this.labelSettingMenu.Text = "Settings Menu";
            // 
            // SettingButtonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSettingMenu);
            this.Controls.Add(this.DifficultyChoice);
            this.Name = "SettingButtonMenu";
            this.Size = new System.Drawing.Size(1200, 690);
            this.DifficultyChoice.ResumeLayout(false);
            this.DifficultyChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox DifficultyChoice;
        private System.Windows.Forms.RadioButton HardDifficultyButton;
        private System.Windows.Forms.RadioButton MediumDifficultyButton;
        private System.Windows.Forms.RadioButton LowDifficultyButton;
        private System.Windows.Forms.Label labelSettingMenu;
    }
}
