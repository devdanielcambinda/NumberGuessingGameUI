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
            this.components = new System.ComponentModel.Container();
            this.labelUserGuess = new System.Windows.Forms.Label();
            this.NumerosFalhados = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.guessBox = new System.Windows.Forms.TextBox();
            this.SubmitButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ResetButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TentativasToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUserGuess
            // 
            this.labelUserGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserGuess.Location = new System.Drawing.Point(63, 29);
            this.labelUserGuess.Name = "labelUserGuess";
            this.labelUserGuess.Size = new System.Drawing.Size(400, 69);
            this.labelUserGuess.TabIndex = 0;
            this.labelUserGuess.Text = "User Guess";
            // 
            // NumerosFalhados
            // 
            this.NumerosFalhados.Location = new System.Drawing.Point(770, 192);
            this.NumerosFalhados.Multiline = true;
            this.NumerosFalhados.Name = "NumerosFalhados";
            this.NumerosFalhados.ReadOnly = true;
            this.NumerosFalhados.Size = new System.Drawing.Size(372, 437);
            this.NumerosFalhados.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(111, 362);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(165, 64);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(343, 362);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(165, 64);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // guessBox
            // 
            this.guessBox.Location = new System.Drawing.Point(111, 298);
            this.guessBox.Multiline = true;
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(397, 40);
            this.guessBox.TabIndex = 4;
            // 
            // SubmitButtonToolTip
            // 
            this.SubmitButtonToolTip.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SubmitButtonToolTip.IsBalloon = true;
            this.SubmitButtonToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.SubmitButtonToolTip.ToolTipTitle = "Submit Button";
            // 
            // ResetButtonToolTip
            // 
            this.ResetButtonToolTip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ResetButtonToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ResetButtonToolTip.ToolTipTitle = "Reset Button";
            // 
            // TentativasToolTip
            // 
            this.TentativasToolTip.ToolTipTitle = "Tentativas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert your guess bellow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(765, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Failed Guesses";
            // 
            // UserGuessMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.NumerosFalhados);
            this.Controls.Add(this.labelUserGuess);
            this.Name = "UserGuessMenu";
            this.Size = new System.Drawing.Size(1200, 690);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserGuess;
        private System.Windows.Forms.TextBox NumerosFalhados;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox guessBox;
        private System.Windows.Forms.ToolTip SubmitButtonToolTip;
        private System.Windows.Forms.ToolTip ResetButtonToolTip;
        private System.Windows.Forms.ToolTip TentativasToolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
