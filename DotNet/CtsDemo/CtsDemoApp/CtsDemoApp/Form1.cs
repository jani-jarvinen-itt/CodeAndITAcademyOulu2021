﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualBasicKirjasto;

namespace CtsDemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Laskin laskin = new Laskin();
            int summa = laskin.Summa(10, 20);
            MessageBox.Show("Summa on: " + summa);
        }
    }
}
