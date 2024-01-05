using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace WindowsFormsApp2
{
    public partial class Requestitem : Form
    {
        OracleConnection con;
        public Requestitem()
        {
            InitializeComponent();
        }
        private void Requestitem_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=Daira9505;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void returnitem_Click(object sender, EventArgs e)
        {
            returnitem ret = new returnitem();
            this.Hide();
            ret.ShowDialog();
        }

        private void Societyinfo_Click(object sender, EventArgs e)
        {
            societyinfo soc = new societyinfo();
            this.Hide();
            soc.ShowDialog();
        }

        private void Submitrequest_Click(object sender, EventArgs e)
        {
            if (PID.Text.ToString() != "" || guna2TextBox2.Text.ToString() != "" || guna2TextBox4.Text.ToString() != "" || guna2TextBox3.Text.ToString()!="")
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("SELECT PRODUCTID FROM ADDITEM WHERE PRODUCTID Like " + PID.Text + " ", con);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    OracleCommand insertCRUD = con.CreateCommand();
                    insertCRUD.CommandText = "INSERT INTO SOCIETY VALUES(\'" + "Pending" + "\',\'" + PID.Text.ToString() + "\',\'" + guna2TextBox2.Text.ToString() + "\',\'" +
                       guna2TextBox3.Text.ToString() + "\',\'" + guna2TextBox4.Text.ToString() + "\',\'" +"FCAP"+ "\')";
                    insertCRUD.CommandType = CommandType.Text;
                    int rows = insertCRUD.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Submitted ! ! !");
                        societydashboard main1 = new societydashboard();
                        this.Hide();
                        main1.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong ID");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Error! Fill Boxes!");
            }       
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Seeitems show = new Seeitems();
            //to hide current form.
            this.Hide();
            //to show next form.
            show.ShowDialog();
        }

        private void ProdID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void PID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void guna2TextBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
