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
    public partial class societydashboard : Form
    {
        public societydashboard()
        {
            InitializeComponent();
        }

        private void Societyinfo_Click(object sender, EventArgs e)
        {

        }

        private void returntohomepage_Click(object sender, EventArgs e)
        {
            Form1 main1 = new Form1();
            this.Hide();
            main1.ShowDialog();
        }

        private void requestitem_Click(object sender, EventArgs e)
        {
            Requestitem main1 = new Requestitem();
            this.Hide();
            main1.ShowDialog();
        }

        private void returnitem_Click(object sender, EventArgs e)
        {
            returnitem main1 = new returnitem();
            this.Hide();
            main1.ShowDialog();
        }
    }
}
