using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basketbolFinal
{
    public partial class basket : Form
    {
        public basket()
        {
            InitializeComponent();
        }

        Random rnd = new Random();//topun konumu için rastgele sayı üreten Random parametresi.
        int sure = 20; //Oyun süresi
        int toplamtik = 0; //Form üzerine ve topa yapılan tıklama sayısı.
        int isabetlitik = 0; //topa yapılan tıklama sayısı.
        int puan = 0; //Alınan puanın tutulacağı alan.

        private void basket_Load(object sender, EventArgs e)
        {
            pnlstart.Dock = DockStyle.Fill; //Başlangıç paneli form boyutunu alsın
            pnlsonuc.Hide();//Sonuç panelini gizle
            top.Hide();
            lblsure.Hide();
            if (rbtnkolay.Checked == true)
            {
                rbtnorta.Checked = false;
                rbtnzor.Checked=false;
            }
            if (rbtnorta.Checked == true)
            {
                rbtnkolay.Checked=false;
                rbtnzor.Checked = false;
            }
            if(rbtnzor.Checked == true)
            {
                rbtnkolay.Checked = false;
                rbtnorta.Checked = false;
            }
        }



        //Oyunu başlatan buton.
        private void btnstart_Click(object sender, EventArgs e)
        {
            lblsure.Show();
            top.Show();
            pnlstart.Hide(); //Başlangıç panelini gizle

            timersure.Interval = 1000; //timersure_tick fonksiyonu 1 saniyede bir tekrarlanır.
            timersure.Start(); // timer çalışmaya başlar

            timerLoc.Start();//topun rastgele konumlara gitmesini sağlayan timer

            //Oyunun zorluk seviyesinin belirlendiği sorgular.
            //Kullanıcının başlangıç ekranında seçtiği seviyeye göre topun form içerisinde
            //rastgele konumlarda belirme hızını ayarlama
            if (rbtnkolay.Checked == true)
            {
                timerLoc.Interval = 800;//Kolay seviyesindeki timer çalışma hızı.
            }

            if (rbtnorta.Checked == true)
            {
                timerLoc.Interval = 600;//Orta seviyesindeki timer çalışma hızı.
            }

            if (rbtnzor.Checked == true)
            {
                timerLoc.Interval = 450;//Zor seviyesindeki timer çalışma hızı.
            }
        }

        //Geri sayım fonksiyonu
        private void timersure_Tick(object sender, EventArgs e)
        {
            //Label üzerinde kalan zamanı gösterir.
            lblsure.Text = Convert.ToString("Süre : " + sure);

            if (sure == 0) //Süre bittiği zaman gerçekleşen fonksiyonlar.
            {
                timersure.Stop(); //timer'ın çalışması durur.
                timerLoc.Stop(); //timer'ın çalışması durur.

                pnlsonuc.Dock = DockStyle.Fill; //Sonuç paneli form boyutunu alsın
                pnlsonuc.Show(); //Sonuç panelini göster
                top.Hide();
                lblsure.Hide();

                toplamtik += isabetlitik; //forma ve topa yapılan tıklamanın toplamı

                //Sonuç ekradında Toplam tıklama, İsabetli Tıklama ve Puan değişkenlerindeki değerlerin labelda göster
                lbltoplamtik.Text = Convert.ToString("Toplam Tıklama : " + toplamtik);
                lblisabetlitik.Text = Convert.ToString("İsabetli Tıklama : " + isabetlitik);
                lblpuan.Text = Convert.ToString("Puan : " + puan);

            }

            sure--; //her saniye sürenin 1 azalması
        }

        //topun form içerisinde belirlenen değerlere göre rastgele konumlandığı alan.
        private void timerLoc_Tick(object sender, EventArgs e)
        {
            top.Location = new Point(Convert.ToInt32(rnd.Next(10, 600)), //Yatay konum aralığı.
                                     Convert.ToInt32(rnd.Next(10, 250)));  //Dikey konum aralığı.
        }


        //topa tıklandığı zaman gerçekleşecek işlemler.

        private void top_Click(object sender, EventArgs e)
        {
            isabetlitik++; //İsabetli Tıklama 1 artar
            puan += 5; //Puan 5 artar
        }


        //Bu alanda forma yapılan tıklamaların sayısını, toplam tıklama değişkeni içerisine attım
        //Yani isabetsiz yapılan tıklamaların sayısını toplam tıklama değişkeni içerisene ekledim
            //inş murat hoca burayı silmez
        private void basket_MouseClick(object sender, MouseEventArgs e)
        {
            toplamtik++; //Toplam tıklama 1 arttır
        }

        //Oyun tekrardan oynanmak istendiği zaman oyunu yeniden başlatan buton
        //Bu alanda değişkenlere başlangıç değerleri tekrardan atanır
        private void btnrestart_Click(object sender, EventArgs e)
        {
            sure = 20;
            toplamtik = 0;
            isabetlitik = 0;
            puan = 0;

            //Oyun yeniden başlatıldığında son seçilen radio buton yine aynı şekilde seçili geldiği
            //için tekrardan kolay butonunu seçili gelmesini sağlıyorum
            rbtnkolay.Checked = true;
            pnlsonuc.Hide(); //Sonuç panelini gizler
            pnlstart.Show(); //Başlangıç paneli gösterir

            //topun süre bittiğin zaman kaldığın son konumdan kendi belirlediğim başlangıç konumuna getiriyorum
            top.Location = new Point(350, 110);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

