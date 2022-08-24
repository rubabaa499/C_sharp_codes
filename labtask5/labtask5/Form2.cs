using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labtask5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Form1.text1;
            label3.Text = Form1.text2;
            label4.Text = Form1.text3;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
