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

namespace Admin
{
    public partial class Form3 : Form
    {
        String id;
        OracleConnection conn;
        OracleConnection comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form3()
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



        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.passingvalue = id;
            frm1.Show();
            frm1.Location = this.Location;
            frm1.Size = this.Size;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.Location = this.Location;
            frm2.Size = this.Size;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbs.aarti_dbms frm1 = new dbs.aarti_dbms();

            frm1.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = id;
            ConnectDB();
            OracleCommand cmd = new OracleCommand();



            cmd.Connection = conn;
            cmd.CommandText = "select * from log"; // Stored procedure name
            cmd.CommandType = CommandType.Text;
            dt = new DataTable();
            da = new OracleDataAdapter(cmd);
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
