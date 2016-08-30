using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23winform_atyarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            AtDurumDegistir(true);
            timer1.Start();//timerı başlatıtık.
        }

        private void timer1_Tick(object sender, EventArgs e)//verdiğimiz interval suresince sürekli başlayacak.
        {
            //atların rastgele pozisyonlarını değiştiriyoruz
            Random rnd = new Random();
            atYagiz.Left += rnd.Next(1,5);//1 ile 25 arasında 25 dahil değil rastgele sayı
            atRuzgarGulu.Left += rnd.Next(1,5);
            atGolgeYele.Left += rnd.Next(1, 5);
            atPoyraz.Left += rnd.Next(1, 5);
            atAlver.Left += rnd.Next(1, 5);


            KimKazandi(atYagiz);
            KimKazandi(atRuzgarGulu);
            KimKazandi(atGolgeYele);
            KimKazandi(atPoyraz);
            KimKazandi(atAlver);



        }

        //kim kazandı fonksyionu
        void KimKazandi(PictureBox kazanan) {
            //finish çizgisine gelip gelmediğine bakıcaz.
            if (kazanan.Right - 10 >= label1.Left)//atın sağ kısmı labelin sol kısmından büyükse
            {
                timer1.Stop();
                AtDurumDegistir(false, kazanan);
                MessageBox.Show(kazanan.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtDurumDegistir(false);
        }


        //metodu overload yaptık (yani iki çeşit metod yaptık.)
        void AtDurumDegistir(bool durum,PictureBox at)//2 parametreli
        { //bool tipinde parametre alır
            //durum=false atlar durur true ise atlar hareket halinde olur.
            atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled = atRuzgarGulu.Enabled = atYagiz.Enabled = durum;
            at.Enabled = true;//gelen atın durumunu enabled yap yani hareketli olsun
        }
        void AtDurumDegistir(bool durum)//1 parametreli
        { //bool tipinde parametre alır
            //durum=false atlar durur true ise atlar hareket halinde olur.
            atAlver.Enabled = atGolgeYele.Enabled = atPoyraz.Enabled = atRuzgarGulu.Enabled = atYagiz.Enabled = durum;
            
        }
    }
}
