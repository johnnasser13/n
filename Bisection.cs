using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Bisection : Form
    {


        
        public Bisection()
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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bisection_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (xlText.Text == "" && xuText.Text == "" && errorText.Text == "")
            {
                MessageBox.Show("Enter both xl, xu and eps");
            }

            try
            {

                double xu = Convert.ToDouble(xuText.Text);
                double xl = Convert.ToDouble(xlText.Text);
                double eps = Convert.ToDouble(errorText.Text);
                string func = funcText.Text;

                if (Function(func, xl) * Function(func, xu) > 0)
                {
                    MessageBox.Show("The function has no solution!");
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



                        rootText.Text = r(xr).ToString();
                        outputText3.Text = output;

                    } while (error > eps);

                   
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rootText_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
