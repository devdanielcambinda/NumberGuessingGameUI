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
    public partial class SettingButtonMenu : UserControl
    {
        public SettingButtonMenu()
        {
            InitializeComponent();
            MediumDifficultyButton.Checked = true;
        }

        public bool LowRadioIsSelected()
        {
            if (LowDifficultyButton.Checked)
            {
                return true;
            }
            else return false;  
        }

        public bool MediumRadioIsSelected()
        {
            if (MediumDifficultyButton.Checked)
            {
                return true;
            }
            else return false;
        }

        public bool HardRadioIsSelected()
        {

            if (HardDifficultyButton.Checked)
            {
                return true;
            }
            else return false;

        }
    
    }
}
