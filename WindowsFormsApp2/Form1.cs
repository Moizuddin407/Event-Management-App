using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                ID.PasswordChar = '\0';
            }
            else
            {
                ID.PasswordChar = '*';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Password.Text.ToString() == "admin" && ID.Text.ToString()=="123")
            {
                Form2 dashboard = new Form2();
                this.Hide();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error! ! !");   
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (Password.Text.ToString() == "society" && ID.Text.ToString() == "321")
            {
                societydashboard dashboard2 = new societydashboard();
                this.Hide();
                dashboard2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error ! ! !");
            }
        }

        private void Password_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
