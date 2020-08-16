namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonQuit.BackgroundImage")));
            this.buttonQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuit.Location = new System.Drawing.Point(1217, 12);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(51, 53);
            this.buttonQuit.TabIndex = 0;
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSettings.BackgroundImage")));
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Location = new System.Drawing.Point(1160, 12);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(51, 53);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonSettings;
    }
}

