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
    public partial class LU_Decomposition : Form
    {

        double m21 = 0, m31 = 0, m32 = 0;
        double x1 = 0, x2 = 0, x3 = 0;

        public LU_Decomposition()
        {
            InitializeComponent();
        }

      

        private void LU_Decomposition_Load(object sender, EventArgs e)
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

            double b03 = x03; double b13 = x13; double b23 = x23;

            m21 = x10 / x00;
            m31 = x20 / x00;

            x10 = x10 - (m21 * x00); x11 = x11 - (m21 * x01);
            x12 = x12 - (m21 * x02); x13 = x13 - (m21 * x03);

            x20 = x20 - (m31 * x00); x21 = x21 - (m31 * x01);
            x22 = x22 - (m31 * x02); x23 = x23 - (m31 * x03);

            m32 = x21 / x11;

            x20 = x20 - (m32 * x10); x21 = x21 - (m32 * x11);
            x22 = x22 - (m32 * x12); x23 = x23 - (m32 * x13);

            txt_r00.Text = x00.ToString(); txt_r01.Text = x01.ToString();
            txt_r02.Text = x02.ToString(); txt_r03.Text = x03.ToString();

            txt_r10.Text = x10.ToString(); txt_r11.Text = x11.ToString();
            txt_r12.Text = x12.ToString(); txt_r13.Text = x13.ToString();

            txt_r20.Text = x20.ToString(); txt_r21.Text = x21.ToString();
            txt_r22.Text = x22.ToString(); txt_r23.Text = x23.ToString();

            double u00 = x00; double u01 = x01; double u02 = x02;
            double u10 = x10; double u11 = x11; double u12 = x12;
            double u20 = x20; double u21 = x21; double u22 = x22;

            double l00 = 1; double l01 = 0; double l02 = 0;
            double l10 = m21; double l11 = 1; double l12 = 0;
            double l20 = m31; double l21 = m32; double l22 = 1;

            txt_u00.Text = u00.ToString(); txt_u01.Text = u01.ToString(); txt_u02.Text = u02.ToString();
            txt_u10.Text = u10.ToString(); txt_u11.Text = u11.ToString(); txt_u12.Text = u12.ToString();
            txt_u20.Text = u20.ToString(); txt_u21.Text = u21.ToString(); txt_u22.Text = u22.ToString();

            txt_l00.Text = l00.ToString(); txt_l01.Text = l01.ToString(); txt_l02.Text = l02.ToString();
            txt_l10.Text = l10.ToString(); txt_l11.Text = l11.ToString(); txt_l12.Text = l12.ToString();
            txt_l20.Text = l20.ToString(); txt_l21.Text = l21.ToString(); txt_l22.Text = l22.ToString();

            txt_b03.Text = b03.ToString(); txt_b13.Text = b13.ToString(); txt_b23.Text = b23.ToString();

            txt_ll00.Text = l00.ToString(); txt_ll01.Text = l01.ToString(); txt_ll02.Text = l02.ToString();
            txt_ll10.Text = l10.ToString(); txt_ll11.Text = l11.ToString(); txt_ll12.Text = l12.ToString();
            txt_ll20.Text = l20.ToString(); txt_ll21.Text = l21.ToString(); txt_ll22.Text = l22.ToString();

            txt_bb03.Text = b03.ToString(); txt_bb13.Text = b13.ToString(); txt_bb23.Text = b23.ToString();

            double c1 = b03 / l00;
            double c2 = (b13 - (l10) * c1) / l11;
            double c3 = (b23 - ((l20 * c1) + (l21 * c2))) / l22;

            txt_c1.Text = c1.ToString();
            txt_c2.Text = c2.ToString();
            txt_c3.Text = c3.ToString();

            txt_uu00.Text = u00.ToString(); txt_uu01.Text = u01.ToString(); txt_uu02.Text = u02.ToString();
            txt_uu10.Text = u10.ToString(); txt_uu11.Text = u11.ToString(); txt_uu12.Text = u12.ToString();
            txt_uu20.Text = u20.ToString(); txt_uu21.Text = u21.ToString(); txt_uu22.Text = u22.ToString();

            txt_cc1.Text = c1.ToString();
            txt_cc2.Text = c2.ToString();
            txt_cc3.Text = c3.ToString();

            double x3 = c3 / u22;
            double x2 = (c2 - (u12 * x3)) / u11;
            double x1 = (c1 - (u01 * x2) - (u02 * x3)) / u00;

            txt_x1.Text = x1.ToString();
            txt_x2.Text = x2.ToString();
            txt_x3.Text = x3.ToString();
        }
    }
}
