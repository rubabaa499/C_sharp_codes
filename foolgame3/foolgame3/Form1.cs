﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foolgame3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show();
            Hide();
        }
        int i = 0;
        private void button2_mouseEnter(object sender, EventArgs e)
        {
            Random x = new Random();
            i++;
            Point pt = new Point(

                int.Parse(x.Next(600).ToString()),int.Parse(x.Next(300).ToString())


                );
            button2.Location = pt;
        }
    }
}
