using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;

        public int x, y;

        Pen pen;

        GraphicsPath rectangle;

        GraphicsPath game;

        int sizeofrec = 20;

        bool clicked;

        public int i, j;

        Color color, initcolor;



        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            pen = new Pen(Color.Black, 3);
            rectangle = new GraphicsPath();
            game = new GraphicsPath();
            clicked = false;


            for(int i = 10; i <= 200; i += sizeofrec)
            {
                for(int j = 10; j <= 200; j += sizeofrec)
                {
                    rectangle.AddRectangle(new Rectangle( i, j, sizeofrec, sizeofrec));
                    rectangle.AddRectangle(new Rectangle(i + 200, j, sizeofrec, sizeofrec));
                }
            }

            
     

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawPath(pen, rectangle);
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            i = e.X;
            j = e.Y;
            game.AddRectangle(new Rectangle(i, j, 10, 10));

            Button btn = sender as Button;

            if(btn.Name == "btn1")
            {
                g.DrawPath(new Pen(initcolor, 3), game);
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       /* public void Draw()
        {
            g.DrawRectangle(pen, x, y, 20, 20);

        }
        */
    }
}
