﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Run_Click(object sender, EventArgs e)
        {
            string bb = "2";
            Log.Text += (Calculate.Op("5", "+", "-2") + "\r\n");
            Log.Text += (Calculate.Op("5", "-", "-2") + "\r\n");
            Log.Text += (Calculate.Op("5", "*", "-2") + "\r\n");
            Log.Text += (Calculate.Op("5", "/", "-2") + "\r\n");
        }
    }
}
