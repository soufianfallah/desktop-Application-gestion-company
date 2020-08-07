using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_com__App
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 l4 = new Form4();
            l4.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 l4 = new Form4();
            l4.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }
    }
}
