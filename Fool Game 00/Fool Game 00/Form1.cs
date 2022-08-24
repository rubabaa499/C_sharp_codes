using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fool_Game_00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Tag = this;
            form2.Show();
            Hide();

        }


        

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                Form3 nextform = new Form3();
                this.Hide();
                nextform.ShowDialog();
                this.Close();


            }





            return base.ProcessCmdKey(ref msg, keyData);
        }










        int i = 0;

        private void button2_mouseEnter(object sender, EventArgs e)
        {
            Random x = new Random();
            i++;
            Point pt = new Point(
                int.Parse(x.Next(750).ToString()),
                int.Parse(x.Next(650).ToString())
                );
            button2.Location = pt;
        }
    }
}
