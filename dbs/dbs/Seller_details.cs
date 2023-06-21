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

namespace Seller
{
    public partial class Seller_details : Form
    {
        String id;
        OracleConnection conn;
        OracleConnection comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Seller_details()
        {
            InitializeComponent();
            
            
             
            button1.BackColor = Color.Transparent;
            //button2.BackColor = Color.Transparent;
            //button3.BackColor = Color.Transparent;
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
            Item_det frm1 = new Item_det();
            frm1.passingvalue = id;
            frm1.Show();
            frm1.Location = this.Location;
            frm1.Size = this.Size;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Curr_Orders frm2 = new Curr_Orders();
            frm2.Show();
            frm2.Location = this.Location;
            frm2.Size = this.Size;
            this.Hide();
        }

        private void Seller_details_Load(object sender, EventArgs e)
        {
            label8.Text = id;
            ConnectDB();
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM SELLERS WHERE SEL_ID = :id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = id;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "SELLERS");
                DataTable dt = ds.Tables["SELLERS"];

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    textBox1.Text = dr["sel_name"].ToString();
                    textBox4.Text = dr["sel_phone"].ToString();
                    textBox3.Text = dr["sel_email"].ToString();
                    textBox2.Text = dr["sel_city"].ToString();
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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbs.aarti_dbms frm1 = new dbs.aarti_dbms();

            frm1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
