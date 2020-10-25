using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class pongForm : Form
    {
        //global speed settings
        public const int st = 20;
        public const int sl = 20;

        public int speedTop = st;
        public int speedLeft = sl;
        public int points = 0;

        public pongForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            rackerPbox.Top = pongPlayground.Bottom - (pongPlayground.Bottom / 10);

            titleLabel.Left = (pongPlayground.Width / 2) - (titleLabel.Width / 2);
            titleLabel.Top = (pongPlayground.Height / 2) - (titleLabel.Height / 2);
            titleLabel.Visible = false;

            //round the ball
            RoundThepBox(ballPbox);

            //make line into shadow thing
            RoundThepBox(rackerPbox);

            timer1.Start();
        }

        public void RoundThepBox(PictureBox pBox)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pBox.Width - 3, pBox.Height - 3);
            Region rg = new Region(gp);
            pBox.Region = rg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pongPlayground_Paint(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //racket to follow cursor
            rackerPbox.Left = Cursor.Position.X - (rackerPbox.Width / 2);

            ballPbox.Left += speedLeft;
            ballPbox.Top += speedTop;

            if (ballPbox.Bottom >= rackerPbox.Top && ballPbox.Bottom <= rackerPbox.Bottom && ballPbox.Left >=  rackerPbox.Left && ballPbox.Right <= rackerPbox.Right)
            {
                speedTop += 2;
                speedLeft += 2;
                speedTop = -speedTop; //change direction
                points += 1;
                scoreLabel.Text = points.ToString();
                newBallColor();
            }

            if (ballPbox.Left <= pongPlayground.Left)
            {
                speedLeft = -speedLeft; //change direction
                newBallColor();
            }

            if (ballPbox.Right >= pongPlayground.Right)
            {
                speedLeft = -speedLeft; //change direction
                newBallColor();
            }

            if (ballPbox.Top <= pongPlayground.Top)
            {
                speedTop = -speedTop; //change direction
                newBallColor();
            }

            if (ballPbox.Bottom >= pongPlayground.Bottom)
            {
                timer1.Enabled = false;
                titleLabel.Visible = true;
            }
        }

        public void newBallColor()
        {
            Random rng = new Random();
            ballPbox.BackColor = Color.FromArgb(rng.Next(150, 255), rng.Next(150, 255), rng.Next(150, 255));
        }

        private void pongForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ballPbox.Top = 50;
                ballPbox.Left = 50;
                speedLeft = sl;
                speedTop = st;
                points = 0;
                scoreLabel.Text = "0";
                titleLabel.Visible = false;
                ballPbox.BackColor = Color.Turquoise;
                timer1.Start();
            }
        }
    }
}
