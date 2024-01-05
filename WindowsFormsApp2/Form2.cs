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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            additem additemm = new additem();
            //to hide current form.
            this.Hide();
            //to show next form.
            additemm.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Removeitem_Click(object sender, EventArgs e)
        {
            Removeitem rem = new Removeitem();
            //to hide current form.
            this.Hide();
            //to show next form.
            rem.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Updateitem_Click(object sender, EventArgs e)
        {
            Updateitem upd = new Updateitem();
            //to hide current form.
            this.Hide();
            //to show next form.
            upd.ShowDialog();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Showitems show = new Showitems();
            //to hide current form.
            this.Hide();
            //to show next form.
            show.ShowDialog();
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            Showrequests show = new Showrequests();
            //to hide current form.
            this.Hide();
            //to show next form.
            show.ShowDialog();

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            Form1 main1 = new Form1();
            this.Hide();
            main1.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Showborrowers show = new Showborrowers();
            //to hide current form.
            this.Hide();
            //to show next form.
            show.ShowDialog();
        }
    }
}
