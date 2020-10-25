namespace MyPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.redB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.blueB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.greenB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.purpleB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.yellowB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.orangeB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.whiteB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.blackB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.grayB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.addB = new System.Windows.Forms.ToolStripButton();
            this.minusB = new System.Windows.Forms.ToolStripButton();
            this.brushSizeLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madeByChriss6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.redB,
            this.toolStripSeparator2,
            this.blueB,
            this.toolStripSeparator3,
            this.greenB,
            this.toolStripSeparator4,
            this.purpleB,
            this.toolStripSeparator5,
            this.yellowB,
            this.toolStripSeparator6,
            this.orangeB,
            this.toolStripSeparator7,
            this.whiteB,
            this.toolStripSeparator8,
            this.blackB,
            this.toolStripSeparator9,
            this.grayB,
            this.toolStripSeparator10,
            this.addB,
            this.minusB,
            this.brushSizeLabel,
            this.toolStripSeparator11,
            this.toolStripButton1,
            this.toolStripSeparator12});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // redB
            // 
            this.redB.BackColor = System.Drawing.Color.Red;
            this.redB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.redB.Image = ((System.Drawing.Image)(resources.GetObject("redB.Image")));
            this.redB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redB.Name = "redB";
            this.redB.Size = new System.Drawing.Size(23, 22);
            this.redB.Text = "toolStripButton1";
            this.redB.Click += new System.EventHandler(this.redB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // blueB
            // 
            this.blueB.BackColor = System.Drawing.Color.Blue;
            this.blueB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.blueB.Image = ((System.Drawing.Image)(resources.GetObject("blueB.Image")));
            this.blueB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blueB.Name = "blueB";
            this.blueB.Size = new System.Drawing.Size(23, 22);
            this.blueB.Text = "toolStripButton2";
            this.blueB.Click += new System.EventHandler(this.blueB_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // greenB
            // 
            this.greenB.BackColor = System.Drawing.Color.Green;
            this.greenB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.greenB.Image = ((System.Drawing.Image)(resources.GetObject("greenB.Image")));
            this.greenB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenB.Name = "greenB";
            this.greenB.Size = new System.Drawing.Size(23, 22);
            this.greenB.Text = "toolStripButton3";
            this.greenB.Click += new System.EventHandler(this.greenB_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // purpleB
            // 
            this.purpleB.BackColor = System.Drawing.Color.Purple;
            this.purpleB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.purpleB.Image = ((System.Drawing.Image)(resources.GetObject("purpleB.Image")));
            this.purpleB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.purpleB.Name = "purpleB";
            this.purpleB.Size = new System.Drawing.Size(23, 22);
            this.purpleB.Text = "toolStripButton4";
            this.purpleB.Click += new System.EventHandler(this.purpleB_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // yellowB
            // 
            this.yellowB.BackColor = System.Drawing.Color.Yellow;
            this.yellowB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.yellowB.Image = ((System.Drawing.Image)(resources.GetObject("yellowB.Image")));
            this.yellowB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yellowB.Name = "yellowB";
            this.yellowB.Size = new System.Drawing.Size(23, 22);
            this.yellowB.Text = "toolStripButton5";
            this.yellowB.Click += new System.EventHandler(this.yellowB_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // orangeB
            // 
            this.orangeB.BackColor = System.Drawing.Color.Orange;
            this.orangeB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.orangeB.Image = ((System.Drawing.Image)(resources.GetObject("orangeB.Image")));
            this.orangeB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.orangeB.Name = "orangeB";
            this.orangeB.Size = new System.Drawing.Size(23, 22);
            this.orangeB.Text = "toolStripButton6";
            this.orangeB.Click += new System.EventHandler(this.orangeB_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // whiteB
            // 
            this.whiteB.BackColor = System.Drawing.Color.White;
            this.whiteB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.whiteB.Image = ((System.Drawing.Image)(resources.GetObject("whiteB.Image")));
            this.whiteB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.whiteB.Name = "whiteB";
            this.whiteB.Size = new System.Drawing.Size(23, 22);
            this.whiteB.Text = "toolStripButton7";
            this.whiteB.Click += new System.EventHandler(this.whiteB_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // blackB
            // 
            this.blackB.BackColor = System.Drawing.Color.Black;
            this.blackB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.blackB.Image = ((System.Drawing.Image)(resources.GetObject("blackB.Image")));
            this.blackB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blackB.Name = "blackB";
            this.blackB.Size = new System.Drawing.Size(23, 22);
            this.blackB.Text = "toolStripButton8";
            this.blackB.Click += new System.EventHandler(this.blackB_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // grayB
            // 
            this.grayB.BackColor = System.Drawing.Color.Gray;
            this.grayB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.grayB.Image = ((System.Drawing.Image)(resources.GetObject("grayB.Image")));
            this.grayB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.grayB.Name = "grayB";
            this.grayB.Size = new System.Drawing.Size(23, 22);
            this.grayB.Text = "toolStripButton9";
            this.grayB.Click += new System.EventHandler(this.grayB_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // addB
            // 
            this.addB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addB.Image = ((System.Drawing.Image)(resources.GetObject("addB.Image")));
            this.addB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(23, 22);
            this.addB.Text = "+";
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // minusB
            // 
            this.minusB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.minusB.Image = ((System.Drawing.Image)(resources.GetObject("minusB.Image")));
            this.minusB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.minusB.Name = "minusB";
            this.minusB.Size = new System.Drawing.Size(23, 22);
            this.minusB.Text = "-";
            this.minusB.Click += new System.EventHandler(this.minusB_Click);
            // 
            // brushSizeLabel
            // 
            this.brushSizeLabel.Name = "brushSizeLabel";
            this.brushSizeLabel.Size = new System.Drawing.Size(13, 22);
            this.brushSizeLabel.Text = "0";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 401);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseChange);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseChange);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeByChriss6ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // madeByChriss6ToolStripMenuItem
            // 
            this.madeByChriss6ToolStripMenuItem.Name = "madeByChriss6ToolStripMenuItem";
            this.madeByChriss6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.madeByChriss6ToolStripMenuItem.Text = "Made By: Chriss6";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "CLEAR";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton redB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton blueB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton greenB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton purpleB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton yellowB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton orangeB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton whiteB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton blackB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton grayB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton addB;
        private System.Windows.Forms.ToolStripButton minusB;
        private System.Windows.Forms.ToolStripLabel brushSizeLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madeByChriss6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
    }
}

