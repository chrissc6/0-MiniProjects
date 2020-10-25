namespace MyPlayer
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
            this.winPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.preBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nexBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.ppBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.winPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // winPlayer
            // 
            this.winPlayer.Enabled = true;
            this.winPlayer.Location = new System.Drawing.Point(0, 2);
            this.winPlayer.Name = "winPlayer";
            this.winPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("winPlayer.OcxState")));
            this.winPlayer.Size = new System.Drawing.Size(800, 250);
            this.winPlayer.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 219);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 33);
            this.textBox1.TabIndex = 1;
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.DimGray;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseBtn.Font = new System.Drawing.Font("8bitoperator", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.browseBtn.Location = new System.Drawing.Point(0, 258);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(113, 64);
            this.browseBtn.TabIndex = 2;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("8bitoperator", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.exitBtn.Location = new System.Drawing.Point(700, 265);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 57);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // preBtn
            // 
            this.preBtn.BackColor = System.Drawing.Color.DimGray;
            this.preBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.preBtn.Font = new System.Drawing.Font("8bitoperator", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.preBtn.Location = new System.Drawing.Point(241, 266);
            this.preBtn.Name = "preBtn";
            this.preBtn.Size = new System.Drawing.Size(31, 51);
            this.preBtn.TabIndex = 2;
            this.preBtn.Text = "⏴︎";
            this.preBtn.UseVisualStyleBackColor = false;
            this.preBtn.Click += new System.EventHandler(this.preBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // nexBtn
            // 
            this.nexBtn.BackColor = System.Drawing.Color.DimGray;
            this.nexBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nexBtn.Font = new System.Drawing.Font("8bitoperator", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nexBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.nexBtn.Location = new System.Drawing.Point(278, 266);
            this.nexBtn.Name = "nexBtn";
            this.nexBtn.Size = new System.Drawing.Size(31, 51);
            this.nexBtn.TabIndex = 6;
            this.nexBtn.Text = "⏵︎";
            this.nexBtn.UseVisualStyleBackColor = false;
            this.nexBtn.Click += new System.EventHandler(this.nexBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.DimGray;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stopBtn.Font = new System.Drawing.Font("8bitoperator", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.stopBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.stopBtn.Location = new System.Drawing.Point(315, 266);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(59, 51);
            this.stopBtn.TabIndex = 7;
            this.stopBtn.Text = "⏹︎";
            this.stopBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // ppBtn
            // 
            this.ppBtn.BackColor = System.Drawing.Color.DimGray;
            this.ppBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ppBtn.Font = new System.Drawing.Font("8bitoperator", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppBtn.ForeColor = System.Drawing.Color.Turquoise;
            this.ppBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ppBtn.Location = new System.Drawing.Point(176, 266);
            this.ppBtn.Name = "ppBtn";
            this.ppBtn.Size = new System.Drawing.Size(59, 51);
            this.ppBtn.TabIndex = 8;
            this.ppBtn.Text = "⏯︎";
            this.ppBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ppBtn.UseVisualStyleBackColor = false;
            this.ppBtn.Click += new System.EventHandler(this.ppBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.ppBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.nexBtn);
            this.Controls.Add(this.preBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.winPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.winPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer winPlayer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button preBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button nexBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button ppBtn;
    }
}

