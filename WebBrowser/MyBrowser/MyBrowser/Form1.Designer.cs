namespace MyBrowser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.backBtntoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.forwardBtntoolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.locationCboxtoolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.goBtntoolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backBtntoolStripButton1,
            this.toolStripSeparator1,
            this.forwardBtntoolStripButton2,
            this.toolStripSeparator2,
            this.locationCboxtoolStripComboBox1,
            this.goBtntoolStripButton3,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(800, 425);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // backBtntoolStripButton1
            // 
            this.backBtntoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backBtntoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("backBtntoolStripButton1.Image")));
            this.backBtntoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backBtntoolStripButton1.Name = "backBtntoolStripButton1";
            this.backBtntoolStripButton1.Size = new System.Drawing.Size(36, 22);
            this.backBtntoolStripButton1.Text = "Back";
            this.backBtntoolStripButton1.Click += new System.EventHandler(this.backBtntoolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // forwardBtntoolStripButton2
            // 
            this.forwardBtntoolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.forwardBtntoolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("forwardBtntoolStripButton2.Image")));
            this.forwardBtntoolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardBtntoolStripButton2.Name = "forwardBtntoolStripButton2";
            this.forwardBtntoolStripButton2.Size = new System.Drawing.Size(54, 22);
            this.forwardBtntoolStripButton2.Text = "Forward";
            this.forwardBtntoolStripButton2.Click += new System.EventHandler(this.forwardBtntoolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // locationCboxtoolStripComboBox1
            // 
            this.locationCboxtoolStripComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.locationCboxtoolStripComboBox1.Name = "locationCboxtoolStripComboBox1";
            this.locationCboxtoolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.locationCboxtoolStripComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.locationCboxtoolStripComboBox1_KeyDown);
            // 
            // goBtntoolStripButton3
            // 
            this.goBtntoolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.goBtntoolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("goBtntoolStripButton3.Image")));
            this.goBtntoolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBtntoolStripButton3.Name = "goBtntoolStripButton3";
            this.goBtntoolStripButton3.Size = new System.Drawing.Size(26, 22);
            this.goBtntoolStripButton3.Text = "Go";
            this.goBtntoolStripButton3.Click += new System.EventHandler(this.goBtntoolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "MyBrowser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backBtntoolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton forwardBtntoolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox locationCboxtoolStripComboBox1;
        private System.Windows.Forms.ToolStripButton goBtntoolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

