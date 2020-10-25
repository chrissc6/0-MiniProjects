using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        public int w = 1024;
        public int h = 768;
        Bitmap bmap = new Bitmap(1024, 768);
        Pen p = new Pen(Color.Black, 5);
        //Bitmap bmap;
        //Pen p;
        bool draw = false;
        public Form1()
        {
            InitializeComponent();
            h = pictureBox1.Height;
            w = pictureBox1.Width;
            //bmap = new Bitmap(w, h);
            //p = new Pen(Color.Black, 5);
            brushSizeLabel.Text = p.Width.ToString();
        }

        private void pictureBox1_MouseChange(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                draw = false;
            }
            else
            {
                draw = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                Graphics g = Graphics.FromImage(bmap);
                g.DrawEllipse(p, e.X, e.Y, 3, 1);
                pictureBox1.Image = bmap;
            }
        }

        private void redB_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void blueB_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void greenB_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void purpleB_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void yellowB_Click(object sender, EventArgs e)
        {
            p.Color = Color.Yellow;
        }

        private void orangeB_Click(object sender, EventArgs e)
        {
            p.Color = Color.Orange;
        }

        private void whiteB_Click(object sender, EventArgs e)
        {
            p.Color = Color.White;
        }

        private void blackB_Click(object sender, EventArgs e)
        {
            p.Color = Color.Black;
        }

        private void grayB_Click(object sender, EventArgs e)
        {
            p.Color = Color.Gray;
        }

        private void addB_Click(object sender, EventArgs e)
        {
            p.Width += 1;
            brushSizeLabel.Text = p.Width.ToString();
        }

        private void minusB_Click(object sender, EventArgs e)
        {
            if (p.Width > 1)
            {
                p.Width -= 1;
            }
            brushSizeLabel.Text = p.Width.ToString();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "JPeg Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp";
            save.Title = "Save an Image File";
            save.ShowDialog();

            if (save.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)save.OpenFile();
                switch (save.FilterIndex)
                {
                    case 1:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 3:
                        this.pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    default:
                        break;
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            bmap = new Bitmap(1024, 768);
            pictureBox1.Image = bmap;
        }
    }
}
