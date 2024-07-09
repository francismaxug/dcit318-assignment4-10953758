namespace newForm1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Password = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.usernamr = new System.Windows.Forms.TextBox();
            this.not_account = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.not_account);
            this.panel2.Controls.Add(this.LoginButton);
            this.panel2.Controls.Add(this.title);
            this.panel2.Controls.Add(this.pass);
            this.panel2.Controls.Add(this.username);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.Password);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.usernamr);
            this.panel2.Location = new System.Drawing.Point(94, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 359);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginButton.Location = new System.Drawing.Point(118, 261);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(187, 39);
            this.LoginButton.TabIndex = 7;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(159, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(117, 39);
            this.title.TabIndex = 6;
            this.title.Text = "Sign in";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pass.ForeColor = System.Drawing.SystemColors.Info;
            this.pass.Location = new System.Drawing.Point(46, 173);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(96, 25);
            this.pass.TabIndex = 5;
            this.pass.Text = "password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.username.ForeColor = System.Drawing.SystemColors.Info;
            this.username.Location = new System.Drawing.Point(46, 79);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(99, 25);
            this.username.TabIndex = 4;
            this.username.Text = "username";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(51, 241);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(323, 1);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Password.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password.Location = new System.Drawing.Point(51, 204);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(323, 31);
            this.Password.TabIndex = 1;
            this.Password.Tag = "";
            this.Password.Text = "\r\n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gray;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(51, 151);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(323, 1);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // usernamr
            // 
            this.usernamr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(18)))), ((int)(((byte)(37)))));
            this.usernamr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernamr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.usernamr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernamr.Location = new System.Drawing.Point(51, 118);
            this.usernamr.Name = "usernamr";
            this.usernamr.Size = new System.Drawing.Size(323, 27);
            this.usernamr.TabIndex = 0;
            // 
            // not_account
            // 
            this.not_account.AutoSize = true;
            this.not_account.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.not_account.Location = new System.Drawing.Point(115, 315);
            this.not_account.Name = "not_account";
            this.not_account.Size = new System.Drawing.Size(187, 16);
            this.not_account.TabIndex = 8;
            this.not_account.Text = "dont have an account? sign up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox usernamr;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label not_account;
    }
}

