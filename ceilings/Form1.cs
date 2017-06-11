using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ceilings
{
    public partial class Ceil_Calc : Form
    {
        int square = 0;
        int perim = 0;
        public Ceil_Calc()
        {
            InitializeComponent();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            square = Convert.ToInt32(tbSquare.Text);
            perim = Convert.ToInt32(tbPerimeter.Text);

            labelPlita.Text = (Math.Ceiling(square / 0.36)).ToString();
            label3_7.Text = (Math.Ceiling(square * 0.25)).ToString();
            label1_2.Text = (Math.Ceiling(square * 1.39)).ToString();
            label0_6.Text = (Math.Ceiling(square * 1.39)).ToString();
            labelAngle.Text = (Math.Ceiling(perim * 0.34)).ToString();
            labelPodves.Text = (Math.Ceiling(square * 0.83)).ToString();
        }
    }
}
