using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİLGİ_YARISMASI
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form2gecis1 = new Form4();
            form2gecis1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2gecis = new Form2();
            form2gecis.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3gecis = new Form3();
            form3gecis.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu kategori gelecek güncellemede aktifleşecek....");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu kategori gelecek güncellemede aktifleşecek....");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu kategori gelecek güncellemede aktifleşecek....");

        }
    }
}
