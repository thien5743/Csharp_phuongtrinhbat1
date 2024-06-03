using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_phuongtrinhbat1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnphuongtrinhbac1_Click(object sender, EventArgs e)
        {
            Double a, b, x;
            a = Convert.ToDouble(txt1.Text);
            b = Convert.ToDouble(txt2.Text);
            if (a!= 0)
            {
                x = -b / a;
                lplkq.Text = "nghiệm của phương trình là x=" + x.ToString();

            }
            else {
                if (b != 0)
                {
                    lplkq.Text = "phương trình vô nghiệm";

                }
                else
                {
                    lplkq.Text = "phương trình nghiệm đúng với mọi x";
                }
            }
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
