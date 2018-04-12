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

        int x, y, pathx, pathy;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawEllipse(new Pen(Color.Black, 3), new Rectangle(x, y, 20, 20));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (x < 0 || x + 50 >= Width)
            {
                pathx *= -1;
            }

            x += pathx;

            if (y < 0 || y + 50 >= Height)
            {
                pathy *= -1;
            }

            y += pathy;

            Refresh();
          


        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();


        }

        public Form1()
        {
            InitializeComponent();
            x = 150;
            y = 200;
            pathx = 10;
            pathy = 10;
            g = CreateGraphics();

        }
    }
}
