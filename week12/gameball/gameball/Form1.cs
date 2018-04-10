using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameball
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        int x = 150, y = 150, dx = 10, dy = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x + 100 > Width || x < 0)
            {
                dx *= -1;
            }

            x += dx;

            if(y + 100> Height || y < 0)
            {
                dy *= -1;
            }
            y += dy;

            Refresh();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(pen, new Rectangle(x, y, 50, 50));
        }


        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            pen = new Pen(Color.Blue, 3);
        }

    }
}
