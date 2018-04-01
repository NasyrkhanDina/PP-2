using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint
{
    public partial class Form1 : Form
    {
        bool clicked;
        Point prev, cur;
        Graphics g;
        Pen pen;
        Bitmap bitmap;

        Tool tool;
        public enum Tool
        {
            PEN,
            RECTANGLE,
            ELLIPSE,
            ERASER
        };

        public Form1()
        {
            InitializeComponent();
            clicked = false;
            tool = Tool.PEN;
           
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            pen = new Pen(Color.Black);
            g.Clear(Color.White);
            pictureBox1.Image = bitmap;
          
        }
      

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            prev = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
          if (clicked && tool == Tool.RECTANGLE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.Y);
                int h = Math.Abs(prev.Y - cur.Y);

                g.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(x, y, w, h));

            }

            if (clicked && tool == Tool.ELLIPSE)
            {
                g.Clear(Color.White);
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.Y);
                int h = Math.Abs(prev.Y - cur.Y);
                g.DrawEllipse(pen, new Rectangle(x, y, w, h));
            }
            pictureBox1.Refresh();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = Tool.PEN;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = Tool.RECTANGLE;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tool = Tool.ELLIPSE;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
                if (clicked && tool == Tool.RECTANGLE)
                {
                    int x = Math.Min(prev.X, cur.X);
                    int y = Math.Min(prev.Y, cur.Y);
                    int w = Math.Abs(prev.X - cur.Y);
                    int h = Math.Abs(prev.Y - cur.Y);

                    e.Graphics.DrawRectangle(pen, x, y, w, h);
                }
            
        }
       

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur = e.Location;
            if(clicked && tool == Tool.PEN)
            {
                g.DrawLine(new Pen(Color.Black, 3), prev, cur);
                prev = cur;
            }
            pictureBox1.Refresh();
        }       
    }
}
