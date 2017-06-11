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
            labelPlita.Text = (Math.Ceiling(square / 0.36)).ToString();
        }
    }
}
