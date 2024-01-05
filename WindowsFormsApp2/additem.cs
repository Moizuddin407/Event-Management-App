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
    
    public partial class additem : Form
    {
        OracleConnection con;
        public additem()
        {
            InitializeComponent();
        }


        private void additem_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=Daira9505;PASSWORD=123";
            con = new OracleConnection(conStr);
        }

        

        private void Removeitem_Click(object sender, EventArgs e)
        {
            Removeitem remitemm = new Removeitem();
            remitemm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submitrequest_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertCRUD = con.CreateCommand();
            insertCRUD.CommandText = "INSERT INTO ADDITEM VALUES(\'" +
               guna2TextBox1.Text.ToString() + "\',\'" + guna2TextBox2.Text.ToString() + "\',\'" +
               guna2TextBox3.Text.ToString() + "\',\'" + guna2TextBox4.Text.ToString() + "\')";
            insertCRUD.CommandType = CommandType.Text;
            int rows = insertCRUD.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Item Added Succesfully");
                Form2 home = new Form2();
                //to hide current form.
                this.Hide();
                //to show next form.
                home.ShowDialog();
            }
            con.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
