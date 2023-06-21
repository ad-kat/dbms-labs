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
    public partial class Curr_Orders : Form
    {
        String id;
        OracleConnection conn;
        OracleConnection comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Curr_Orders()
        {
            InitializeComponent();
            button3.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Item_det frm1 = new Item_det();
            frm1.passingvalue = id;
            
            frm1.Show();
            frm1.Location = this.Location;
            frm1.Size = this.Size;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seller_details frm2 = new Seller_details();
            frm2.passingvalue = id;
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

        private void Curr_Orders_Load(object sender, EventArgs e)
        {
            label1.Text = id;
            ConnectDB();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "current_orders"; // Stored procedure name
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", OracleDbType.Varchar2).Value = id; // Add parameter for id

            dt = new DataTable();
            da = new OracleDataAdapter(cmd);
            try
            {
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
            catch (Exception f)
            {
            }
            


            conn.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
