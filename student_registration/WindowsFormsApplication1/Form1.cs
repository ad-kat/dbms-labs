using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void heading_Click(object sender, EventArgs e)
        {

        }

        private void namebox_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dobbox_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dob_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void calsub_Click(object sender, EventArgs e)
        {
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string rank = rankbox.Text;

            string gen="";
            if (radioButton1.Checked)
                gen = radioButton1.Text;
            else if (radioButton2.Checked)
                gen = radioButton2.Text;
            else if (radioButton3.Checked)
                gen = radioButton3.Text;
            else if (radioButton4.Checked)
                gen = radioButton4.Text;
            else if (radioButton5.Checked)
                gen = radioButton5.Text;

            string s = "";
            if (branches.CheckedItems.Count != 0)
            {

                for (int x = 0; x < branches.CheckedItems.Count; x++)
                {
                    s = s + branches.CheckedItems[x].ToString() + "\n";
                }
            }

            string date = dateTimePicker1.Value.ToString();
            string mail = textBox3.Text;
            string bg = textBox4.Text;
            string ha = textBox5.Text;

            string new2 = ("Name: " + name + "\n\nRank: " + rank + "\nEmail ID:" + mail + "\nBlood Group:" + bg + "\nResidential Address:" + ha + "\n\nBranches opted for: \n" + s + "\n\nDate of Birth: " + date + "\n\nGender: " + gen + "\n").ToString();
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(new2, "Final", buttons);
            this.Hide();
            MessageBox.Show(new2, "Final");
            if (result == DialogResult.OK)
            {
                Form3 frm = new Form3();
                frm.Show();

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
