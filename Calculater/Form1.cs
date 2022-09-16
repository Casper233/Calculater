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
    public partial class CalculaterForm : Form
    {
        public CalculaterForm()
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
            double result;
            string text = txtResult.Text;
            int space = 0;
            space = text.IndexOf(" ");
            if (space >= 0)
            {
                if (space >= 0)
                {
                    string re1 = text.Substring(0, space);
                    char op = Convert.ToChar(text.Substring(space + 1, 1));
                    string re2 = text.Substring(space + 3);
                    string empty = string.Empty;
                    if (re2 == "")
                    {
                        txtResult.Text = txtResult.Text;
                    }
                    else
                    {
                        switch (op)
                        {
                            case '+':
                                result = (double)Convert.ToSingle(re1) + (double)Convert.ToSingle(re2);
                                txtResult.Text = result.ToString();
                                break;
                            case '-':
                                result = (double)Convert.ToSingle(re1) - (double)Convert.ToSingle(re2);
                                txtResult.Text = result.ToString();
                                break;
                            case '*':
                                result = (double)Convert.ToSingle(re1) * (double)Convert.ToSingle(re2);
                                txtResult.Text = result.ToString();
                                break;
                            case '/':
                                if ((double)Convert.ToSingle(re2) == 0)
                                {
                                    MessageBox.Show("除数不可为0   Divisor cannot be 0", "错误E0 Error-E0", MessageBoxButtons.OK);
                                    //throw new ApplicationException();
                                }
                                else
                                {
                                    result = (double)Convert.ToSingle(re1) / (double)Convert.ToSingle(re2);
                                    txtResult.Text = result.ToString();
                                }
                                break;
                            default:
                                throw new ApplicationException("输入表达式错误 FormatException");
                                //MessageBox.Show("除数不可为0", "错误E0", MessageBoxButtons.OK);
                        }
                    }
                }
                else
                {
                    /*if (space == 1)
                    {
                        string re1 = text.Substring(0, space);
                        char op = Convert.ToChar(text.Substring(space + 1, 1));
                        string re2 = text.Substring(space + 3);
                        char op2 = Convert.ToChar(text.Substring(space + 5, 6));
                        string re3 = text.Substring(space + 6);
                        string empty = string.Empty;
                        if (re3 == "")
                        {
                            txtResult.Text = txtResult.Text;
                        }
                        else
                        {
                            int i;
                            for (i = 0; i <= 2; i++)
                            {
                                switch (op)
                                {
                                    case '+':
                                        result = (double)Convert.ToSingle(re1) + (double)Convert.ToSingle(re2);
                                        txtResult.Text = result.ToString();
                                        break;
                                    case '-':
                                        result = (double)Convert.ToSingle(re1) - (double)Convert.ToSingle(re2);
                                        txtResult.Text = result.ToString();
                                        break;
                                    case '*':
                                        result = (double)Convert.ToSingle(re1) * (double)Convert.ToSingle(re2);
                                        txtResult.Text = result.ToString();
                                        break;
                                    case '/':
                                        if ((double)Convert.ToSingle(re2) == 0)
                                        {
                                            MessageBox.Show("除数不可为0   Divisor cannot be 0", "错误E0 Error-E0", MessageBoxButtons.OK);
                                            //throw new ApplicationException();
                                        }
                                        else
                                        {
                                            result = (double)Convert.ToSingle(re1) / (double)Convert.ToSingle(re2);
                                            txtResult.Text = result.ToString();
                                        }
                                        break;
                                    default:
                                        throw new ApplicationException("输入表达式错误 FormatException");
                                        //MessageBox.Show("除数不可为0", "错误E0", MessageBoxButtons.OK);
                                }
                            }
                        }
                    }
                    */
                }    
            }
            else
            {
                txtResult.Text = txtResult.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = " ";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
