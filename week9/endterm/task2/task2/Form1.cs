using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        int x, y, r;
        Color color;
        Color[] colors;
        bool clicked;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            x = e.X;
            y = e.Y;

            circles();

           g.Clear(Color.White);

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clicked)
            {
                r = 10;
            }
            
            Random rnd = new Random();
            int random = rnd.Next(0, 4);
            color = colors[random];
            pen = new Pen(color, 3);
            r += 10;
            circles();
            clicked = false;

        }

        public Form1()
        {
            InitializeComponent();
            r = 10;
            color = Color.Black;
            g = CreateGraphics();
            timer1.Start();
            colors = new Color[] { Color.Yellow, Color.Red, Color.Blue, Color.Green };
            pen = new Pen(color, 3);
            clicked = false; 
        }

        public void circles()
        {
            g.DrawEllipse(pen, new Rectangle(x - r, y - r, 2 * r, 2 * r));
        }
    }
}
