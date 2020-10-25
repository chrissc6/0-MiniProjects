namespace Pong
{
    partial class pongForm
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
            this.pongPlayground = new System.Windows.Forms.Panel();
            this.scoreTitleLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.rackerPbox = new System.Windows.Forms.PictureBox();
            this.ballPbox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pongPlayground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rackerPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pongPlayground
            // 
            this.pongPlayground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pongPlayground.Controls.Add(this.ballPbox);
            this.pongPlayground.Controls.Add(this.rackerPbox);
            this.pongPlayground.Controls.Add(this.titleLabel);
            this.pongPlayground.Controls.Add(this.scoreLabel);
            this.pongPlayground.Controls.Add(this.scoreTitleLabel);
            this.pongPlayground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pongPlayground.Location = new System.Drawing.Point(0, 0);
            this.pongPlayground.Name = "pongPlayground";
            this.pongPlayground.Size = new System.Drawing.Size(800, 450);
            this.pongPlayground.TabIndex = 0;
            this.pongPlayground.Paint += new System.Windows.Forms.PaintEventHandler(this.pongPlayground_Paint);
            // 
            // scoreTitleLabel
            // 
            this.scoreTitleLabel.AutoSize = true;
            this.scoreTitleLabel.Font = new System.Drawing.Font("8bitoperator", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreTitleLabel.Location = new System.Drawing.Point(12, 179);
            this.scoreTitleLabel.Name = "scoreTitleLabel";
            this.scoreTitleLabel.Size = new System.Drawing.Size(143, 41);
            this.scoreTitleLabel.TabIndex = 0;
            this.scoreTitleLabel.Text = "Score: ";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("8bitoperator", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(142, 179);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 41);
            this.scoreLabel.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("8bitoperator", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(278, 141);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Pong\r\nStart = Enter\r\nExit = Esc";
            // 
            // rackerPbox
            // 
            this.rackerPbox.BackColor = System.Drawing.Color.Black;
            this.rackerPbox.Location = new System.Drawing.Point(283, 416);
            this.rackerPbox.Name = "rackerPbox";
            this.rackerPbox.Size = new System.Drawing.Size(222, 31);
            this.rackerPbox.TabIndex = 3;
            this.rackerPbox.TabStop = false;
            // 
            // ballPbox
            // 
            this.ballPbox.BackColor = System.Drawing.Color.Turquoise;
            this.ballPbox.Location = new System.Drawing.Point(379, 380);
            this.ballPbox.Name = "ballPbox";
            this.ballPbox.Size = new System.Drawing.Size(30, 30);
            this.ballPbox.TabIndex = 4;
            this.ballPbox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pongPlayground);
            this.Name = "pongForm";
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pongForm_KeyDown);
            this.pongPlayground.ResumeLayout(false);
            this.pongPlayground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rackerPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ballPbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pongPlayground;
        private System.Windows.Forms.PictureBox ballPbox;
        private System.Windows.Forms.PictureBox rackerPbox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreTitleLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

