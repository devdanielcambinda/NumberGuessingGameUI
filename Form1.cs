using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public object MessageBoxManager { get; private set; }
      

        public Form1()
        {
            InitializeComponent();
            mainMenu1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            helpButtonMenu1.BringToFront();
        }

        private void back_Click(object sender, EventArgs e)
        {
            mainMenu1.BringToFront();
        }
    }
}
