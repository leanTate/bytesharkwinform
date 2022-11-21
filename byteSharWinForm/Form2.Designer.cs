namespace byteSharWinForm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.passL = new System.Windows.Forms.Label();
            this.emailL = new System.Windows.Forms.Label();
            this.rgPassword = new System.Windows.Forms.TextBox();
            this.rgEmail = new System.Windows.Forms.TextBox();
            this.usrNameL = new System.Windows.Forms.Label();
            this.rgName = new System.Windows.Forms.TextBox();
            this.lstNameL = new System.Windows.Forms.Label();
            this.rgLastName = new System.Windows.Forms.TextBox();
            this.cellL = new System.Windows.Forms.Label();
            this.dniL = new System.Windows.Forms.Label();
            this.rgCel = new System.Windows.Forms.TextBox();
            this.rgDNI = new System.Windows.Forms.TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.guna2Button1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.guna2Button1.Location = new System.Drawing.Point(49, 433);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(277, 42);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "Register";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(442, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // passL
            // 
            this.passL.AutoSize = true;
            this.passL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.passL.Location = new System.Drawing.Point(32, 215);
            this.passL.Name = "passL";
            this.passL.Size = new System.Drawing.Size(97, 25);
            this.passL.TabIndex = 11;
            this.passL.Text = "Password";
            // 
            // emailL
            // 
            this.emailL.AutoSize = true;
            this.emailL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.emailL.Location = new System.Drawing.Point(32, 154);
            this.emailL.Name = "emailL";
            this.emailL.Size = new System.Drawing.Size(59, 25);
            this.emailL.TabIndex = 10;
            this.emailL.Text = "Email";
            // 
            // rgPassword
            // 
            this.rgPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.rgPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.rgPassword.Location = new System.Drawing.Point(32, 243);
            this.rgPassword.Name = "rgPassword";
            this.rgPassword.Size = new System.Drawing.Size(308, 33);
            this.rgPassword.TabIndex = 8;
            // 
            // rgEmail
            // 
            this.rgEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.rgEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.rgEmail.Location = new System.Drawing.Point(32, 182);
            this.rgEmail.Name = "rgEmail";
            this.rgEmail.Size = new System.Drawing.Size(308, 33);
            this.rgEmail.TabIndex = 7;
            // 
            // usrNameL
            // 
            this.usrNameL.AutoSize = true;
            this.usrNameL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usrNameL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.usrNameL.Location = new System.Drawing.Point(32, 17);
            this.usrNameL.Name = "usrNameL";
            this.usrNameL.Size = new System.Drawing.Size(109, 25);
            this.usrNameL.TabIndex = 15;
            this.usrNameL.Text = "User Name";
            // 
            // rgName
            // 
            this.rgName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.rgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.rgName.Location = new System.Drawing.Point(32, 45);
            this.rgName.Name = "rgName";
            this.rgName.Size = new System.Drawing.Size(308, 33);
            this.rgName.TabIndex = 14;
            // 
            // lstNameL
            // 
            this.lstNameL.AutoSize = true;
            this.lstNameL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lstNameL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.lstNameL.Location = new System.Drawing.Point(32, 85);
            this.lstNameL.Name = "lstNameL";
            this.lstNameL.Size = new System.Drawing.Size(104, 25);
            this.lstNameL.TabIndex = 17;
            this.lstNameL.Text = "Last Name";
            // 
            // rgLastName
            // 
            this.rgLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.rgLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgLastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.rgLastName.Location = new System.Drawing.Point(32, 113);
            this.rgLastName.Name = "rgLastName";
            this.rgLastName.Size = new System.Drawing.Size(308, 33);
            this.rgLastName.TabIndex = 16;
            // 
            // cellL
            // 
            this.cellL.AutoSize = true;
            this.cellL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cellL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.cellL.Location = new System.Drawing.Point(32, 354);
            this.cellL.Name = "cellL";
            this.cellL.Size = new System.Drawing.Size(101, 25);
            this.cellL.TabIndex = 21;
            this.cellL.Text = "Cellphone";
            // 
            // dniL
            // 
            this.dniL.AutoSize = true;
            this.dniL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dniL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.dniL.Location = new System.Drawing.Point(32, 284);
            this.dniL.Name = "dniL";
            this.dniL.Size = new System.Drawing.Size(47, 25);
            this.dniL.TabIndex = 20;
            this.dniL.Text = "DNI";
            // 
            // rgCel
            // 
            this.rgCel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.rgCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgCel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgCel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.rgCel.Location = new System.Drawing.Point(32, 382);
            this.rgCel.Name = "rgCel";
            this.rgCel.Size = new System.Drawing.Size(308, 33);
            this.rgCel.TabIndex = 19;
            // 
            // rgDNI
            // 
            this.rgDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.rgDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgDNI.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rgDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.rgDNI.Location = new System.Drawing.Point(32, 312);
            this.rgDNI.Name = "rgDNI";
            this.rgDNI.Size = new System.Drawing.Size(308, 33);
            this.rgDNI.TabIndex = 18;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.guna2Button2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.guna2Button2.Location = new System.Drawing.Point(726, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(62, 42);
            this.guna2Button2.TabIndex = 22;
            this.guna2Button2.Text = " ➞";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.cellL);
            this.Controls.Add(this.dniL);
            this.Controls.Add(this.rgCel);
            this.Controls.Add(this.rgDNI);
            this.Controls.Add(this.lstNameL);
            this.Controls.Add(this.rgLastName);
            this.Controls.Add(this.usrNameL);
            this.Controls.Add(this.rgName);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passL);
            this.Controls.Add(this.emailL);
            this.Controls.Add(this.rgPassword);
            this.Controls.Add(this.rgEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private PictureBox pictureBox1;
        private Label passL;
        private Label emailL;
        private TextBox passwordtxt;
        private TextBox emailtxt;
        private Label usrNameL;
        private TextBox textBox1;
        private Label lstNameL;
        private TextBox textBox2;
        private Label cellL;
        private Label dniL;
        private TextBox textBox3;
        private TextBox textBox4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private TextBox rgPassword;
        private TextBox rgEmail;
        private TextBox rgName;
        private TextBox rgLastName;
        private TextBox rgCel;
        private TextBox rgDNI;
    }
}