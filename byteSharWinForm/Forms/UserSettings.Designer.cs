namespace byteSharWinForm.Forms
{
    partial class UserSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSettings));
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nameL = new System.Windows.Forms.Label();
            this.lastnameL = new System.Windows.Forms.Label();
            this.cellL = new System.Windows.Forms.Label();
            this.applybtn = new Guna.UI2.WinForms.Guna2Button();
            this.mailL = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.BorderRadius = 10;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.SaveBtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.SaveBtn.Location = new System.Drawing.Point(433, 403);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(281, 45);
            this.SaveBtn.TabIndex = 26;
            this.SaveBtn.Text = "save";
            this.SaveBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // nametxt
            // 
            this.nametxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nametxt.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.nametxt.Location = new System.Drawing.Point(375, 62);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(390, 50);
            this.nametxt.TabIndex = 25;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.textBox1.Location = new System.Drawing.Point(375, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(390, 50);
            this.textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.textBox2.Location = new System.Drawing.Point(375, 243);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(390, 50);
            this.textBox2.TabIndex = 28;
            // 
            // nameL
            // 
            this.nameL.AutoSize = true;
            this.nameL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.nameL.Location = new System.Drawing.Point(375, 29);
            this.nameL.Name = "nameL";
            this.nameL.Size = new System.Drawing.Size(53, 21);
            this.nameL.TabIndex = 29;
            this.nameL.Text = "Name";
            // 
            // lastnameL
            // 
            this.lastnameL.AutoSize = true;
            this.lastnameL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastnameL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.lastnameL.Location = new System.Drawing.Point(375, 131);
            this.lastnameL.Name = "lastnameL";
            this.lastnameL.Size = new System.Drawing.Size(82, 21);
            this.lastnameL.TabIndex = 30;
            this.lastnameL.Text = "LastName";
            // 
            // cellL
            // 
            this.cellL.AutoSize = true;
            this.cellL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cellL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.cellL.Location = new System.Drawing.Point(375, 219);
            this.cellL.Name = "cellL";
            this.cellL.Size = new System.Drawing.Size(84, 21);
            this.cellL.TabIndex = 31;
            this.cellL.Text = "Cellphone";
            // 
            // applybtn
            // 
            this.applybtn.BorderRadius = 10;
            this.applybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.applybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.applybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.applybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.applybtn.Enabled = false;
            this.applybtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.applybtn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.applybtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.applybtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.applybtn.Location = new System.Drawing.Point(433, 468);
            this.applybtn.Name = "applybtn";
            this.applybtn.Size = new System.Drawing.Size(281, 45);
            this.applybtn.TabIndex = 32;
            this.applybtn.Text = "apply";
            this.applybtn.Click += new System.EventHandler(this.applybtn_Click);
            // 
            // mailL
            // 
            this.mailL.AutoSize = true;
            this.mailL.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mailL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.mailL.Location = new System.Drawing.Point(375, 304);
            this.mailL.Name = "mailL";
            this.mailL.Size = new System.Drawing.Size(41, 21);
            this.mailL.TabIndex = 34;
            this.mailL.Text = "Mail";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(50)))));
            this.textBox3.Location = new System.Drawing.Point(375, 328);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(390, 50);
            this.textBox3.TabIndex = 33;
            // 
            // UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(44)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1129, 533);
            this.Controls.Add(this.mailL);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.applybtn);
            this.Controls.Add(this.cellL);
            this.Controls.Add(this.lastnameL);
            this.Controls.Add(this.nameL);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.nametxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserSettings";
            this.Text = "UserSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private TextBox nametxt;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label nameL;
        private Label lastnameL;
        private Label cellL;
        private Guna.UI2.WinForms.Guna2Button applybtn;
        private Label mailL;
        private TextBox textBox3;
    }
}