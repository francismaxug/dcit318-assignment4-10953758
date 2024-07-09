namespace address_book
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
            this.header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Gold;
            this.header.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.header.Location = new System.Drawing.Point(295, 33);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(8, 1, 8, 1);
            this.header.Size = new System.Drawing.Size(221, 33);
            this.header.TabIndex = 0;
            this.header.Text = "ADDRESS BOOK";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.phoneInput);
            this.panel1.Controls.Add(this.phoneLabel);
            this.panel1.Controls.Add(this.emailInput);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.nameInput);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(186, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 338);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(15, 16);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(125, 25);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter Name";
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.SystemColors.Menu;
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nameInput.Location = new System.Drawing.Point(20, 45);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(369, 32);
            this.nameInput.TabIndex = 1;
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.SystemColors.Menu;
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.emailInput.Location = new System.Drawing.Point(20, 133);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(369, 32);
            this.emailInput.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(15, 104);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(122, 25);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Enter Email";
            // 
            // phoneInput
            // 
            this.phoneInput.BackColor = System.Drawing.SystemColors.Menu;
            this.phoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.phoneInput.Location = new System.Drawing.Point(20, 226);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(369, 32);
            this.phoneInput.TabIndex = 5;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(15, 197);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(212, 25);
            this.phoneLabel.TabIndex = 4;
            this.phoneLabel.Text = "Enter Phone Number";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveBtn.Location = new System.Drawing.Point(251, 265);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(138, 39);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button saveBtn;
    }
}

