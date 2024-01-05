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
    public partial class Updateitem : Form
    {
        OracleConnection con;
        public Updateitem()
        {
            InitializeComponent();
        }
        private void Updateitem_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=Daira9505;PASSWORD=123";
            con = new OracleConnection(conStr);

        }

        private void Submitrequest_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertCRUD = con.CreateCommand();
            insertCRUD.CommandText = "UPDATE ADDITEM SET PRODUCTNAME='" + guna2TextBox2.Text.ToString() + "', CATEGORY='" + guna2TextBox3.Text.ToString() + "', QUANTITY=" + guna2TextBox4.Text.ToString() + " WHERE PRODUCTID=" + guna2TextBox1.Text.ToString();
            insertCRUD.CommandType = CommandType.Text;
            int rows = insertCRUD.ExecuteNonQuery();
            if (rows >0)
            { 
            MessageBox.Show("Succesfully Updated");
            Form2 upd = new Form2();
            //to hide current form.
            this.Hide();
                //to show next form.
                upd.ShowDialog();
            }
        }

    }
}
