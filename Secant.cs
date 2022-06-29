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
    public partial class Secant : Form
    {
        public Secant()
        {
            InitializeComponent();
        }

        double r(double x)
        {
            return Math.Round(x, 3);
        }

        double Function(string func, double x)
        {
            try
            {
                Mathos.Parser.MathParser p = new Mathos.Parser.MathParser();
                return p.Parse(func.Replace(("x"), x.ToString()));
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
                return 0;
            }
        }
        private void Secant_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && errorText5.Text == "")
            {
                MessageBox.Show("Enter both Xi-1, Xi and eps");
            }

            try
            {

                double XiMinus1 = Convert.ToDouble(textBox1.Text);
                double xi = Convert.ToDouble(textBox3.Text);
                double eps = Convert.ToDouble(errorText5.Text);
                string func = textBox2.Text;



                double iter = 0;
                
                double error = 0, XiOld = 0;

                string output = " i   \t   (Xi-1)   \t   f(Xi-1)   \t   xi   \t   f(xi)   \t   ℰa%";


                do
                {
                    XiOld = xi;

                    xi = xi - (Function(func, xi) * (XiMinus1 - xi) / (Function(func, XiMinus1) - Function(func, xi)));

                    
                    error = Math.Abs((xi - XiOld) / xi) * 100;


                    if (iter == 0)
                    {
                        output += $"\n{iter}   \t   {r(XiMinus1)}   \t   {r(Function(func, XiMinus1))}   \t{r(xi)}   \t   {r(Function(func, xi))}   \t---";
                    }
                    if (iter > 0)
                    {
                        output += $"\n{iter++}   \t   {r(XiOld)}   \t   {r(Function(func, XiOld))}   \t   {r(xi)}   \t   {r(Function(func, xi))}   \t   {r(error)}%";

                    }
                    XiMinus1 = XiOld;
                    iter++;



                    rootText.Text = r(xi).ToString();
                    outputText3.Text = output;

                } while (error > eps);


            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }


        }

        private void outputText3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rootText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

