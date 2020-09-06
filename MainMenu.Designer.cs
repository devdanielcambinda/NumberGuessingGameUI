namespace WindowsFormsApp1
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonUserGuess = new System.Windows.Forms.Button();
            this.buttonCpuGuess = new System.Windows.Forms.Button();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.labelUserGuess = new System.Windows.Forms.Label();
            this.labelComputerGuess = new System.Windows.Forms.Label();
            this.labelMatchHistory = new System.Windows.Forms.Label();
            this.buttonMatchHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonUserGuess
            // 
            this.buttonUserGuess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUserGuess.BackgroundImage")));
            this.buttonUserGuess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUserGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserGuess.Location = new System.Drawing.Point(75, 162);
            this.buttonUserGuess.Name = "buttonUserGuess";
            this.buttonUserGuess.Size = new System.Drawing.Size(297, 292);
            this.buttonUserGuess.TabIndex = 0;
            this.buttonUserGuess.UseVisualStyleBackColor = true;
            this.buttonUserGuess.Click += new System.EventHandler(this.buttonUserGuess_Click);
            // 
            // buttonCpuGuess
            // 
            this.buttonCpuGuess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCpuGuess.BackgroundImage")));
            this.buttonCpuGuess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCpuGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCpuGuess.Location = new System.Drawing.Point(462, 162);
            this.buttonCpuGuess.Name = "buttonCpuGuess";
            this.buttonCpuGuess.Size = new System.Drawing.Size(297, 292);
            this.buttonCpuGuess.TabIndex = 1;
            this.buttonCpuGuess.UseVisualStyleBackColor = true;
            this.buttonCpuGuess.Click += new System.EventHandler(this.buttonCpuGuess_Click);
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.Location = new System.Drawing.Point(63, 29);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(399, 78);
            this.labelMainMenu.TabIndex = 3;
            this.labelMainMenu.Text = "Main Menu";
            // 
            // labelUserGuess
            // 
            this.labelUserGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserGuess.Location = new System.Drawing.Point(144, 500);
            this.labelUserGuess.Name = "labelUserGuess";
            this.labelUserGuess.Size = new System.Drawing.Size(228, 52);
            this.labelUserGuess.TabIndex = 4;
            this.labelUserGuess.Text = "User Guess";
            // 
            // labelComputerGuess
            // 
            this.labelComputerGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerGuess.Location = new System.Drawing.Point(497, 500);
            this.labelComputerGuess.Name = "labelComputerGuess";
            this.labelComputerGuess.Size = new System.Drawing.Size(303, 52);
            this.labelComputerGuess.TabIndex = 5;
            this.labelComputerGuess.Text = "Computer Guess";
            // 
            // labelMatchHistory
            // 
            this.labelMatchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchHistory.Location = new System.Drawing.Point(900, 500);
            this.labelMatchHistory.Name = "labelMatchHistory";
            this.labelMatchHistory.Size = new System.Drawing.Size(256, 52);
            this.labelMatchHistory.TabIndex = 6;
            this.labelMatchHistory.Text = "Match History";
            // 
            // buttonMatchHistory
            // 
            this.buttonMatchHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMatchHistory.BackgroundImage")));
            this.buttonMatchHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMatchHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMatchHistory.Location = new System.Drawing.Point(842, 162);
            this.buttonMatchHistory.Name = "buttonMatchHistory";
            this.buttonMatchHistory.Size = new System.Drawing.Size(297, 292);
            this.buttonMatchHistory.TabIndex = 7;
            this.buttonMatchHistory.UseVisualStyleBackColor = true;
            this.buttonMatchHistory.Click += new System.EventHandler(this.buttonMatchHistory_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonMatchHistory);
            this.Controls.Add(this.labelMatchHistory);
            this.Controls.Add(this.labelComputerGuess);
            this.Controls.Add(this.labelUserGuess);
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.buttonCpuGuess);
            this.Controls.Add(this.buttonUserGuess);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(1200, 690);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserGuess;
        private System.Windows.Forms.Button buttonCpuGuess;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Label labelUserGuess;
        private System.Windows.Forms.Label labelComputerGuess;
        private System.Windows.Forms.Label labelMatchHistory;
        private System.Windows.Forms.Button buttonMatchHistory;
    }
}
