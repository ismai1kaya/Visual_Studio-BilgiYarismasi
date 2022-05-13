using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace BİLGİ_YARISMASI
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

        private void button1_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label4.Text = BtnA.Text;
            if (label3.Text == label4.Text) {
                dogru += 1;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            
            }
            else
            {
                yanlis += 1;

                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label4.Text = BtnC.Text;
            if (label3.Text == label4.Text)
            {
                dogru += 1;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis += 1;

                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;


            label4.Text = BtnD.Text;
            if (label3.Text == label4.Text)
            {
                dogru += 1;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis += 1;

                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblpuan_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbldogru_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        int  soruno = 0 ,dogru = 0, yanlis = 0;
        int sayaç = 11;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            

            label4.Text = BtnB.Text;
            if (label3.Text == label4.Text)
            {
                dogru += 1;
                lblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;


                  
            }
            else
            {
                yanlis += 1;

                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

              
            }


        }

        private void BtnBasla_Click(object sender, EventArgs e)
        {
            

            sayaç -= 1;
            BtnSonraki.Text = "SONRAKİ";

            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //soruno += 1;
            lblSoruNo.Text = soruno.ToString();
            Random rastgele = new Random();
            soruno = rastgele.Next(1, 10);

            if (soruno == 1)
            {

                richTextBox1.Text = ("Aşağıdaki değişken isimlerinden hangisi hatalıdır?");
                BtnA.Text = "ogrenciNo             ";
                BtnB.Text = "OgrenciAd            ";
                BtnC.Text = "ogrenci_soyad       ";
                BtnD.Text = "ogrenci sinif";
                label3.Text = "ogrenci sinif";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Program boyunca sabit kalacak veriyi hangi kelime ile tanımlarız?";
                BtnA.Text = "float                ";
                BtnB.Text = "double          ";
                BtnC.Text = "double          ";
                BtnD.Text = "const";
                label3.Text = "const";

            }
            if (soruno == 3)
            {

                richTextBox1.Text = "Bir metin ifadesini ekrana yazdırmak için hangi metod kullanılır??";
                BtnA.Text = "Console.Write ";
                BtnB.Text = "Readkey( )";
                BtnC.Text = "Readln()";
                BtnD.Text = "Switch()";
                label3.Text = "Console.Write ";


            }
            if (soruno == 4)
            {

                richTextBox1.Text = "Aşağıdaki atama operatörlerinden hangisi doğru kullanılmıştır?";
                BtnA.Text = "a== 5";
                BtnB.Text = "a+- ";
                BtnC.Text = " a++= 2  ";
                BtnD.Text = " a+= 3";
                label3.Text = "a== 5";


            }
            if (soruno == 5)
            {

                richTextBox1.Text = "10 % 3 işleminin sonucu kaçtır?";
                BtnA.Text = "1";
                BtnB.Text = "2";
                BtnC.Text = "3";
                BtnD.Text = "4";
                label3.Text = "1";

            }
            if (soruno == 6)
            {

                richTextBox1.Text = "Aşağıda verilen for döngüsü tanımlamalarından hangisinde döngü sonsuz bir döngüye girer?";
                BtnA.Text = "for(int i=0; i<100; i++)";
                BtnB.Text = "for(int i=0; i<100; i–)";
                BtnC.Text = "for(int i=100; i>0; i–)";
                BtnD.Text = "for(int i=0; i<=100; i=i+5)";
                label3.Text = "for(int i=0; i<100; i–)";

            }
            if (soruno == 7)
            {

                richTextBox1.Text = "Aşağıdaki anahtar sözcüklerden hangisi belirtilen bir komut satırına dallanma için kullanılır?";
                BtnA.Text = "continue                  ";
                BtnB.Text = "goto ";
                BtnC.Text = "break                      ";
                BtnD.Text = "return";
                label3.Text = "goto ";

            }
            if (soruno == 8)
            {

                richTextBox1.Text = "İki metinsel ifadeyi karşılaştırmaya yaran metot aşağıdakilerden hangisidir?";
                BtnA.Text = "Compare( )";
                BtnB.Text = "Copy( ) ";
                BtnC.Text = "Format( )";
                BtnD.Text = "Concat( )  ";
                label3.Text = "Compare( )";

            }
            if (soruno == 9)
            {

                richTextBox1.Text = "Rakamlardan oluşan metinsel bir ifadeyi belirli bir formda yazmak için kullanılan metinsel metot aşağıdakilerden hangisidir?";
                BtnA.Text = "Insert( )  ";
                BtnB.Text = "Concat( )   ";
                BtnC.Text = "IndexOf( )  ";
                BtnD.Text = "Format( )";
                label3.Text = "Format( )";

            }


            if (sayaç == 0) {

                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru sayısı: " + dogru + "\nYanlis sayısı: " + yanlis);
            }
        }
       
    }
}
