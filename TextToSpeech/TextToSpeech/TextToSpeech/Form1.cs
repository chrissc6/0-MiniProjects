using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using Timer = System.Timers.Timer;
using System.Timers;
using System.Runtime.CompilerServices;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        public const int cVol = 70;
        public const int cRate = 1;

        public int vol = cVol;
        public int rate = cRate;

        public bool u = false;
        public bool d = false;
        public bool ru = false;
        public bool rd = false;
        public bool pause = false;
        public bool stop = false;

        public SpeechSynthesizer speaker = new SpeechSynthesizer();
        private static Timer loopTimer;

        public Form1()
        {
            InitializeComponent();


            //loop timer
            loopTimer = new Timer();
            loopTimer.Interval = 100; // interval in milliseconds
            loopTimer.Enabled = false;
            loopTimer.Elapsed += loopTimerEvent;
            loopTimer.AutoReset = true;
        }

        //Loop
        private void loopTimerEvent(Object source, ElapsedEventArgs e)
        {
            if (u)
            {
                VolUp();
            }
            else if (d)
            {
                VolDown();
            }
            else if (ru)
            {
                RateUp();
            }
            else if (rd)
            {
                RateDown();
            }
        }
        
        //Volume Up --
        public void VolUp()
        {
            if (vol >= 100)
            {

            }
            else
            {
                vol++;
            }
            volLabel.Text = $"Volume: {vol}";
        }

        private void addVolB_Click(object sender, EventArgs e)
        {
            VolUp();

        }

        private void addVolB_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                u = false;
                loopTimer.Enabled = false;
            }
        }
        private void addVolB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                u = true;
                loopTimer.Enabled = true;
            }
        }
        //Volume Up --

        //Volume Down --
        public void VolDown()
        {
            if (vol <= 1)
            {

            }
            else
            {
                vol--;
            }
            volLabel.Text = $"Volume: {vol}";
        }
        private void decVolB_Click(object sender, EventArgs e)
        {
            VolDown();
        }

        private void decVolB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                d = true;
                loopTimer.Enabled = true;
            }
        }

        private void decVolB_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                d = false;
                loopTimer.Enabled = false;
            }

        }
        //Volume Down --


        //Rate Up --
        public void RateUp()
        {
            if (rate >= 10) 
            {

            }
            else
            {
                rate++;
            }
            rateLabel.Text = $"Speed: {rate}";
        }
        private void addRateB_Click(object sender, EventArgs e)
        {
            RateUp();
        }

        private void addRateB_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ru = false;
                loopTimer.Enabled = false;
            }
        }

        private void addRateB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ru = true;
                loopTimer.Enabled = true;
            }
        }
        //Rate Up --

        //Rate Down --
        public void RateDown()
        {
            if (rate <= -10) 
            { 

            }
            else
            {
                rate--;
            }
            rateLabel.Text = $"Speed: {rate}";
        }

        private void decRateB_Click(object sender, EventArgs e)
        {
            RateDown();
        }

        private void decRateB_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rd = false;
                loopTimer.Enabled = false;
            }
        }

        private void decRateB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rd = true;
                loopTimer.Enabled = true;
            }
        }
        //Rate Down --

        private void resetV_Click(object sender, EventArgs e)
        {
            vol = cVol;
            volLabel.Text = $"Volume: {vol}";
        }

        private void resetR_Click(object sender, EventArgs e)
        {
            rate = cRate;
            rateLabel.Text = $"Speed: {rate}";
        }

        public PromptBuilder builder = new PromptBuilder();

        //Play
        private void playB_Click(object sender, EventArgs e)
        {
            SynthesizerState state = speaker.State;
            if (stop)
            {
                stop = false;
                Start();
            }
            else if (state == SynthesizerState.Paused)
            {
                speaker.Resume();
                pause = false;
            }
            else
            {
                Start();
            }

        }

        public void Start()
        {
            builder = new PromptBuilder();
            string msg = richTextBox1.Text;

            builder.AppendText(msg);
            speaker.Rate = rate;
            speaker.Volume = vol;
            //speaker.Voice =

            speaker.SpeakAsync(builder);
            //speaker.SpeakProgress += speaker_SpeakProgress;
            
        }

        private void pauseB_Click(object sender, EventArgs e)
        {
            SynthesizerState state = speaker.State;

            if (state == SynthesizerState.Speaking)
            {
                pause = true;
                speaker.Pause();
            }
        }

        private void stopB_Click(object sender, EventArgs e)
        {
            //pause = false;
            stop = true;
            speaker.SpeakAsyncCancelAll();
        }

        protected virtual void OnThresholdReached(SpeakCompletedEventArgs e)
        {
            EventHandler<System.Speech.Synthesis.SpeakCompletedEventArgs> handler = SpeakCompleted;
            if (handler != null)
            {
                pause = false;
                speaker.SpeakAsyncCancelAll();
            }
        }

        public event EventHandler<System.Speech.Synthesis.SpeakCompletedEventArgs> SpeakCompleted;
        public event EventHandler<System.Speech.Synthesis.SpeakProgressEventArgs> SpeakProgress;

        protected virtual void OnProgressReached(SpeakProgressEventArgs e)
        {
            EventHandler<System.Speech.Synthesis.SpeakProgressEventArgs> handler = SpeakProgress;
            if (handler != null)
            {
                //Progress: 0 %
                pause = false;
                SynthesizerState state = speaker.State;
                //speaker_SpeakProgress(null, e);
            }
        }

        //private void speaker_SpeakProgress(Object sender, SpeakProgressEventArgs e)
        //{
        //    ProgressBar.Value = (Int32)((e.CharacterPosition + e.CharacterCount - 82F) / progressBar1.Text.Length * 100);
        //}
    }
}
