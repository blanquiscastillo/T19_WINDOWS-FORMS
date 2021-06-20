using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        string c;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "1";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "2";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "3";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "4";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "5";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "6";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "7";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "8";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "9";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtpantalla.Text == "")
            {
                txtpantalla.Text = "0";
            }
            else
            {
                txtpantalla.Text = txtpantalla.Text + "0";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "/";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "*";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "-";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.txtpantalla.Text);
            c = "+";
            this.txtpantalla.Clear();
            this.txtpantalla.Focus();
        }

        private void button_igual_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.txtpantalla.Text);
            switch (c)
            {
                case "+":
                    this.txtpantalla.Text = Convert.ToString(a + b);
                    break;

                case "-":
                    this.txtpantalla.Text = Convert.ToString(a - b);
                    break;

                case "*":
                    this.txtpantalla.Text = Convert.ToString(a * b);
                    break;

                case "/":
                    this.txtpantalla.Text = Convert.ToString(a / b);
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            this.txtpantalla.Text = "";
        }
    }
}
