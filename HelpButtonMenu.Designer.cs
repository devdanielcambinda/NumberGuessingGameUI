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
            this.SuspendLayout();
            // 
            // labelHelpTab
            // 
            this.labelHelpTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHelpTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelpTab.Location = new System.Drawing.Point(54, 53);
            this.labelHelpTab.Name = "labelHelpTab";
            this.labelHelpTab.Size = new System.Drawing.Size(399, 78);
            this.labelHelpTab.TabIndex = 4;
            this.labelHelpTab.Text = "Help Tab";
            // 
            // HelpButtonMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelHelpTab);
            this.Name = "HelpButtonMenu";
            this.Size = new System.Drawing.Size(1200, 690);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHelpTab;
    }
}
