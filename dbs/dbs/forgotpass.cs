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

namespace Sign_in
{
    public partial class forgotpass : Form
    {
        OracleConnection conn;
        public forgotpass()
        {
            InitializeComponent();
            label4.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            
            label3.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectDB();
            String ID = textBox2.Text;
            String name = textBox1.Text;
            String phno = textBox4.Text;
            String email = textBox3.Text;
            String city = textBox6.Text;
            String type= comboBox1.SelectedText;
            String date = dateTimePicker1.Value.ToShortDateString();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText="insert into log(id,name,phno,email,city,type) values('"+ID+"','"+name+"','"+phno+"','"+email+"','"+city+"', to_date('"+date+"','dd-mm-yyyy'),'"+type+"','forgot password')";
            cmd.CommandType=CommandType.Text;
            cmd.ExecuteNonQuery();
            

            MessageBox.Show("Check inbox in 24-48hrs for login details");
            dbs.aarti_dbms frm1 = new dbs.aarti_dbms();

            frm1.Show();
            this.Hide();
            conn.Close();
            

        }

        private void forgotpass_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
