﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace task4
{
    public partial class Form1 : Form
    {
        int tbar;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tbar = trackBar1.Value;
            label1.Font = new Font(FontFamily.GenericSansSerif, a);
        }
    }
}
