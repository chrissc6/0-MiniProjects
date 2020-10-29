namespace TextToSpeech
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.playB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pauseB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.stopB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.volLabel = new System.Windows.Forms.ToolStripLabel();
            this.addVolB = new System.Windows.Forms.ToolStripButton();
            this.decVolB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.rateLabel = new System.Windows.Forms.ToolStripLabel();
            this.addRateB = new System.Windows.Forms.ToolStripButton();
            this.decRateB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.resetV = new System.Windows.Forms.ToolStripButton();
            this.resetR = new System.Windows.Forms.ToolStripButton();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createdByChrissc6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressLabel = new System.Windows.Forms.ToolStripLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.themesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.playB,
            this.toolStripSeparator2,
            this.pauseB,
            this.toolStripSeparator3,
            this.stopB,
            this.toolStripSeparator4,
            this.volLabel,
            this.addVolB,
            this.decVolB,
            this.resetV,
            this.toolStripSeparator5,
            this.rateLabel,
            this.addRateB,
            this.decRateB,
            this.resetR,
            this.toolStripSeparator6,
            this.progressLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(881, 35);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // playB
            // 
            this.playB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.playB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.playB.Image = ((System.Drawing.Image)(resources.GetObject("playB.Image")));
            this.playB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playB.Name = "playB";
            this.playB.Size = new System.Drawing.Size(33, 32);
            this.playB.Text = "▶️";
            this.playB.Click += new System.EventHandler(this.playB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // pauseB
            // 
            this.pauseB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pauseB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.pauseB.Image = ((System.Drawing.Image)(resources.GetObject("pauseB.Image")));
            this.pauseB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pauseB.Name = "pauseB";
            this.pauseB.Size = new System.Drawing.Size(43, 32);
            this.pauseB.Text = "⏸️";
            this.pauseB.Click += new System.EventHandler(this.pauseB_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // stopB
            // 
            this.stopB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stopB.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.stopB.Image = ((System.Drawing.Image)(resources.GetObject("stopB.Image")));
            this.stopB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopB.Name = "stopB";
            this.stopB.Size = new System.Drawing.Size(43, 32);
            this.stopB.Text = "⏹️";
            this.stopB.Click += new System.EventHandler(this.stopB_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // volLabel
            // 
            this.volLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(82, 32);
            this.volLabel.Text = "Volume: 70";
            // 
            // addVolB
            // 
            this.addVolB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addVolB.Image = ((System.Drawing.Image)(resources.GetObject("addVolB.Image")));
            this.addVolB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addVolB.Name = "addVolB";
            this.addVolB.Size = new System.Drawing.Size(23, 32);
            this.addVolB.Text = "➕";
            this.addVolB.Click += new System.EventHandler(this.addVolB_Click);
            this.addVolB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addVolB_MouseDown);
            this.addVolB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addVolB_MouseUp);
            // 
            // decVolB
            // 
            this.decVolB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.decVolB.Image = ((System.Drawing.Image)(resources.GetObject("decVolB.Image")));
            this.decVolB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decVolB.Name = "decVolB";
            this.decVolB.Size = new System.Drawing.Size(23, 32);
            this.decVolB.Text = "➖";
            this.decVolB.Click += new System.EventHandler(this.decVolB_Click);
            this.decVolB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.decVolB_MouseDown);
            this.decVolB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.decVolB_MouseUp);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Turquoise;
            this.richTextBox1.Location = new System.Drawing.Point(0, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(881, 503);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Hello world. This is a test.";
            // 
            // rateLabel
            // 
            this.rateLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(66, 32);
            this.rateLabel.Text = "Speed: 1";
            // 
            // addRateB
            // 
            this.addRateB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addRateB.Image = ((System.Drawing.Image)(resources.GetObject("addRateB.Image")));
            this.addRateB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addRateB.Name = "addRateB";
            this.addRateB.Size = new System.Drawing.Size(23, 32);
            this.addRateB.Text = "➕";
            this.addRateB.Click += new System.EventHandler(this.addRateB_Click);
            this.addRateB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addRateB_MouseDown);
            this.addRateB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addRateB_MouseUp);
            // 
            // decRateB
            // 
            this.decRateB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.decRateB.Image = ((System.Drawing.Image)(resources.GetObject("decRateB.Image")));
            this.decRateB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.decRateB.Name = "decRateB";
            this.decRateB.Size = new System.Drawing.Size(23, 32);
            this.decRateB.Text = "➖";
            this.decRateB.Click += new System.EventHandler(this.decRateB_Click);
            this.decRateB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.decRateB_MouseDown);
            this.decRateB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.decRateB_MouseUp);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // resetV
            // 
            this.resetV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resetV.Image = ((System.Drawing.Image)(resources.GetObject("resetV.Image")));
            this.resetV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetV.Name = "resetV";
            this.resetV.Size = new System.Drawing.Size(42, 32);
            this.resetV.Text = "RESET";
            this.resetV.Click += new System.EventHandler(this.resetV_Click);
            // 
            // resetR
            // 
            this.resetR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resetR.Image = ((System.Drawing.Image)(resources.GetObject("resetR.Image")));
            this.resetR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetR.Name = "resetR";
            this.resetR.Size = new System.Drawing.Size(42, 32);
            this.resetR.Text = "RESET";
            this.resetR.Click += new System.EventHandler(this.resetR_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createdByChrissc6ToolStripMenuItem,
            this.version10ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // createdByChrissc6ToolStripMenuItem
            // 
            this.createdByChrissc6ToolStripMenuItem.Name = "createdByChrissc6ToolStripMenuItem";
            this.createdByChrissc6ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.createdByChrissc6ToolStripMenuItem.Text = "Created By: Chrissc6";
            // 
            // version10ToolStripMenuItem
            // 
            this.version10ToolStripMenuItem.Name = "version10ToolStripMenuItem";
            this.version10ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.version10ToolStripMenuItem.Text = "Version 1.0";
            // 
            // progressLabel
            // 
            this.progressLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(96, 32);
            this.progressLabel.Text = "Progress: 0 %";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(769, 30);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 562);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyTTS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton playB;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton pauseB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton stopB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel volLabel;
        private System.Windows.Forms.ToolStripButton addVolB;
        private System.Windows.Forms.ToolStripButton decVolB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel rateLabel;
        private System.Windows.Forms.ToolStripButton addRateB;
        private System.Windows.Forms.ToolStripButton decRateB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton resetV;
        private System.Windows.Forms.ToolStripButton resetR;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createdByChrissc6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel progressLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
    }
}

