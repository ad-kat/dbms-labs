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

namespace Customer
{
    public partial class Form2 : Form
    {
        String id;
        OracleConnection conn;
        OracleConnection comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Form2()
        {
            InitializeComponent();
        }
        public string passingvalue
        {
            get { return id; }
            set { id = value; }
        }
        public void ConnectDB()
        {
            conn = new OracleConnection("DATA SOURCE=DESKTOP-UTCMUMN:1521/xe;USER ID=SYSTEM;PASSWORD=1391192081");
            try
            {
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception e1)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.passingvalue=id;
            frm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbs.aarti_dbms frm1 = new dbs.aarti_dbms();

            frm1.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = id;
            ConnectDB();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "showitemcust"; // Stored procedure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = id; // Add parameter for id

            dt = new DataTable();
            da = new OracleDataAdapter(cmd);
            try
            {
                da.Fill(dt);
            }
            catch (Exception f)
            { }

            dataGridView1.DataSource = dt;


            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dbs.cust_add frm5 = new dbs.cust_add();
            frm5.passingvalue = id;
            frm5.Show();
            this.Hide();
        }
    }
}
