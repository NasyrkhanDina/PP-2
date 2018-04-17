using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {
        Graphics g;

        //public int y;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        Car car = new Car(50,100);

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            car.Move();
            car.Draw(g);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            g.Clear(Color.White);
            car.Draw(g);
            car.Move();
        }
    }
}
