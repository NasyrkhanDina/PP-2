using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        Tank tank = new Tank(50, 50);

        private void timer1_Tick(object sender, EventArgs e)
        {
            

           g.Clear(Color.White);
         
            tank.Move();

            tank.Draw(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S)
            {
                tank.direction = 1;
            }
            if(e.KeyCode == Keys.D)
            {
                tank.direction = 0;
            }
           // g.Clear(Color.White);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            g.Clear(Color.White);
            tank.Draw(g);
            tank.Move();
        }
    }
}
