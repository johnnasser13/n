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
    public partial class GaussElimination : Form
    {
        double m21 = 0, m31 = 0, m32 = 0;
        double x1 = 0, x2 = 0, x3 = 0;

        private void txt_x3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x00 = Convert.ToDouble(txt_00.Text);
            double x01 = Convert.ToDouble(txt_01.Text);
            double x02 = Convert.ToDouble(txt_02.Text);
            double x03 = Convert.ToDouble(txt_03.Text);

            double x10 = Convert.ToDouble(txt_10.Text);
            double x11 = Convert.ToDouble(txt_11.Text);
            double x12 = Convert.ToDouble(txt_12.Text);
            double x13 = Convert.ToDouble(txt_13.Text);

            double x20 = Convert.ToDouble(txt_20.Text);
            double x21 = Convert.ToDouble(txt_21.Text);
            double x22 = Convert.ToDouble(txt_22.Text);
            double x23 = Convert.ToDouble(txt_23.Text);

            m21 = x10 / x00;
            m31 = x20 / x00;


            x10 = x10 - (m21 * x00);
            x11 = x11 - (m21 * x01);
            x12 = x12 - (m21 * x02);
            x13 = x13 - (m21 * x03);

            x20 = x20 - (m31 * x00);
            x21 = x21 - (m31 * x01);
            x22 = x22 - (m31 * x02);
            x23 = x23 - (m31 * x03);

            m32 = x21 / x11;

            x20 = x20 - (m32 * x10);
            x21 = x21 - (m32 * x11);
            x22 = x22 - (m32 * x12);
            x23 = x23 - (m32 * x13);

            txt_r00.Text = x00.ToString();
            txt_r01.Text = x01.ToString();
            txt_r02.Text = x02.ToString();
            txt_r03.Text = x03.ToString();

            txt_r10.Text = x10.ToString();
            txt_r11.Text = x11.ToString();
            txt_r12.Text = x12.ToString();
            txt_r13.Text = x13.ToString();

            txt_r20.Text = x20.ToString();
            txt_r21.Text = x21.ToString();
            txt_r22.Text = x22.ToString();
            txt_r23.Text = x23.ToString();

            x3 = x23 / x22;
            x2 = (x13 - (x12 * x3)) / x11;
            x1 = (x03 - (x01 * x2) - (x02 * x3)) / x00;

            txt_x1.Text = x1.ToString();
            txt_x2.Text = x2.ToString();
            txt_x3.Text = x3.ToString();

            txt_m21.Text = m21.ToString();
            txt_m31.Text = m31.ToString();
            txt_m32.Text = m32.ToString();
        }

        public GaussElimination()
        {
            InitializeComponent();
        }

        private void GaussElimination_Load(object sender, EventArgs e)
        {

        }
    }
}
