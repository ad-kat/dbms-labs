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
    public partial class Form1 : Form
    {
        String id;
        OracleConnection conn;
        OracleConnection comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Form1()
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
            Form2 frm = new Form2();
            frm.passingvalue = id;
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbs.aarti_dbms frm1 = new dbs.aarti_dbms();

            frm1.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = id;
            ConnectDB(); // Assuming this function establishes the database connection

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM SHIPPERS WHERE SHIP_ID = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = id;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "SHIPPERS");
                DataTable dt = ds.Tables["SHIPPERS"];

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    textBox1.Text = dr["ship_name"].ToString();
                    
                    textBox3.Text = dr["ship_email"].ToString();
                    textBox2.Text = dr["ship_city"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update SHIPPERS SET SHIP_NAME=:pa1, SHIP_EMAIL=:pa3, SHIP_CITY=:pa4 WHERE SHIP_ID=:pab";
            cmd.CommandType = CommandType.Text;
            OracleParameter pa1 = new OracleParameter();
            pa1.OracleDbType = OracleDbType.Varchar2;
            pa1.Size = 10;
            pa1.Value = textBox1.Text;

            

            OracleParameter pa3 = new OracleParameter();
            pa3.OracleDbType = OracleDbType.Varchar2;
            pa1.Size = 20;
            pa3.Value = textBox3.Text;
            OracleParameter pa4 = new OracleParameter();
            pa4.OracleDbType = OracleDbType.Varchar2;
            pa4.Size = 10;
            pa4.Value = textBox2.Text;
            OracleParameter pab = new OracleParameter();
            pab.OracleDbType = OracleDbType.Varchar2;
            pab.Size = 10;
            pab.Value = id;
            cmd.Parameters.Add(pa1);
            cmd.Parameters.Add(pa3);
            cmd.Parameters.Add(pa4);
            cmd.Parameters.Add(pab);
            int n = cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
