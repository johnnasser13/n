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
    public partial class Fixed : Form
    {


        public Fixed()
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
        private void Fixed_Load(object sender, EventArgs e)
        {

        }



        private void button5_Click(object sender, EventArgs e)
        {

            double x0 = Convert.ToDouble(xlText.Text);
            FixedSingle(x0);
        }

        double error = 100, xi = 0, Xnew = 0;

        void FixedSingle(double x)
        {
            try
            {
                double iter = 0;
                double x0 = Convert.ToDouble(xlText.Text);
                Xnew = x0;

                double eps = Convert.ToDouble(errorText3.Text);

                string func = funcText3.Text;
                string output = " i   \t   xi   \t   f(xi)   \t   ℰa%";

                if (xlText.Text == "" && errorText3.Text == "")
                {
                    MessageBox.Show("Enter both xl, xu and eps");
                }

                do
                {
                    if (iter != 0)
                    {
                        error = r(Math.Abs((Xnew - xi) / Xnew) * 100);
                        xi = Xnew;
                        Xnew = r(Function(func, xi));
                    }

                    if (iter != 0)
                    {

                        output += $"\n{iter}   \t   {r(xi)}   \t   {r(Function(func, xi))}   \t   {r(error)}%";
                    }
                    iter++;
                    outputText3.Text = output;
                    rootText3.Text = r(Function(func, xi)).ToString();

                } while (error > eps);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void funcText3_TextChanged(object sender, EventArgs e)
        {

        }

        private void xlText_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorText3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
