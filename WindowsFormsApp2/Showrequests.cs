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
    public partial class Showrequests : Form
    {
        OracleConnection con;

        public Showrequests()
        {
            InitializeComponent();
        }
        private void Showrequests_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=Daira9505;PASSWORD=123";
            con = new OracleConnection(conStr);
            updateGrid();
        }

        private void Done_Click(object sender, EventArgs e)
        {
            Form2 show = new Form2();
            //to hide current form.
            this.Hide();
            //to show next form.
            show.ShowDialog();
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT * FROM SOCIETY WHERE STATUS = 'Pending'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Approve_Click(object sender, EventArgs e)
        {
            con.Open();
            OracleCommand insertCRUD = con.CreateCommand();
            insertCRUD.CommandText = "UPDATE SOCIETY SET STATUS= 'Approved' WHERE PRODUCTID=" + ID.Text.ToString();
            insertCRUD.CommandType = CommandType.Text;
            int rows = insertCRUD.ExecuteNonQuery();
            if (rows > 0)
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
