using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

namespace Seller
{
    public partial class Item_det : Form
    {
        String id;
        OracleConnection conn;
        OracleConnection comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        public Item_det()
        {
            InitializeComponent();
            //label1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Curr_Orders frm2 = new Curr_Orders();
            frm2.Show();
            frm2.Location = this.Location;
            frm2.Size = this.Size;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seller_details frm1 = new Seller_details();
            frm1.passingvalue = id;
            frm1.Show();
            frm1.Location = this.Location;
            frm1.Size = this.Size;
            this.Hide();
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

        private void Item_det_Load(object sender, EventArgs e)
        {
            label1.Text = id;
            ConnectDB(); // Assuming this function establishes the database connection

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "showshitemsell"; // Stored procedure name
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
                // Handle the exception appropriately
                MessageBox.Show("Error: " + f.Message);
            }

            conn.Close();

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConnectDB();
            OracleCommand cmd = new OracleCommand();
            string name = textBox1.Text;
            OrderIdGenerator generator = new OrderIdGenerator("I");

            string itemId1 = generator.GenerateOrderId();
            int value = Int32.Parse(textBox2.Text);
            int qty = (int)numericUpDown1.Value;

            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO items (item_id, item_name, item_price, quantity) VALUES (:itemId, :itemName, :itemPrice, :itemQuantity)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new OracleParameter(":itemId", itemId1));
            cmd.Parameters.Add(new OracleParameter(":itemName", name));
            cmd.Parameters.Add(new OracleParameter(":itemPrice", value));
            cmd.Parameters.Add(new OracleParameter(":itemQuantity", qty));


            int j = cmd.ExecuteNonQuery();

            cmd.Dispose();


            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO sells (sel_id, item_id) VALUES (:selId, :itemId)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new OracleParameter(":selId", id));
            cmd.Parameters.Add(new OracleParameter(":itemId", itemId1));


            j = cmd.ExecuteNonQuery();

            cmd.Dispose();

            conn.Close();
        }
    }
    public class OrderIdGenerator
    {
        private int counter;
        private string prefix;
        OracleConnection conn;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
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
        public OrderIdGenerator(string prefix)
{
    this.prefix = prefix;
    ConnectDB();
    OracleCommand cmd = new OracleCommand();
    cmd.CommandText = "SELECT SUBSTR(item_id, 1, 1), MAX(TO_NUMBER(SUBSTR(item_id, 2))) FROM items";
    cmd.CommandType = CommandType.Text;
    cmd.Connection = conn;

    int maxOrderId = 0;
    object result = null;
    try
    {
        result = cmd.ExecuteScalar();
    }
    catch (Exception e)
    {
        // Handle the exception, display an error message, or log the error.
        Console.WriteLine("Error executing query: " + e.Message);
    }

    if (result != null && result != DBNull.Value)
    {
        if (int.Parse(result.ToString())!=0)
        {
            maxOrderId = int.Parse(result.ToString());
        }
        else
        {
            // Handle the case where the result cannot be parsed to an integer.
            Console.WriteLine("Error parsing result to integer.");
        }
    }

    this.counter = maxOrderId;
}

        public string GenerateOrderId()
        {
            counter++;
            return prefix + counter.ToString("D3");
        }
    }
}
