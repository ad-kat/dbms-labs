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

namespace dbs
{
    public partial class aarti_dbms : Form
    {
        OracleConnection conn;
        public static aarti_dbms instance;
        OracleConnection comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        String uname, password;
        public aarti_dbms()
        {
            InitializeComponent();
            instance = this;
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

       

        private void aarti_dbms_Load(object sender, EventArgs e)
        {

        }

        private void customer_Click(object sender, EventArgs e)
        {
            ConnectDB(); // Assuming this function establishes the database connection

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM CUSTOMERS WHERE cust_id = :uname AND cust_passcode = :password";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("uname", OracleDbType.Varchar2).Value = uname;
                cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "CUSTOMERS");
                DataTable dt = ds.Tables["CUSTOMERS"];
                int rowCount = dt.Rows.Count;

                if (rowCount >= 1)
                {
                    Customer.Form1 frm = new Customer.Form1();
                    frm.passingvalue = uname;
                    frm.Show();
                    frm.Location = this.Location;
                    frm.Size = this.Size;
                    this.Hide();
                }
                else
                {
                    uname = "";
                    password = "";
                    MessageBox.Show("Invalid Login Details");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error: " + e2.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConnectDB(); // Assuming this function establishes the database connection

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM sellers WHERE SEL_ID = :uname AND sel_passcode = :password";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("uname", OracleDbType.Varchar2).Value = uname;
                cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Sellers");
                DataTable dt = ds.Tables["Sellers"];
                int rowCount = dt.Rows.Count;

                if (rowCount >= 1)
                {
                    Seller.Seller_details frm2 = new Seller.Seller_details();
                    frm2.passingvalue = uname;
                    frm2.Show();
                    frm2.Location = this.Location;
                    frm2.Size = this.Size;
                    this.Hide();
                }
                else
                {
                    uname = "";
                    password = "";
                    MessageBox.Show("Invalid Login Details");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error: " + e2.Message);
            }
            finally
            {
                conn.Close();
            }


            
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectDB(); // Assuming this function establishes the database connection

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM SHIPPERS WHERE ship_id = :uname AND ship_passcode = :password";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("uname", OracleDbType.Varchar2).Value = uname;
                cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Shippers");
                DataTable dt = ds.Tables["Shippers"];
                int rowCount = dt.Rows.Count;

                if (rowCount >= 1)
                {
                    uname = username.Text;
                    Shipper.Form1 frm3 = new Shipper.Form1();
                    frm3.passingvalue = uname;
                    frm3.Show();
                    frm3.Location = this.Location;
                    frm3.Size = this.Size;
                    this.Hide();
                }
                else
                {
                    uname = "";
                    password = "";
                    MessageBox.Show("Invalid Login Details");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error: " + e2.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sign_in.forgotpass frm4 = new Sign_in.forgotpass();
            frm4.Show();
            frm4.Location = this.Location;
            frm4.Size = this.Size;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB(); // Assuming this function establishes the database connection

            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM ADMINS WHERE ad_id = :uname AND ad_passcode = :password";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("uname", OracleDbType.Varchar2).Value = uname;
                cmd.Parameters.Add("password", OracleDbType.Varchar2).Value = password;

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Admins");
                DataTable dt = ds.Tables["Admins"];
               
                if (dt.Rows.Count > 0)
                {
                    uname = username.Text;
                    Admin.Form1 frm5 = new Admin.Form1();
                    frm5.passingvalue = uname;
                    frm5.Show();
                    frm5.Location = this.Location;
                    frm5.Size = this.Size;
                    this.Hide();
                }
                else
                {
                    uname = "";
                    password = "";
                    MessageBox.Show("Invalid Login Details");
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error: " + e2.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            uname = username.Text;
        }

        private void passcode_TextChanged(object sender, EventArgs e)
        {
            password = passcode.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Signup frm6 = new Signup();
            frm6.Show();
            frm6.Location = this.Location;
            frm6.Size = this.Size;
            this.Hide();
        }
    }
}
