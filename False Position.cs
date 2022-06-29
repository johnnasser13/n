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
    public partial class False_Position : Form
    {
        public False_Position()
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


       

        private void False_Position_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (xlText3.Text == "" && xuText3.Text == "" && errorText3.Text == "")
            {
                MessageBox.Show("Enter both xl, xu and eps");
            }

            try
            {

                double xu = Convert.ToDouble(xuText3.Text);
                double xl = Convert.ToDouble(xlText3.Text);
                double eps = Convert.ToDouble(errorText3.Text);
                string func = funcText3.Text;

                if (Function(func, xl) * Function(func, xu) > 0)
                {
                    MessageBox.Show("The funstion has no solution!");
                }
                else
                {

                    double iter = 0;
                    double xr = 0, xrOld = 0, error = 0;
                    string output = " i   \t   xl   \t   f(xl)   \t   xu   \t   f(xu)   \t   xr   \t   f(xr)   \t   ℰa%";


                    do
                    {
                        xrOld = xr;
                        xr = (xl + xu) / 2;
                        error = Math.Abs((xr - xrOld) / xr) * 100;

                        if (iter == 0)
                        {
                            output += $"\n{iter}   \t   {r(xl)}   \t   {r(Function(func, xl))}   \t   {r(xu)}   \t   {r(Function(func, xu))}   \t   {r(xr)}   \t   {r(Function(func, xr))}   \t---";

                        }
                        else
                        {
                            output += $"\n{iter}   \t   {r(xl)}   \t   {r(Function(func, xl))}   \t   {r(xu)}   \t   {r(Function(func, xu))}   \t   {r(xr)}   \t   {r(Function(func, xr))}   \t   {r(error)}%";
                        }
                        if (Function(func, xl) * Function(func, xr) > 0)
                        {
                            xl = xr;
                        }
                        else
                        {
                            xu = xr;
                        }
                        iter++;



                        rootText3.Text = r(xr).ToString();
                        outputText3.Text = output;

                    } while (error > eps);
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}
