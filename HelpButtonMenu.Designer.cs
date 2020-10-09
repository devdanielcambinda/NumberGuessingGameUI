namespace WindowsFormsApp1
{
    partial class HelpButtonMenu
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
            this.labelHelpTab = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHelpTab
            // 
            this.labelHelpTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHelpTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelpTab.Location = new System.Drawing.Point(113, 26);
            this.labelHelpTab.Name = "labelHelpTab";
            this.labelHelpTab.Size = new System.Drawing.Size(399, 78);
            this.labelHelpTab.TabIndex = 4;
            this.labelHelpTab.Text = "Help Tab";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(130, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(949, 480);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "- The default difficulty is medium.\r\n\r\n- The selected difficulty is used for both" +
    " games.\r\n\r\n- The \" back arrow \" returns to the main menu and not to the previous" +
    " page used.";
            // 
            // HelpButtonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelHelpTab);
            this.Name = "HelpButtonMenu";
            this.Size = new System.Drawing.Size(1200, 690);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHelpTab;
        private System.Windows.Forms.TextBox textBox1;
        
    }
}
