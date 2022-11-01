namespace byteSharWinForm
{
    partial class Loader
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLoader = new System.Windows.Forms.Panel();
            this.lblLoading2 = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.PBStart = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.panelLoader.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelLoader
            // 
            this.panelLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.panelLoader.Controls.Add(this.lblLoading2);
            this.panelLoader.Controls.Add(this.lblLoading);
            this.panelLoader.Controls.Add(this.PBStart);
            this.panelLoader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoader.Location = new System.Drawing.Point(0, 0);
            this.panelLoader.Name = "panelLoader";
            this.panelLoader.Size = new System.Drawing.Size(353, 305);
            this.panelLoader.TabIndex = 0;
            this.panelLoader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLoader_MouseDown);
            // 
            // lblLoading2
            // 
            this.lblLoading2.AutoSize = true;
            this.lblLoading2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoading2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.lblLoading2.Location = new System.Drawing.Point(122, 78);
            this.lblLoading2.Name = "lblLoading2";
            this.lblLoading2.Size = new System.Drawing.Size(98, 21);
            this.lblLoading2.TabIndex = 2;
            this.lblLoading2.Text = "Please wait";
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.lblLoading.Location = new System.Drawing.Point(95, 39);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(173, 39);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Loading...";
            // 
            // PBStart
            // 
            this.PBStart.FillColor = System.Drawing.Color.White;
            this.PBStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PBStart.ForeColor = System.Drawing.Color.White;
            this.PBStart.Location = new System.Drawing.Point(108, 115);
            this.PBStart.Minimum = 0;
            this.PBStart.Name = "PBStart";
            this.PBStart.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.PBStart.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(255)))), ((int)(((byte)(10)))));
            this.PBStart.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.PBStart.Size = new System.Drawing.Size(133, 133);
            this.PBStart.TabIndex = 0;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 305);
            this.Controls.Add(this.panelLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.Load += new System.EventHandler(this.Loader_Load);
            this.panelLoader.ResumeLayout(false);
            this.panelLoader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panelLoader;
        private Guna.UI2.WinForms.Guna2CircleProgressBar PBStart;
        private Label lblLoading2;
        private Label lblLoading;
    }
}