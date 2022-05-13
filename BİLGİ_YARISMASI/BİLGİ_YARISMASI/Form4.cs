using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BİLGİ_YARISMASI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayaç -= 1;
            buttonBASLA.Text = "SONRAKİ";

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonBASLA.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            //soruno += 1;
            labelSoruNo.Text = soruno.ToString();
            Random rastgele = new Random();
            soruno = rastgele.Next(1, 10);



            if (soruno == 1)
            {

                richTextBox1.Text = ("Sinekli Bakkal Romanının Yazarı Aşağıdakilerden Hangisidir?");
                buttonA.Text = "Reşat Nuri Güntekin";
                buttonB.Text = "Halide Edip Adıvar";
                buttonC.Text = "Ziya Gökalp";
                buttonD.Text = "Ömer Seyfettin";
                label4.Text = "Halide Edip Adıvar";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıda Verilen İlk Çağ Uygarlıklarından Hangisi Yazıyı İcat Etmiştir?";
                buttonA.Text = "Hititler ";
                buttonB.Text = "Elamlar";
                buttonC.Text = "Sümerler";
                buttonD.Text = "Urartular";
                label4.Text = "Sümerler";

            }
            if (soruno == 3)
            {

                richTextBox1.Text = " Tsunami Felaketinde En Fazla Zarar Gören Güney Asya Ülkesi Aşağıdakilerden Hangisidir?";
                buttonA.Text = "Endonezya";
                buttonB.Text = "Japonya";
                buttonC.Text = "Hindistan";
                buttonD.Text = "kuzey Kore";
                label4.Text = "Endonezya";


            }
            if (soruno == 4)
            {

                richTextBox1.Text = "Romen Rakamında Hangi Sayı Yoktur?";
                buttonA.Text = "0";
                buttonB.Text = "1";
                buttonC.Text = "50";
                buttonD.Text = "999";
                label4.Text = "0";


            }
            if (soruno == 5)
            {

                richTextBox1.Text = "Hangi İlimizde Demiryolu Yoktur?";
                buttonA.Text = "Kütahya";
                buttonB.Text = "Aydın";
                buttonC.Text = "İzmir";
                buttonD.Text = "Afyon";
                label4.Text = "Aydın";

            }
            if (soruno == 6)
            {

                richTextBox1.Text = "Aşağıdaki Ülkelerden Hangisinin Nüfusu Daha Fazladır?";
                buttonA.Text = "Türkiye";
                buttonB.Text = "İspanya";
                buttonC.Text = "Fransa";
                buttonD.Text = "Almanya";
                label4.Text = "Almanya";

            }
            if (soruno == 7)
            {

                richTextBox1.Text = "Aspirinin Hammaddesi Nedir?";
                buttonA.Text = "Söğüt";
                buttonB.Text = "Kavak";
                buttonC.Text = "Meşe";
                buttonD.Text = "Çam";
                label4.Text = "Söğüt";

            }
            if (soruno == 8)
            {

                richTextBox1.Text = ("Avrupa Birliği'nin başkenti neresidir?");
                buttonA.Text = "Berlin";
                buttonB.Text = "Paris";
                buttonC.Text = "Brüksel";
                buttonD.Text = "Lüksemburg";
                label4.Text = "Brüksel";

            }
            if (soruno == 9)
            {

                richTextBox1.Text = ("İtalya'da bulunan her 100 yılda bir yere 7 cm yaklaşan Pisa Kulesi hangi yöne doğru eğilmektedir?");
                buttonA.Text = "Doğu";
                buttonB.Text = "Batı";
                buttonC.Text = "Kuzey";
                buttonD.Text = "Güney";
                label4.Text = "Güney";

            }
            

            if (sayaç == 0)
            {

                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonBASLA.Enabled = false;
                MessageBox.Show("Doğru sayısı: " + dogru + "\nYanlis sayısı: " + yanlis);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonBASLA.Enabled = true;


            label5.Text = buttonC.Text;
            if (label5.Text == label4.Text)
            {
                dogru += 1;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis += 1;

                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonBASLA.Enabled = true;

            label5.Text = buttonD.Text;
            if (label5.Text == label4.Text)
            {
                dogru += 1;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis += 1;

                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonBASLA.Enabled = true;


            label5.Text = buttonB.Text;
            if (label5.Text == label4.Text)
            {
                dogru += 1;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis += 1;

                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int sayaç = 10;

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonBASLA.Enabled = true;


            label5.Text = buttonA.Text;
            if (label5.Text == label4.Text)
            {
                dogru += 1;
                labelDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis += 1;

                labelYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;

            }
        }

        
    }
}
