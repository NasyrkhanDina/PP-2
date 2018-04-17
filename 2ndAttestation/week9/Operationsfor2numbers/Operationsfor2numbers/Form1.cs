using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operationsfor2numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = (sum((int.Parse(textBox1.Text)), (int.Parse(textBox2.Text)))).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result.Text = (minus((int.Parse(textBox1.Text)), (int.Parse(textBox2.Text)))).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result.Text = (multiply((int.Parse(textBox1.Text)), (int.Parse(textBox2.Text)))).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result.Text = (divide((int.Parse(textBox1.Text)), (int.Parse(textBox2.Text)))).ToString();
        }

        public static int sum(int a, int b)
        {
            return a + b;
        }
        public static int minus(int a, int b)
        {
            return a - b;
        }
        public static int multiply(int a, int b)
        {
            return a * b;
        }
        public static int divide(int a, int b)
        {
            return a / b;
        }
    }
}
