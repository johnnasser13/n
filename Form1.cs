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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bisection bi = new Bisection();
            bi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            False_Position fp = new False_Position();
            fp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fixed fi = new Fixed();
            fi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Newton ne = new Newton();
            ne.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Secant se = new Secant();
            se.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GaussElimination ge = new GaussElimination();
            ge.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LU_Decomposition ld = new LU_Decomposition();
            ld.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CramerRule cr = new CramerRule();
            cr.Show();
        }
    }
}
