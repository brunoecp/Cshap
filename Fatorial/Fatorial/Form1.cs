using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcBT_Click(object sender, EventArgs e)
        {
            int fat = 1;
            for(int i = Convert.ToInt32(numeroTB.Text); i > 0; i--)
            {
                fat *= i;
            }
            fatorialLB.Text = Convert.ToString(fat);
        }

        private void numeroTB_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
