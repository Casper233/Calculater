using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text = txtResult.Text + " " + btn.Text + " ";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text = txtResult.Text + " " + btn.Text + " ";
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text = txtResult.Text + " " + btn.Text + " ";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text = txtResult.Text + " " + btn.Text + " ";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Single result;
            string text = txtResult.Text;
            int space = text.IndexOf(" ");
            string re1 = text.Substring(0, space);
            char op = Convert.ToChar(text.Substring(space + 1, 1));
            string re2 = text.Substring(space + 3);
            Single arg1 = Convert.ToSingle(re1);
            Single arg2 = Convert.ToSingle(re2);
            switch (op)
            {
                case '+':
                    result = arg1 + arg2;
                    break;
                case '-':
                    result = arg1 - arg2;
                    break;
                case '*':
                    result = arg1 * arg2;
                    break;
                case '/':
                    if (arg2 == 0)
                    {
                        throw new ApplicationException();
                    }
                    else
                    {
                        result = arg1 / arg2;
                    }
                    break;
                default:
                    throw new ApplicationException();
            }
            txtResult.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = " ";
        }
    }
}
