using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserGuessMenu : UserControl
    {
        public int NumberToBeGuessed
        {
            get; private set;
        }

        public UserGuessMenu()
        {
            InitializeComponent();
            SubmitButtonToolTip.SetToolTip(SubmitButton, "Click on this button to submit you guess.");
            ResetButtonToolTip.SetToolTip(ResetButton, "This button will delete whatever you wrote in the text box above.");
            TentativasToolTip.SetToolTip(NumerosFalhados, "This box presents the numbers that you thought that were the correct one.");
            
            Random rdm = new Random();
            NumberToBeGuessed = rdm.Next(1, 101);


        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            NumerosFalhados.Text = NumerosFalhados.Text + $"\n{guessBox.Text}";
            guessBox.Text = String.Empty;

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            guessBox.Text = String.Empty;
        }
    }
}
