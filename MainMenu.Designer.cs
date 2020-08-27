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
            this.button3 = new System.Windows.Forms.Button();
            this.labelMainMenu = new System.Windows.Forms.Label();
            this.labelUserGuess = new System.Windows.Forms.Label();
            this.labelComputerGuess = new System.Windows.Forms.Label();
            this.labelMatchHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUserGuess
            // 
            this.buttonUserGuess.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUserGuess.BackgroundImage")));
            this.buttonUserGuess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUserGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserGuess.Location = new System.Drawing.Point(75, 185);
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
            this.buttonCpuGuess.Location = new System.Drawing.Point(462, 185);
            this.buttonCpuGuess.Name = "buttonCpuGuess";
            this.buttonCpuGuess.Size = new System.Drawing.Size(297, 292);
            this.buttonCpuGuess.TabIndex = 1;
            this.buttonCpuGuess.UseVisualStyleBackColor = true;
            this.buttonCpuGuess.Click += new System.EventHandler(this.buttonCpuGuess_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(844, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(297, 292);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelMainMenu
            // 
            this.labelMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainMenu.Location = new System.Drawing.Point(59, 19);
            this.labelMainMenu.Name = "labelMainMenu";
            this.labelMainMenu.Size = new System.Drawing.Size(482, 78);
            this.labelMainMenu.TabIndex = 3;
            this.labelMainMenu.Text = "Main Menu";
            // 
            // labelUserGuess
            // 
            this.labelUserGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserGuess.Location = new System.Drawing.Point(129, 500);
            this.labelUserGuess.Name = "labelUserGuess";
            this.labelUserGuess.Size = new System.Drawing.Size(182, 52);
            this.labelUserGuess.TabIndex = 4;
            this.labelUserGuess.Text = "User Guess";
            // 
            // labelComputerGuess
            // 
            this.labelComputerGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputerGuess.Location = new System.Drawing.Point(492, 500);
            this.labelComputerGuess.Name = "labelComputerGuess";
            this.labelComputerGuess.Size = new System.Drawing.Size(250, 52);
            this.labelComputerGuess.TabIndex = 5;
            this.labelComputerGuess.Text = "Computer Guess";
            // 
            // labelMatchHistory
            // 
            this.labelMatchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMatchHistory.Location = new System.Drawing.Point(892, 500);
            this.labelMatchHistory.Name = "labelMatchHistory";
            this.labelMatchHistory.Size = new System.Drawing.Size(202, 52);
            this.labelMatchHistory.TabIndex = 6;
            this.labelMatchHistory.Text = "Match History";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMatchHistory);
            this.Controls.Add(this.labelComputerGuess);
            this.Controls.Add(this.labelUserGuess);
            this.Controls.Add(this.labelMainMenu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonCpuGuess);
            this.Controls.Add(this.buttonUserGuess);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(1200, 690);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonUserGuess;
        private System.Windows.Forms.Button buttonCpuGuess;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelMainMenu;
        private System.Windows.Forms.Label labelUserGuess;
        private System.Windows.Forms.Label labelComputerGuess;
        private System.Windows.Forms.Label labelMatchHistory;
    }
}
