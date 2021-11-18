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
            t.Interval = 1; //1000 = 1sec
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object sender, EventArgs e)
        {
            bool am = true;

            System.DateTime moment = DateTime.Now;
            int year = moment.Year;
            int month = moment.Month;
            int day = moment.Day;
            int hour = moment.Hour;
            int minute = moment.Minute;
            int second = moment.Second;
            int millisecond = moment.Millisecond;

            label_day.Text = day.ToString();
            label_month.Text = month.ToString();
            label_year.Text = year.ToString();

            string time = "";

            if (hour == 0)
            {
                hour =  12;
            }
            if (hour > 12)
            {
                hour = hour - 12;
                am = false;
            }

            if (hour < 10)
            {
                label_timeHour.Text = $"0{hour.ToString()}:";
            }
            else
            {
                label_timeHour.Text = $"{hour.ToString()}:";
            }

            if (minute < 10)
            {
                label_timeMinute.Text = $"0{minute.ToString()}:";
            }
            else
            {
                label_timeMinute.Text = $"{minute.ToString()}:";
            }

            if (second < 10)
            {
                label_timeSecond.Text = $"0{second.ToString()}:";
            }
            else
            {
                label_timeSecond.Text = $"{second.ToString()}:";
            }

            if (millisecond < 10)
            {
                label_timeMillisecond.Text = $"{millisecond.ToString()}";
            }
            else
            {
                label_timeMillisecond.Text = $"{millisecond.ToString()}";
            }

            if (am)
            {
                label_timeBool.Text = "AM";
            }
            else
            {
                label_timeBool.Text = "PM";
            }
        }
    }
}


/*
 * Sunday
 * Monday
 * Tuesday
 * Wednesday
 * Thursday
 * Friday
 * Saturday
 * 
 * January
 * February
 * March
 * April
 * May
 * June
 * July
 * August
 * September
 * October
 * November
 * December
*/