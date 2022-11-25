using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            MessageBox.Show(String.Format("{0} + {1} = {2}", num1, num2, num1 + num2));
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            MessageBox.Show(String.Format("{0} - {1} = {2}", num1, num2, num1 - num2));
        }

        private void buttonMul_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            MessageBox.Show(String.Format("{0} * {1} = {2}", num1, num2, num1 * num2));
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);

            MessageBox.Show((num2 != 0) ?String.Format("{0} / {1} = {2}", num1, num2, num1 / num2):"Can't Divide By Zero");
        }
    }
}
