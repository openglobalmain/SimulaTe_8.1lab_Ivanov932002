using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            double a = 0.6; 
            double p = rand.NextDouble();
            if (p > a)
            {
                txtAnswer.Text = "Yes";
            }
            else
            {
                txtAnswer.Text = "No";
            }
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
