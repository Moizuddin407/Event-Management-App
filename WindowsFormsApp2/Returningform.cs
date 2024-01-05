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
    public partial class Returningform : Form
    {
        OracleConnection con;
        public Returningform()
        {
            InitializeComponent();
        }
        private void updateGrid()
        {
            con.Open();
            OracleCommand getEmps = con.CreateCommand();
            getEmps.CommandText = "SELECT PRODUCTID,PRODUCTNAME FROM SOCIETY WHERE STATUS LIKE 'Approved'";
            getEmps.CommandType = CommandType.Text;
            OracleDataReader empDR = getEmps.ExecuteReader();
            DataTable empDT = new DataTable();
            empDT.Load(empDR);
            dataGridView1.DataSource = empDT;
            con.Close();
        }
        private void Done_Click(object sender, EventArgs e)
        {
            returnitem show = new returnitem();
            //to hide current form.
            this.Hide();
            //to show next form.
            show.ShowDialog();
        }

        private void Returningform_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/XE; USER ID=Daira9505;PASSWORD=123";
            con = new OracleConnection(conStr);
            updateGrid();
        }
    }
}
