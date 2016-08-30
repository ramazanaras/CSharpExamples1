using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27winform_mayintarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //NOT:flowlayout panel içerisine atılan kontrollerin sıralı biçimde olmasını sağlar.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //kolay sekmesine bastık
        private void kolayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarlaOlustur(10,10);
        }

        void TarlaOlustur(int satir, int sutun)
        {
            flowLayoutPanel1.Controls.Clear();//butonları başlangıçta silelimki zor seçildiğinde veya orta seçildiğinde önceki butonların üzerine ekleme yapmasın.

            int mayin = (satir * sutun) / 10;//mayin sayısı(böler virgülden sonrasını almaz)

            int[] mayinlar = new int[mayin];
            Random rnd = new Random();
            for (int i = 0; i < mayinlar.Length; i++)
            {
                //birbirinden farklı sayılar atıcaz
                int secilen=rnd.Next(0, satir * sutun);
                if (mayinlar.Contains(secilen)==true)//mayinlar dizisi secileni içeriyorsa eklememesi lazım
                {
                    i--;//işlemi tekrarlamak için
                }
                else
                {
                    mayinlar[i] = secilen;//mayinları atamış olduk.
                }
               
            }


            for (int i = 0; i < satir * sutun; i++)//flowlayout kullanacağımız için butonlara btn.left btn.top işlemleri yapmaya gerek zaten flowlayout kendi onu sıralıyor
            {
                Button btn = new Button();
                btn.Width = btn.Height = 30;//butonun genişlik ve  yüksekliği
                btn.BackColor = Color.Green;//başlangıçta mayınları yeşil yaptık.

                //tag özelliği butonların cebi gibidir.içerisinde object tutar istediğimizi atarız sonra çekebiliriz.Bütün kontrollerde tag özelliği vardır.
                if (mayinlar.Contains(i) == true)//mayinlar dizisi i içeriyorsa 
                {
                    btn.Tag = true;//bu buton mayındır
                }
                else
                {
                    btn.Tag = false;// bu buton mayın değildir.
                }
                btn.Click += btn_Click;//aşağıdaki btn_click metodu oluşur.
                btn.Margin = new Padding(5,5,0,0);//margin dış boşluk soldan ve yukarıdan  5 pixel boşluk verdik(butonun toplam genişliği 30+5=35 pixel)
                flowLayoutPanel1.Controls.Add(btn);


            }
            //flowlayoutu bizim girdiğimiz sutun * 35 kadar genişliği yapıcaz
            flowLayoutPanel1.Width = sutun * 35;
            flowLayoutPanel1.Height = satir * 35;

            this.Width = flowLayoutPanel1.Width + 50;//formun genişliği
            this.Height = flowLayoutPanel1.Height + 80;//formun yüksekliği

        }

        //hangi butona tıkladığımızı algılamamız lazım sender la alcaz.
        void btn_Click(object sender, EventArgs e)
        {
            Button tiklanan = (Button)sender;//sender as Button 'da yazabiliriz(buda cast işlemidir.)
            if ((bool)tiklanan.Tag==true)//o zaman bu bir mayındır.//cast işlemi yaptık.(objeyi boola çevirdik.)
            {
                //bütün kontrollerde geziyoruz
                foreach (Control item in flowLayoutPanel1.Controls)//mesela biz bir tane mayın seçersek bütün mayınları bize gösteriyor ve mayınların hepsini kırmızı yapıyor diğelerini yeşil yapıyor.
                {
                    Button btn = item as Button;//gelen control elemanını butona cast edip btn ye attık(şu şekildede yapabilirdik Button btn=(Button)item
                    if ((bool)btn.Tag==true)//mayınsa
                    {
                        btn.BackColor = Color.Red;//mayın kırmızı yaptık
                    }
                    else//mayın değilse
                    {
                        btn.BackColor = Color.Green;
                    }
                    
                }
                MessageBox.Show("Oyun bitti");
                flowLayoutPanel1.Controls.Clear();
            }
            else//eğer mayın değilse
            {
                tiklanan.BackColor = Color.Gray;
            }
        
        }




        //orta sekmesine bastık
        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarlaOlustur(13, 13);
        }
        //zor sekmesine tıkladık
        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TarlaOlustur(16, 16);
        }

    }
}
