namespace LoginFormDB
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
            this.unLabel = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.passTb = new System.Windows.Forms.TextBox();
            this.loginB = new System.Windows.Forms.Button();
            this.pwLabel = new System.Windows.Forms.Label();
            this.logoutB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unLabel
            // 
            this.unLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unLabel.Location = new System.Drawing.Point(12, 9);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(156, 36);
            this.unLabel.TabIndex = 0;
            this.unLabel.Text = "Username: ";
            this.unLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTb
            // 
            this.usernameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTb.Location = new System.Drawing.Point(174, 12);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(248, 30);
            this.usernameTb.TabIndex = 2;
            this.usernameTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernameTb_KeyDown);
            // 
            // passTb
            // 
            this.passTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTb.Location = new System.Drawing.Point(174, 64);
            this.passTb.Name = "passTb";
            this.passTb.PasswordChar = '*';
            this.passTb.Size = new System.Drawing.Size(248, 30);
            this.passTb.TabIndex = 3;
            this.passTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTb_KeyDown);
            // 
            // loginB
            // 
            this.loginB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginB.Location = new System.Drawing.Point(100, 132);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(100, 41);
            this.loginB.TabIndex = 4;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // pwLabel
            // 
            this.pwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwLabel.Location = new System.Drawing.Point(12, 64);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(156, 36);
            this.pwLabel.TabIndex = 5;
            this.pwLabel.Text = "Password: ";
            this.pwLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoutB
            // 
            this.logoutB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutB.Location = new System.Drawing.Point(206, 132);
            this.logoutB.Name = "logoutB";
            this.logoutB.Size = new System.Drawing.Size(100, 41);
            this.logoutB.TabIndex = 6;
            this.logoutB.Text = "Exit";
            this.logoutB.UseVisualStyleBackColor = true;
            this.logoutB.Click += new System.EventHandler(this.logoutB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(434, 185);
            this.Controls.Add(this.logoutB);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.loginB);
            this.Controls.Add(this.passTb);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.unLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFormDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.Button logoutB;
    }
}

