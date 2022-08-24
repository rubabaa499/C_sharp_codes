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

namespace TenQCrud
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\TenQCrud\DB\DB.mdf;Integrated Security=True;Connect Timeout=30");



        public Form1()


        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO INFO VALUES ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            disp_data();
            MessageBox.Show("INSERTION SUCCESSFUL.");
        }

        public void disp_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select*from INFO";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
           







        }

        private void button4_Click(object sender, EventArgs e)
        {
            disp_data(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from INFO where NAME = '"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            textBox1.Text = " ";
            
            
            disp_data();
            MessageBox.Show("DELETION SUCCESSFUL.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
