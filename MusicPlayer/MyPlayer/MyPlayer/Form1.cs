using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ppSwitch = false;
        bool bSwitch = false;

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }

            winPlayer.URL = textBox1.Text;
            bSwitch = true;
        }

        private void preBtn_Click(object sender, EventArgs e)
        {
            winPlayer.Ctlcontrols.previous();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nexBtn_Click(object sender, EventArgs e)
        {
            winPlayer.Ctlcontrols.next();
            //winPlayer.URL = 
        }

        private void ppBtn_Click(object sender, EventArgs e)
        {
            if (ppSwitch && bSwitch)
            {
                winPlayer.Ctlcontrols.play();
                ppSwitch = false;
            }
            else if (!ppSwitch && bSwitch)
            {
                winPlayer.Ctlcontrols.pause();
                ppSwitch = true;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            winPlayer.Ctlcontrols.stop();
            ppSwitch = true;
        }
    }
}
