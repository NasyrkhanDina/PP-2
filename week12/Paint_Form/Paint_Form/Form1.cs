using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Form
{
    public partial class Form1 : Form
    {
        Queue<Point> q = new Queue<Point>();
        Bitmap bmp;
        Color fillcolor, color;
        Graphics g;
        bool clicked;
        Point prev, cur;

        public enum Tool
        {
            PEN,
            CIRCLE,
            RECTANGLE,
            FILL,
        };

        Tool tool = Tool.PEN;


        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            fillcolor = Color.Blue;
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            clicked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if (clicked && tool == Tool.PEN)
            {
                g.DrawLine(new Pen(Color.Black), prev.X, prev.Y, cur.X, cur.Y);
                pictureBox1.Refresh();
                prev = cur;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            if(clicked && tool == Tool.RECTANGLE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);

                g.DrawRectangle(new Pen(Color.Black, 3), new Rectangle(x, y, w, h));
                pictureBox1.Refresh();
            }

            if (clicked && tool == Tool.CIRCLE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);

                g.DrawEllipse(new Pen(Color.Red, 3), new Rectangle(x, y, w, h));
                pictureBox1.Refresh();
            }

            clicked = false;
           

        }

        private void penchik_Click(object sender, EventArgs e)
        {
            tool = Tool.PEN;
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            tool = Tool.FILL;
        }

        private void rectanglechik_Click(object sender, EventArgs e)
        {
            tool = Tool.RECTANGLE;
        }

        private void circlechik_Click(object sender, EventArgs e)
        {
            tool = Tool.CIRCLE;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (clicked && tool == Tool.RECTANGLE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);

                e.Graphics.DrawRectangle(new Pen(Color.Black, 3), new Rectangle(x, y, w, h));
            }

            if (clicked && tool == Tool.CIRCLE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);

                e.Graphics.DrawEllipse(new Pen(Color.Red, 3), new Rectangle(x, y, w, h));
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
            if(tool == Tool.FILL)
            {
                color = bmp.GetPixel(e.X, e.Y);
                q.Enqueue(new Point(e.X, e.Y));
                bmp.SetPixel(e.X, e.Y, fillcolor);

                while(q.Count > 0)
                {
                    Point cur = q.Dequeue();
                    FillCheck(cur.X + 1, cur.Y);
                    FillCheck(cur.X - 1, cur.Y);
                    FillCheck(cur.X, cur.Y + 1);
                    FillCheck(cur.X, cur.Y - 1);
                }
                pictureBox1.Refresh();

            }

        }
        
        public void FillCheck(int x, int y)
        {
            if (x < 0 || y < 0 || x >= pictureBox1.Width || y >= pictureBox1.Height)
                return;
            if (bmp.GetPixel(x,y) == color)
            {
                bmp.SetPixel(x, y, fillcolor);
                q.Enqueue(new Point(x, y));

            }
        }
    }
}
