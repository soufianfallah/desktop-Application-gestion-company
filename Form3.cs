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

namespace gestion_com__App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection cnx = new SqlConnection(@"Data Source=.;Initial Catalog=app;Integrated Security=True");
        SqlCommand cmd;
        int i;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select * from article", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            dataGridView1.Columns.Add("Code article", "Code article");
            dataGridView1.Columns.Add("Disignation", "Disignation");
            dataGridView1.Columns.Add("pu", "pu");
            dataGridView1.Columns.Add("qte", "qte");

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);

            }
            cnx.Close();
        }

        


        

        private void button13_Click(object sender, EventArgs e)
        {
            i = 0;
            cnx.Open();
            cmd = new SqlCommand("select * from article", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                textBox1.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                textBox4.Text = dr[3].ToString();


                i++;
            }
            cnx.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select * from article where codeart > " + textBox1.Text + "", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
            textBox4.Text = dr[3].ToString();




            cnx.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            cnx.Open();
            cmd = new SqlCommand("select * from article where codeart < " + textBox1.Text + "", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
            textBox4.Text = dr[3].ToString();




            cnx.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select * from article ", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();


            textBox1.Text = dr[0].ToString();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
            textBox4.Text = dr[3].ToString();




            cnx.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select codeart from article", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
            }
            cnx.Close();
            dataGridView1.Columns.Add("Code article", "Code article");
            dataGridView1.Columns.Add("Disignation", "Disignation");
            dataGridView1.Columns.Add("pu", "pu");
            dataGridView1.Columns.Add("qte", "qte");
        }
       
        private void button10_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("select * from article where codeart = "+textBox5.Text, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
           

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3]);

            }
            cnx.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            cnx.Open();
            cmd = new SqlCommand("insert into article values (" + textBox1.Text + ",'" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + " )", cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("update article set codeart = " + textBox1.Text + ",disignation = '" + textBox2.Text + "',pu = " + textBox3.Text + " ,qte = " + textBox4.Text + "  where codeci = " + comboBox1.SelectedItem, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            cnx.Open();
            cmd = new SqlCommand("delete from article where codeart = " + comboBox1.SelectedItem, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {

            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 l4 = new Form4();
            l4.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Client f1 = new Client();
            f1.ShowDialog();
        }
    }
}
