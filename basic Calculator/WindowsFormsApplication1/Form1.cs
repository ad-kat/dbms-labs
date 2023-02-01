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
    public partial class BASIC_CALCULATOR : Form
    {
        string input = string.Empty; //to read the input when clicked
        string Op1 = string.Empty; //First operand
        string Op2 = string.Empty; //Second operand
        char Operator; //Operator
        double res = 0.0; //Final result
        public BASIC_CALCULATOR()
        {
            InitializeComponent();
        }       

        private void BASIC_CALCULATOR_Load(object sender, EventArgs e)
        {

        }  
               
        private void cmd_1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void cmd_2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "2";
            this.textBox1.Text += input;

        }

        private void cmd_3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }
       
        private void cmd_4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void cmd_5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "5";
            this.textBox1.Text += input;

        }

        private void cmd_6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "6";
            this.textBox1.Text += input;

        }

        private void cmd_7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "7";
            this.textBox1.Text += input;

        }
        private void cmd_8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "8";
            this.textBox1.Text += input;

        }
        private void cmd_9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input = input + "9";
            this.textBox1.Text += input;

        }
         private void cmd_0_Click(object sender, EventArgs e)
        {
             this.textBox1.Text = string.Empty;
            input = input + "0";
            this.textBox1.Text += input;
        
        }

        private void add_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '+';
            input = string.Empty;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '/';
            input = string.Empty;
        }

        private void ans_Click(object sender, EventArgs e)
        {
            Op2 = input;
            double n1, n2;
            if (!Op1.Equals(""))
                double.TryParse(Op1, out n1);
            else n1 = 0.0;
            if (!Op2.Equals(""))
                double.TryParse(Op2, out n2);
            else n2 = 0.0;
            switch (Operator)
            {
                case '+':
                    res = n1 + n2;
                    this.textBox1.Text = res.ToString();
                    break;
                case '-':
                    res = n1 - n2;
                    this.textBox1.Text = res.ToString();
                    break;
                case '*':
                    res = n1 * n2;
                    this.textBox1.Text = res.ToString();
                    break;
                case '/':
                    if (n2 != 0)
                    {
                        res = n1 / n2;
                        this.textBox1.Text = res.ToString();
                    }
                    else this.textBox1.Text = "ERROR";
                    break;
                case '!':
                    res=1;
                    while (n1 != 0)
                    {
                        double d = n1 % 10.0;
                        n1 = n1 / 10.0;
                        res *= d;
                    }
                    this.textBox1.Text = res.ToString();
                    break;
                case '%':
                    res = n1 % n2;
                    this.textBox1.Text = res.ToString();
                    break;
                
                case '^':
                    res = Math.Pow(n1,n2);
                    this.textBox1.Text = res.ToString();
                    break;
                case 'q':
                    res = Math.Pow(n1, (1 / n2));
                    this.textBox1.Text = res.ToString();
                    break;
                case '2':
                    res = Math.Pow(n1,(1/n2));
                    this.textBox1.Text = res.ToString();
                    break;

            }
            input = string.Empty;
                 
        }

        private void clear_Click(object sender, EventArgs e)
        {
            input = string.Empty;
            Op1 = string.Empty;
            Op2 = string.Empty;
            Operator=' ';
            this.textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 't';
            input = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'l';
            input = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'c';
            input = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 's';
            input = string.Empty;
        }

        private void fact_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '!';
            input = string.Empty;
        }

        private void mod_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '%';
            input = string.Empty;
        }

        private void abs_Click(object sender, EventArgs e)
        {
             Op1 = input;
            Operator = '|';
            input = string.Empty;
        }

        private void expo_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '^';
            input = string.Empty;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '2';
            input = string.Empty;
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = 'q';
            input = string.Empty;
        }
    }

       
}
