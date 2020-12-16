using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            mainMenu.BringToFront();
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonBack.Visible = false; 
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {

            DialogResult exit = MessageBox.Show("Do you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (exit == DialogResult.Yes)
            {
                this.Close();
            }
            

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            settingButtonMenu1.BringToFront();
            buttonBack.Visible = true;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            helpButtonMenu.BringToFront();
            buttonBack.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            mainMenu.BringToFront();
            buttonBack.Visible = false;
        }
    }
}
