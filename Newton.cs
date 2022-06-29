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
    public partial class Newton : Form
    {
        public Newton()
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

        


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Newton_Load(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && x0Text.Text == "" && err.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Enter both x0, fx ,f'x and eps");
            }
            try
            {
                double x0 = Convert.ToDouble(x0Text.Text);
                newton(x0);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        double error = 100, xi = 0, xiOld = 0;
        void newton(double x)
        {


            try
            {
                double iter = 0;
                double x0 = Convert.ToDouble(x0Text.Text);
                double eps = Convert.ToDouble(err.Text);

                string func = textBox1.Text;
                string fxi = textBox2.Text;
                string output = " i   \t   xi   \t   f(xi)   \t   f'(xi)   \t   ℰa%";

                if (x0Text.Text == "" && textBox1.Text == "" && textBox2.Text == "" && err.Text == "")
                {
                    MessageBox.Show("Enter values");
                }

                do
                {
                    xiOld = xi;
                    if (iter != 0)
                    {
                        xi = xi - Function(func, xi) / Function(fxi, xi);
                        error = r(Math.Abs((xi - xiOld) / xi) * 100);
                    }
                    else
                    {
                        xi = x0;
                    }
                    output += $"\n{iter}   \t   {r(xi)}   \t   {r(Function(func, xi))}   \t   {r(Function(fxi, xi))}   \t   {r(error)}%";

                    iter++;
                    outputText3.Text = output;
                    rootText3.Text = r(xi).ToString();
                } while (error > eps);

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }



        }
           

        
    }

}


