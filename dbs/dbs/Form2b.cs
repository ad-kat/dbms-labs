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

namespace Shipper
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
        int i = 0;
        public Form2()
        {
            InitializeComponent();
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
        public string passingvalue
        {
            get { return id; }
            set { id = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.passingvalue = id;
            frm1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.passingvalue = id;
            frm3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbs.aarti_dbms frm1 = new dbs.aarti_dbms();

            frm1.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = id;
            ConnectDB();
            try
            {
                OracleCommand cmd = new OracleCommand();



                cmd.Connection = conn;
                cmd.CommandText = "showitemsell"; // Stored procedure name
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = id; // Add parameter for id

                dt = new DataTable();
                da = new OracleDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception f)
            {

            }
            conn.Close();
        }
    }
}
