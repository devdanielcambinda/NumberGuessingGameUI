﻿using System;
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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonUserGuess_Click(object sender, EventArgs e)
        {
            UserGuessMenu jogoDeAdivinhar = new UserGuessMenu();
            jogoDeAdivinhar.Visible = true;
            

            
        }

        private void buttonCpuGuess_Click(object sender, EventArgs e)
        {

        }

        private void buttonMatchHistory_Click(object sender, EventArgs e)
        {

        }
    }
}
