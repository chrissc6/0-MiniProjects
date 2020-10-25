using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer t = new Timer();
        private void Form1_Load(object sender, EventArgs e)
        {
            t.Interval = 1000; //1sec
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            int h = DateTime.Now.Hour;
            int m = DateTime.Now.Minute;
            int s = DateTime.Now.Second;
            bool am = true;

            string time = "";

            if (h == 0)
            {
                h =  12;
            }
            if (h > 12)
            {
                h = h - 12;
                am = false;
            }

            if (h < 10)
            {
                time = $"0{h}:";
            }
            else
            {
                time = $"{h.ToString()}:";
            }

            if (m < 10)
            {
                time += $"0{m}:";
            }
            else
            {
                time += $"{m.ToString()}:";
            }

            if (s < 10)
            {
                time += $"0{s}";
            }
            else
            {
                time += $"{s.ToString()}";
            }

            if (am)
            {
                time += $" AM";
            }
            else
            {
                time += $" PM";
            }

            label1.Text = time;
        }
    }
}
