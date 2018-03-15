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
        Double result = 0;
        String operation = "";
        bool isOperationPressed = false;

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
            result = Double.Parse(textBox1.Text);
            isOperationPressed = true;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                  textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
                    break;
                

            }
            isOperationPressed = false;
        }
    }
}
