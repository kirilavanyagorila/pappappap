﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace фотки
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox1.Visible = false;
            pictureBox1.Visible = false;
        }
    }
}
