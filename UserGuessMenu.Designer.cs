namespace WindowsFormsApp1
{
    partial class UserGuessMenu
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
            this.labelUserGuess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserGuess
            // 
            this.labelUserGuess.AutoSize = true;
            this.labelUserGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserGuess.Location = new System.Drawing.Point(63, 29);
            this.labelUserGuess.Name = "labelUserGuess";
            this.labelUserGuess.Size = new System.Drawing.Size(355, 69);
            this.labelUserGuess.TabIndex = 0;
            this.labelUserGuess.Text = "User Guess";
            // 
            // UserGuessMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelUserGuess);
            this.Name = "UserGuessMenu";
            this.Size = new System.Drawing.Size(1200, 690);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserGuess;
    }
}
