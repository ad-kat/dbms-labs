using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace dbs
{
    public partial class Signup : Form
    {

        OracleConnection conn;
        public static aarti_dbms instance;
        OracleConnection comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        public Signup()
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

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            String name = textBox1.Text;
            String phno = textBox4.Text;
            String email = textBox3.Text;
            String city = textBox6.Text;
            String type= comboBox1.SelectedText;
            String date = dateTimePicker1.Value.ToShortDateString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText="insert into log(name,phno,email,city,dob,type,reason) values('"+name+"','"+phno+"','"+email+"','"+city+"', to_date('"+date+"','dd-mm-yyyy'),'"+type+"', 'signup')";
            cmd.CommandType=CommandType.Text;
            int j=cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Check inbox in 24-48hrs for login details");
            dbs.aarti_dbms frm1 = new dbs.aarti_dbms();

            frm1.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
