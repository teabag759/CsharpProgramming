using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String op = "";
        double op1 = 0.0;
        double op2 = 0.0;

        bool lastDigitInput = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnDigit_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(op != "" && ! lastDigitInput)
            {
                if (b.Text == "+/-") { }
                else if (b.Text == ".")
                    tbAnswer.Text = "0.";
                else
                    tbAnswer.Text = b.Text;

                lastDigitInput = true;
                return;
            }


            if (b.Text == "+/-")
            {
                if (tbAnswer.Text == "0")
                    return;
                if (tbAnswer.Text.IndexOf("-") < 0 )
                    tbAnswer.Text = "-" + tbAnswer.Text;
                else 
                    tbAnswer.Text = tbAnswer.Text.Substring(1);

                return;
            }

            else if (b.Text == ".")
            {
                if (tbAnswer.Text.IndexOf('.') < 0)
                    tbAnswer.Text += "."; 
            }

            else if (tbAnswer.Text == "0")
                tbAnswer.Text = b.Text;

            else 
                tbAnswer.Text += b.Text;

            lastDigitInput = true;
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == "C")
            { 
                tbAnswer.Text = "0";
                op = "";
                lastDigitInput = false;
                return;
            }

            if (op != "" || b.Text == "=")
            {
                op2 = double.Parse(tbAnswer.Text);
                double ans = op2;
                if (op == "+")
                    ans = op1 + op2;
                else if (op == "-")
                    ans = op1 - op2;
                else if (op == "*")
                    ans = op1 * op2;
                else if (op == "/")
                    ans = op1 / op2;
                tbAnswer.Text = ans.ToString();
            }

            op = b.Text;
            op1 = double.Parse(tbAnswer.Text);
            lastDigitInput = false;
        }
    }
}
