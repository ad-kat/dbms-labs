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
        



        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.Location = this.Location;
            frm2.Size = this.Size;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.passingvalue = id;
            frm3.Show();
            frm3.Location = this.Location;
            frm3.Size = this.Size;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbs.aarti_dbms frm1 = new dbs.aarti_dbms();

            frm1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = id;
            ConnectDB();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM ADMINS WHERE AD_ID = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = id;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ADMINS");
                DataTable dt = ds.Tables["ADMINS"];

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    textBox1.Text = dr["ad_name"].ToString();
                   // textBox2.Text = dr["ad_phone"].ToString();
                    textBox3.Text = dr["ad_phone"].ToString();
                    textBox2.Text = dr["ad_email"].ToString();
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
        //    int ph = int.Parse(textBox2.Text);
            cmd.CommandText = "update ADMIN SET AD_NAME=:pa1,AD_PHNO=:pa2, AD_EMAIL=:pa3 WHERE AD_ID=:pab";
            cmd.CommandType = CommandType.Text;
            OracleParameter pa1 = new OracleParameter();
            pa1.OracleDbType = OracleDbType.Varchar2;
            pa1.Size = 10;
            pa1.Value = textBox1.Text;

            OracleParameter pa2 = new OracleParameter();
            pa2.OracleDbType = OracleDbType.Decimal;
            pa2.Value = textBox2.Text;

            OracleParameter pa3 = new OracleParameter();
            pa3.OracleDbType = OracleDbType.Varchar2;
            pa1.Size = 20;
            pa3.Value = textBox3.Text;
           
            OracleParameter pab = new OracleParameter();
            pab.OracleDbType = OracleDbType.Varchar2;
            pab.Size = 10;
            pab.Value = id;
            cmd.Parameters.Add(pa1);
            cmd.Parameters.Add(pa2);
            cmd.Parameters.Add(pa3);
            cmd.Parameters.Add(pab);
            int n = cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
