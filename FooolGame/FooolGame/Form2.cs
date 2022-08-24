using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FooolGame
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Tag = this;
            form1.Show();
        }
    }
}
            



    

