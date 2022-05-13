using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BİLGİ_YARISMASI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void buttonbasla_Click(object sender, EventArgs e)
        {
            sayaç -= 1;
            buttonbasla.Text = "SONRAKİ";

            buttona.Enabled = true;
            buttonb.Enabled = true;
            buttonc.Enabled = true;
            buttond.Enabled = true;
            buttonbasla.Enabled = false;
            pictureBoxFalse.Visible = false;
            pictureboxTrue.Visible = false;

            //soruno += 1;
            labelsoruNo.Text = soruno.ToString();
            Random rastgele = new Random();
            soruno = rastgele.Next(1, 10);



            if (soruno == 1)
            {

                richTextBox1.Text = ("Olimpiyatlar kaç yılda bir yapılıyor?");
                buttona.Text = "2";
                buttonb.Text = "3";
                buttonc.Text = "4";
                buttond.Text = "5";
                label3.Text = "4";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "1971 Olimpiyatları'nda Nadia Comaneci mükemmel bir puan alan ilk jimnastikçiydi. Hangi ülkeyi temsil ediyordu?";
                buttona.Text = "Romanya";
                buttonb.Text = "Slovenya";
                buttonc.Text = "Macaristan";
                buttond.Text = "Avusturya";
                label3.Text = "Romanya";

            }
            if (soruno == 3)
            {

                richTextBox1.Text = "Ortalama bir golf turunda kaç delik oynanır?";
                buttona.Text = "16";
                buttonb.Text = "18";
                buttonc.Text = "20";
                buttond.Text = "22";
                label3.Text = "18";


            }
            if (soruno == 4)
            {

                richTextBox1.Text = "Bir beyzbol takımında kaç oyuncu var";
                buttona.Text = "7";
                buttonb.Text = "8";
                buttonc.Text = "9";
                buttond.Text = "10";
                label3.Text = "9";


            }
            if (soruno == 5)
            {

                richTextBox1.Text = "Hangi yılda kadınların modern olimpiyat oyunlarında tenis spor dalında yarışmalarına izin verildi?";
                buttona.Text = "1960";
                buttonb.Text = "1980";
                buttonc.Text = "1990";
                buttond.Text = "2000";
                label3.Text = "1980";

            }
            if (soruno == 6)
            {

                richTextBox1.Text = "Artık var olmayan ülkelerde kaç tane Olimpiyat oyunu düzenlendi?";
                buttona.Text = "2";
                buttonb.Text = "3";
                buttonc.Text = "4";
                buttond.Text = "5";
                label3.Text = "3";

            }
            if (soruno == 7)
            {

                richTextBox1.Text = "Bir NFL futbolunun ağırlığı nedir?";
                buttona.Text = "1 pound";
                buttonb.Text = "1.5 pound";
                buttonc.Text = "2 pound";
                buttond.Text = "2.5 pound";
                label3.Text = "1 pound";


            }
            if (soruno == 8)
            {

                richTextBox1.Text = "Tek bir futbol oyununda verilen kırmızı kartların rekoru nedir?";
                buttona.Text = "30";
                buttonb.Text = "32";
                buttonc.Text = "34";
                buttond.Text = "36";
                label3.Text = "36";

            }
            if (soruno == 9)
            {

                richTextBox1.Text = "En genç profesyonel futbolcu kaç yaşındaydı?";
                buttona.Text = "12";
                buttonb.Text = "13";
                buttonc.Text = "14";
                buttond.Text = "15";
                label3.Text = "12";

            }


            if (sayaç == 0)
            {

                buttona.Enabled = false;
                buttonb.Enabled = false;
                buttonc.Enabled = false;
                buttond.Enabled = false;
                buttonbasla.Enabled = false;
                MessageBox.Show("Doğru sayısı: " + dogru + "\nYanlis sayısı: " + yanlis);
            }
        }

        private void buttona_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonbasla.Enabled = true;


            label4.Text = buttona.Text;
            if (label3.Text == label4.Text)
            {
                dogru += 1;
                labelDOGRU.Text = dogru.ToString();
                pictureboxTrue.Visible = true;

            }
            else
            {
                yanlis += 1;

                labelYANLIS.Text = yanlis.ToString();
                pictureBoxFalse.Visible = true;

            }

        }
        int soruno = 0, dogru = 0, yanlis = 0;
        int sayaç = 11;


        private void buttonc_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonbasla.Enabled = true;


            label4.Text = buttonc.Text;
            if (label3.Text == label4.Text)
            {
                dogru += 1;
                labelDOGRU.Text = dogru.ToString();
                pictureboxTrue.Visible = true;

            }
            else
            {
                yanlis += 1;

                labelYANLIS.Text = yanlis.ToString();
                pictureBoxFalse.Visible = true;

            }
        }

        private void buttond_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonbasla.Enabled = true;


            label4.Text = buttond.Text;
            if (label3.Text == label4.Text)
            {
                dogru += 1;
                labelDOGRU.Text = dogru.ToString();
                pictureboxTrue.Visible = true;

            }
            else
            {
                yanlis += 1;

                labelYANLIS.Text = yanlis.ToString();
                pictureBoxFalse.Visible = true;

            }
        }

        private void buttonb_Click(object sender, EventArgs e)
        {
            buttona.Enabled = false;
            buttonb.Enabled = false;
            buttonc.Enabled = false;
            buttond.Enabled = false;
            buttonbasla.Enabled = true;


            label4.Text = buttonb.Text;
            if (label3.Text == label4.Text)
            {
                dogru += 1;
                labelDOGRU.Text = dogru.ToString();
                pictureboxTrue.Visible = true;

            }
            else
            {
                yanlis += 1;

                labelYANLIS.Text = yanlis.ToString();
                pictureBoxFalse.Visible = true;

            }

        }
    }
}
