using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Frinds_Library : Form
    {
        public Frinds_Library()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void calc_Click(object sender, EventArgs e)
        {
            int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0, total = 0;
            if (buy1.Checked == true)
            {
                sum1 = 20;
            }
            if (buy2.Checked == true)
            {
                sum2 = 25;
            }
            if (buy3.Checked == true) 
            {
                sum3 = 25;
            }
            if (buy4.Checked == true)
            {
                sum4 = 30;
            }
            total = sum1 + sum2 + sum3 + sum4;
            MessageBox.Show("Total Price of your books : " + total);
        }

    }
}
