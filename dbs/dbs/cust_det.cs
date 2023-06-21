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
//using System.Data.OracleClient;

namespace Customer
{
    public partial class Form1 : Form
    {
        String id;
        OracleConnection conn;
        OracleCommand comm;
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            dbs.aarti_dbms frm1 = new dbs.aarti_dbms();

            frm1.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = id;
            ConnectDB(); // Assuming this function establishes the database connection

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM CUSTOMERS WHERE CUST_ID = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = id;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "CUSTOMERS");
                DataTable dt = ds.Tables["CUSTOMERS"];

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    textBox1.Text = dr["cust_name"].ToString();
                    textBox4.Text = dr["cust_phone"].ToString();
                    textBox3.Text = dr["cust_email"].ToString();
                    textBox2.Text = dr["cust_city"].ToString();
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

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            int ph=int.Parse(textBox2.Text);
            cmd.CommandText = "update CUSTOMERS SET CUST_NAME=:pa1,CUST_PHNO=:pa2, CUST_EMAIL=:pa3, CUST_CITY=:pa4 WHERE CUST_ID=:pab";
            cmd.CommandType = CommandType.Text;
            OracleParameter pa1 = new OracleParameter();
            pa1.OracleDbType = OracleDbType.Varchar2;
            pa1.Size = 10;
            pa1.Value = textBox1.Text;

            OracleParameter pa2 = new OracleParameter();
            pa2.OracleDbType = OracleDbType.Decimal;
            pa2.Value = ph;

            OracleParameter pa3 = new OracleParameter();
            pa3.OracleDbType = OracleDbType.Varchar2;
            pa1.Size = 20;
            pa3.Value = textBox3.Text;
            OracleParameter pa4 = new OracleParameter();
            pa4.OracleDbType = OracleDbType.Varchar2;
            pa4.Size = 10;
            pa4.Value = textBox4.Text;
            OracleParameter pab = new OracleParameter();
            pab.OracleDbType = OracleDbType.Varchar2;
            pab.Size = 10;
            pab.Value = id;
            cmd.Parameters.Add(pa1);
            cmd.Parameters.Add(pa2);
            cmd.Parameters.Add(pa3);
            cmd.Parameters.Add(pa4);
            cmd.Parameters.Add(pab);
            int n=cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dbs.cust_add frm5 = new dbs.cust_add();
            frm5.passingvalue=id;
            frm5.Show();
            this.Hide();

        }
    }
}
