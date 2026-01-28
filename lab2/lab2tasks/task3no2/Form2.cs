using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2.lab2tasks.task3no2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private int Power(int x, int n)
        {
            
            if (n == 0)
                return 1;

           
            return x * Power(x, n - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int baseNum, exponent;

            if (int.TryParse(textBox1.Text, out baseNum) &&
                int.TryParse(textBox2.Text, out exponent) &&
                exponent >= 0)
            {
                int result = Power(baseNum, exponent);
                label3.Text = $"{baseNum}^{exponent} = {result}";
            }
            else
            {
                label3.Text = "Please enter valid integers (exponent must be ≥ 0).";
            }
        }
    }
}
