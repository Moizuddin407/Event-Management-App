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
    public partial class returnitem : Form
    {
        OracleConnection con;
        public returnitem()
        {
            InitializeComponent();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Requestitem req = new Requestitem();
            this.Hide();
            req.ShowDialog();
        }

        private void Submitrequest_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.ToString() != "" || guna2TextBox2.Text.ToString() != "" || guna2TextBox4.Text.ToString() != "" || guna2TextBox3.Text.ToString() != "")
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("SELECT STATUS, PRODUCTID FROM SOCIETY WHERE PRODUCTID Like " + guna2TextBox1.Text + " ", con);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if(reader[0].ToString() == "Approved")
                    {
                        OracleCommand insertCRUD = con.CreateCommand();
                        insertCRUD.CommandText = "UPDATE SOCIETY SET STATUS='Returned'" ;
                        insertCRUD.CommandType = CommandType.Text;
                        int rows = insertCRUD.ExecuteNonQuery();
                        if(rows>0)
                        {
                            MessageBox.Show("Submitted ! ! !");
                            societydashboard main1 = new societydashboard();
                            this.Hide();
                            main1.ShowDialog();
                        }

                    }
                    else
                    {
                        MessageBox.Show("ID Not Approved Yet.");
                    }
                }
                else
                {
                    MessageBox.Show("ID Doesn't exsists.");
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

        private void returnitem_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=Daira9505;PASSWORD=123";
            con = new OracleConnection(conStr);

        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Returningform show = new Returningform();
            //to hide current form.
            this.Hide();
            //to show next form.
            show.ShowDialog();
        }
    }
}
