
namespace WindowsFormsApp2
{
    partial class societydashboard
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
            this.returnitem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.returntohomepage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.requestitem = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.returnitem);
            this.panel1.Controls.Add(this.returntohomepage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.requestitem);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(48, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 452);
            this.panel1.TabIndex = 8;
            // 
            // returnitem
            // 
            this.returnitem.Animated = true;
            this.returnitem.AutoRoundedCorners = true;
            this.returnitem.BorderRadius = 25;
            this.returnitem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.returnitem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.returnitem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returnitem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returnitem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.returnitem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.returnitem.ForeColor = System.Drawing.Color.White;
            this.returnitem.Location = new System.Drawing.Point(12, 251);
            this.returnitem.Name = "returnitem";
            this.returnitem.Size = new System.Drawing.Size(136, 53);
            this.returnitem.TabIndex = 16;
            this.returnitem.Text = "Return Item";
            this.returnitem.Click += new System.EventHandler(this.returnitem_Click);
            // 
            // returntohomepage
            // 
            this.returntohomepage.Animated = true;
            this.returntohomepage.AutoRoundedCorners = true;
            this.returntohomepage.BorderRadius = 22;
            this.returntohomepage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.returntohomepage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.returntohomepage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returntohomepage.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.returntohomepage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.returntohomepage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.returntohomepage.ForeColor = System.Drawing.Color.White;
            this.returntohomepage.Location = new System.Drawing.Point(12, 380);
            this.returntohomepage.Name = "returntohomepage";
            this.returntohomepage.Size = new System.Drawing.Size(136, 47);
            this.returntohomepage.TabIndex = 15;
            this.returntohomepage.Text = "Return To Home Page";
            this.returntohomepage.Click += new System.EventHandler(this.returntohomepage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Other Actions";
            // 
            // requestitem
            // 
            this.requestitem.Animated = true;
            this.requestitem.AutoRoundedCorners = true;
            this.requestitem.BorderRadius = 23;
            this.requestitem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.requestitem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.requestitem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.requestitem.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.requestitem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.requestitem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.requestitem.ForeColor = System.Drawing.Color.White;
            this.requestitem.Location = new System.Drawing.Point(12, 171);
            this.requestitem.Name = "requestitem";
            this.requestitem.Size = new System.Drawing.Size(136, 48);
            this.requestitem.TabIndex = 13;
            this.requestitem.Text = "Request Item";
            this.requestitem.Click += new System.EventHandler(this.requestitem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._10__2850_291;
            this.pictureBox1.Location = new System.Drawing.Point(23, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Society Actions";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp2.Properties.Resources.you_;
            this.pictureBox2.Location = new System.Drawing.Point(236, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(532, 439);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // societydashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "societydashboard";
            this.Text = "societydashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton returntohomepage;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2GradientButton requestitem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton returnitem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}