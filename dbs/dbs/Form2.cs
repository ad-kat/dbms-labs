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

        private void sellerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from sellers"; // Stored procedure name
            cmd.CommandType = CommandType.Text;
            dt = new DataTable();
            da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            /*textBox1.Text = string.Empty;
            textBox1.Text = "Seller table";
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "Select * from sellers";
            
            OracleDataReader dr = command.ExecuteReader();
            dr.Read();
            richTextBox1.Text = dr.GetString(0);

            command.Dispose();*/
            conn.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from customers"; // Stored procedure name
            cmd.CommandType = CommandType.Text;
            dt = new DataTable();
            da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            /*textBox1.Text = string.Empty;
            textBox1.Text = "Seller table";
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "Select * from sellers";
            
            OracleDataReader dr = command.ExecuteReader();
            dr.Read();
            richTextBox1.Text = dr.GetString(0);

            command.Dispose();*/
            conn.Close();
        }

        private void shipperDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from shippers"; // Stored procedure name
            cmd.CommandType = CommandType.Text;
            dt = new DataTable();
            da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            /*textBox1.Text = string.Empty;
            textBox1.Text = "Seller table";
            OracleCommand command = conn.CreateCommand();
            command.CommandText = "Select * from sellers";
            
            OracleDataReader dr = command.ExecuteReader();
            dr.Read();
            richTextBox1.Text = dr.GetString(0);

            command.Dispose();*/
            conn.Close();
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

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = id;
        }
    }
}
