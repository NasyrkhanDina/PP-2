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
        SolidBrush balls = new SolidBrush(Color.White);
        SolidBrush stars = new SolidBrush(Color.Red);
        SolidBrush star = new SolidBrush(Color.Green);
        SolidBrush strelka = new SolidBrush(Color.DarkGreen);
        SolidBrush shape = new SolidBrush(Color.Yellow);

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Blue), new Rectangle(0, 0, 840, 535));

            // balls
            e.Graphics.FillEllipse(balls, new Rectangle(20, 40, 27, 27));
            e.Graphics.FillEllipse(balls, new Rectangle(20, 350, 27, 27));
            e.Graphics.FillEllipse(balls, new Rectangle(300, 20, 27, 27));
            e.Graphics.FillEllipse(balls, new Rectangle(300, 320, 27, 27));
            e.Graphics.FillEllipse(balls, new Rectangle(450, 45, 27, 27));
            e.Graphics.FillEllipse(balls, new Rectangle(680, 200, 27, 27));
            e.Graphics.FillEllipse(balls, new Rectangle(750, 420, 27, 27));
            e.Graphics.FillEllipse(balls, new Rectangle(600, 300, 27, 27));

            //stars

            e.Graphics.FillPolygon(stars, new Point[3] { new Point(100, 130), new Point(120, 100), new Point(140, 130) });
            e.Graphics.FillPolygon(stars, new Point[3] { new Point(100, 110), new Point(120, 140), new Point(140, 110) });
            e.Graphics.FillPolygon(stars, new Point[3] { new Point(140, 260), new Point(160, 230), new Point(180, 260) });
            e.Graphics.FillPolygon(stars, new Point[3] { new Point(140, 240), new Point(160, 270), new Point(180, 240) });
            e.Graphics.FillPolygon(stars, new Point[3] { new Point(600, 110), new Point(620, 80), new Point(640, 110) });
            e.Graphics.FillPolygon(stars, new Point[3] { new Point(600, 90), new Point(620, 120), new Point(640, 90) });
            e.Graphics.FillPolygon(stars, new Point[3] { new Point(520, 350), new Point(540, 320), new Point(560, 350) });
            e.Graphics.FillPolygon(stars, new Point[3] { new Point(520, 330), new Point(540, 360), new Point(560, 330) });

            //text window

            e.Graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle(600, 5, 150, 25));
            e.Graphics.DrawRectangle(new Pen(Color.Black, 2), new Rectangle(600, 5, 150, 25));
            e.Graphics.DrawString("Level: 1 Score: 200 Live: ***", new Font (FontFamily.GenericSansSerif,8), new SolidBrush(Color.Black), 605, 7);

            //rec

            e.Graphics.FillRectangle(shape, new Rectangle(370, 200, 90, 40));
            e.Graphics.FillPolygon(shape, new Point[3] { new Point(370, 200), new Point(415, 180), new Point(460, 200) });
            e.Graphics.FillPolygon(shape, new Point[3] { new Point(370, 240), new Point(415, 260), new Point(460, 240) });

            //a gun
            e.Graphics.FillRectangle(star, new Rectangle(410, 220, 10, 20));
            e.Graphics.FillPolygon(star, new Point[3] { new Point(405, 220), new Point(415, 200), new Point(425, 220) });

            // a green star

            e.Graphics.FillPolygon(star, new Point[3] { new Point(412, 144), new Point(415, 130), new Point(418, 144) });
            e.Graphics.FillPolygon(star, new Point[3] { new Point(412, 150), new Point(415, 164), new Point(418, 150) });
            e.Graphics.FillPolygon(star, new Point[3] { new Point(412, 144), new Point(412, 150), new Point(398, 147) });
            e.Graphics.FillPolygon(star, new Point[3] { new Point(418, 144), new Point(418, 150), new Point(432, 147) });






        }
    }
}
