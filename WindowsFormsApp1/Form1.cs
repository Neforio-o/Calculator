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
        Calc C;
        public Form1()
        {
            InitializeComponent();
            C = new Calc();
            result_lbl.Text = "0";
        }

        private void CorrectInfo()
        {
            if (result_lbl.Text.IndexOf("∞") != -1 )
                result_lbl.Text = result_lbl.Text.Substring(0, result_lbl.Text.Length - 1);

            if (result_lbl.Text[0] == '0' && (result_lbl.Text.IndexOf(",") != 1))
                result_lbl.Text = result_lbl.Text.Remove(0, 1);

            if (result_lbl.Text[0] == '-')
                if (result_lbl.Text[1] == '0' && (result_lbl.Text.IndexOf(",") != 2))
                    result_lbl.Text = result_lbl.Text.Remove(1, 1);

        }
        private bool PressInfo()
        {
            if (!Sum.Enabled) return false;
            if (!Division.Enabled) return false;
            if (!Subtracrt.Enabled) return false;
            if (!Multiply.Enabled) return false;
            if (!Pow.Enabled) return false;
            if (!SqrtX.Enabled) return false;

            return true;

        }

        private void FreeInfo()
        {
            Sum.Enabled = true; 
            Division.Enabled = true; 
            Subtracrt.Enabled = true; 
            Multiply.Enabled = true;
            Pow.Enabled = true;
            SqrtX.Enabled = true;
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            result_lbl.Text = "0";
            C.Clear();
            FreeInfo();
        }
        private void smen_Click(object sender, EventArgs e)
        {
            if (result_lbl.Text[0] == '-')
                result_lbl.Text = result_lbl.Text.Remove(0, 1);
            else
                result_lbl.Text = "-" + result_lbl.Text;
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            if ((result_lbl.Text.IndexOf(",") == -1) && (result_lbl.Text.IndexOf("∞") == -1))
                result_lbl.Text += ",";

        }
        private void Calc_Click(object sender, EventArgs e)
        {
            if (!Multiply.Enabled)
                result_lbl.Text = C.Multiply(Convert.ToDouble(result_lbl.Text)).ToString();
            if (!Division.Enabled)
                result_lbl.Text = C.Division(Convert.ToDouble(result_lbl.Text)).ToString();
            if (!Sum.Enabled)
                result_lbl.Text = C.Sum(Convert.ToDouble(result_lbl.Text)).ToString();
            if (!Subtracrt.Enabled)
                result_lbl.Text = C.Subtracrt(Convert.ToDouble(result_lbl.Text)).ToString();
            if (!Pow.Enabled)
                result_lbl.Text = C.Pow(Convert.ToDouble(result_lbl.Text)).ToString();
            if (!SqrtX.Enabled)
                result_lbl.Text = C.SqrtX(Convert.ToDouble(result_lbl.Text)).ToString();

            C.Clear();
            FreeInfo();
        }
        private void Factorial_Click(object sender, EventArgs e)
        {
            if (PressInfo())
            {
                if ((Convert.ToDouble(result_lbl.Text) == (int)(Convert.ToDouble(result_lbl.Text)))
                    && ((Convert.ToDouble(result_lbl.Text) >= 0.0)))
                {
                    C.Save_A(Convert.ToDouble(result_lbl.Text));
                    result_lbl.Text = C.Factorial().ToString();

                    C.Clear();
                    FreeInfo();
                }
                else
                    MessageBox.Show("Nomber for factorial function must be >= 0 and INT type!");
            }
        }
        private void Square_Click(object sender, EventArgs e)
        {
            if (PressInfo())
            {
                C.Save_A(Convert.ToDouble(result_lbl.Text));
                result_lbl.Text = C.Square().ToString();

                C.Clear();
                FreeInfo();
            }
        }
        private void Sqrt_Click(object sender, EventArgs e)
        {
            if (PressInfo())
            {
                C.Save_A(Convert.ToDouble(result_lbl.Text));
                result_lbl.Text = C.Sqrt().ToString();

                C.Clear();
                FreeInfo();
            }
        }
        private void Pow_Click(object sender, EventArgs e)
        {
            if (PressInfo())
            {
                C.Save_A(Convert.ToDouble(result_lbl.Text));
                Pow.Enabled = false;
                result_lbl.Text = "0";
            }
        }
        private void SqrtX_Click(object sender, EventArgs e)
        {
            if (PressInfo())
            {
                C.Save_A(Convert.ToDouble(result_lbl.Text));
                SqrtX.Enabled = false;
                result_lbl.Text = "0";
            }
        }
        private void Sum_Click(object sender, EventArgs e)
        {
            if (PressInfo())
            {
                C.Save_A(Convert.ToDouble(result_lbl.Text));
                Sum.Enabled = false;
                result_lbl.Text = "0";
            }
        }

        private void Subtracrt_Click(object sender, EventArgs e)
        {
            if (PressInfo())
            {
                C.Save_A(Convert.ToDouble(result_lbl.Text));
                Subtracrt.Enabled = false;
                result_lbl.Text = "0";
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            if (PressInfo())
            {
                C.Save_A(Convert.ToDouble(result_lbl.Text));
                Multiply.Enabled = false;
                result_lbl.Text = "0";
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            if (PressInfo())
            {
                C.Save_A(Convert.ToDouble(result_lbl.Text));
                Division.Enabled = false;
                result_lbl.Text = "0";
            }
        }
        private void Get_Num(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            result_lbl.Text += s;
            CorrectInfo();
        }
    }
}