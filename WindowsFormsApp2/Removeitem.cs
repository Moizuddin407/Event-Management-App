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

    public partial class Removeitem : Form
    {
        OracleConnection con;
        public Removeitem()
        {
            InitializeComponent();
        }

        private void Removeitem_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=Daira9505;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        private void Additem_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Submitrequest_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertCRUD = con.CreateCommand();
            insertCRUD.CommandText = "DELETE FROM ADDITEM WHERE PRODUCTID = " +
               guna2TextBox1.Text.ToString();
            insertCRUD.CommandType = CommandType.Text;
            int rows = insertCRUD.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("You Have Successfully Submitted the Form.");
                Form2 frm = new Form2();
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error ! ! !");
            }
            con.Close();

            
        }
    }
}
