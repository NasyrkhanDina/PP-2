using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_sample
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool isOperationPressed = false;
        double memory = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "0")||(isOperationPressed))
            {
                textBox1.Clear();

            }
            isOperationPressed = false;
            Button b = sender as Button;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            operation = btn.Text;
            value = Double.Parse(textBox1.Text);
            isOperationPressed = true;
            //label1.Text = value + " " + operation;
        }   

        private void button18_Click(object sender, EventArgs e)
        {
           // label1.Text = "";
            switch (operation)
            {
                case "+":
                  textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;              
            }

            isOperationPressed = false;
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            value = 0;

        }

        private void one_over_x_Click(object sender, EventArgs e)
        {
            double ovx = Double.Parse(textBox1.Text);
            textBox1.Text = (1 / ovx).ToString();

        }

        private void percentage_Click(object sender, EventArgs e)
        {
            double p = value * (double.Parse(textBox1.Text) / 100);
           // textBox1.Text = (double.Parse(textBox1.Text) + p).ToString();
           textBox1.Text = (value + p).ToString();

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Sqrt(sqrt)).ToString();
        }

        private void ms_Click(object sender, EventArgs e)
        {
            memory = double.Parse(textBox1.Text);

        }

        private void mr_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }
    }
}
