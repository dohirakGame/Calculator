using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Itogo.Text = "0";
        }
        
        
        private double p = 0;
        private double a = 0, b = 0, c = 0;
        private char znak = '+';
        private void buttonZero_Click(object sender, EventArgs e)
        {
            Result.Text += (sender as Button).Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                a = Convert.ToDouble(Result.Text);
            } else
            {
                a = 0;
                }
            znak = (sender as Button).Text[0];
             Result.Clear();
             p = 0;
            
        }

        private void buttonEquelly_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                b = Convert.ToDouble(Result.Text);
            } else
            {
                b = 0;
                }
            switch (znak)
                {
                    case '+':
                        c = a + b;
                        break;
                    case '-':
                        c = a - b;
                        break;
                    case '/':
                        c = a / b;
                        break;
                    case 'X':
                        c = a * b;
                        break;
                }
                Itogo.Text = c.ToString();
                Result.Clear();
              p = 0;
        }

        private void AC_Click(object sender, EventArgs e)
        {
            Result.Clear();
            Itogo.Text = "0";
            p = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
                if (Result.Text[0] == '-')
                    Result.Text = Result.Text.Remove(0, 1);
                else Result.Text = '-' + Result.Text;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
                Result.Text = Result.Text.Remove(Result.Text.Length - 1, 1);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (Result.Text != "")
            {
                a = Convert.ToDouble(Result.Text);
                c = a * a;
                Result.Text = c.ToString();
                p = 0;
                a = 0;
            }
            else return;
        }

        private void buttonCom_Click(object sender, EventArgs e)
        {
            if (p == 0) 
            {
                p++;
                Result.Text += (sender as Button).Text;
            }
            else return;
        }
    }
}