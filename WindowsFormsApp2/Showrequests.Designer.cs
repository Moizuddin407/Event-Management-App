
namespace WindowsFormsApp2
{
    partial class Showrequests
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
            this.Done = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Approve = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Done
            // 
            this.Done.Animated = true;
            this.Done.AutoRoundedCorners = true;
            this.Done.BorderRadius = 17;
            this.Done.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Done.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Done.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Done.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Done.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Done.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Done.ForeColor = System.Drawing.Color.White;
            this.Done.Location = new System.Drawing.Point(676, 494);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(136, 37);
            this.Done.TabIndex = 23;
            this.Done.Text = "Done";
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(320, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Show Requests";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(699, 342);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Approve
            // 
            this.Approve.Animated = true;
            this.Approve.AutoRoundedCorners = true;
            this.Approve.BorderRadius = 17;
            this.Approve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Approve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Approve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Approve.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Approve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Approve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Approve.ForeColor = System.Drawing.Color.White;
            this.Approve.Location = new System.Drawing.Point(161, 494);
            this.Approve.Name = "Approve";
            this.Approve.Size = new System.Drawing.Size(136, 37);
            this.Approve.TabIndex = 24;
            this.Approve.Text = "Approve";
            this.Approve.Click += new System.EventHandler(this.Approve_Click);
            // 
            // ID
            // 
            this.ID.Animated = true;
            this.ID.AutoRoundedCorners = true;
            this.ID.BorderRadius = 23;
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.DefaultText = "";
            this.ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ID.Location = new System.Drawing.Point(123, 424);
            this.ID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ID.Name = "ID";
            this.ID.PasswordChar = '\0';
            this.ID.PlaceholderText = "";
            this.ID.SelectedText = "";
            this.ID.Size = new System.Drawing.Size(229, 48);
            this.ID.TabIndex = 25;
            // 
            // Showrequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(922, 550);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Approve);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Showrequests";
            this.Text = "Showrequests";
            this.Load += new System.EventHandler(this.Showrequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton Done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2GradientButton Approve;
        private Guna.UI2.WinForms.Guna2TextBox ID;
    }
}