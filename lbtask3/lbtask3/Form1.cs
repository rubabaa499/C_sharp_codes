using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;




namespace lbtask3
{
    public partial class Form1 : Form

    {
        string s;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\loginDb\myDB\mydbb\mydbb.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "select * from LOGIN_TBLL where username = '" +textBox1.Text.Trim()+  "' and '"+textBox2.Text.Trim()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            //sda.Fill(dtbl);
             if (dtbl.Rows.Count == 1)
            {
                Form2 form2 = new Form2();
                form2.Tag = this;
                Hide();
                form2.Show();
            }

            else
            {
                MessageBox.Show("Invalid username or password!");
            }



        }





        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}


    

