using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25winform_runtimecontrolsGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 1;//global değişken
        private void button1_Click(object sender, EventArgs e)
        {
            
            Button btn = new Button();//turquaz renkli(referans tipli new ile oluşturulur.)
            btn.Text = sayac.ToString();//butona herdefasında bir bir numara vercek(1,2,3,4 gibi)

            Random rnd = new Random();
            btn.Width=50;
            btn.Height=30;
            int x = rnd.Next(0, this.ClientSize.Width - btn.Width);//formun genişliği-butonun genişliği(this.ClientSize.Width formun gri kısmının genişliği)
            btn.Left = x;//x koordinatı

            int y = rnd.Next(0,this.ClientSize.Height-btn.Height);
            btn.Top = y;//y koordinatı 

            //runtime(çalışma anında) anında üretilen bi kontrole event atama yöntemi += ile olur.+= yazılır daha sonra iki kez tab tuşuna basılır.(aşağı tarafa btn_click metodu oluşturulur.)
            btn.Click += btn_Click;//aşağıdaki btn_clikci çağır

            //this:bu form anlamına gelir.
            //ekleme işlemi
            this.Controls.Add(btn);//Control tipinin özellikleri buton tipine aktarıldığı(miras verildiği) için biz btn'yi verebiliriz.
            sayac++;

        }

        // //(e değişkeni mouseun sağ,sol ,orta tuşuna tıklandığında oluşan şey.)


        //object sender içerisinde btn_Click metodunu çalıştıran kontrol bulunur.
        void btn_Click(object sender, EventArgs e)//object her türlü tipi barındırdırır.
           
        {
            //sender bu metodu hangi kontrol oluşturmuşsa onu yakalayabiliriz

            //tıklanan butonu yakalama yöntemi
            Button tiklanan = (Button)sender;//cast ettik objeyi Button tipinde yaptık.
            MessageBox.Show(tiklanan.Text);//tıklanan butonun textini aldık

           // this.Controls.Remove(tiklanan);//tıklanan elemanı(butonu) kaldırıyor.
            tiklanan.BringToFront();//tıklanan o kontrolü en üste getirmek(birbirlerinin üstüne geldiğinde)
            //  tiklanan.SendToBack()//tıklanan o kontrolü en arkaya atar.(birbirlerinin üstüne geldiğinde)

           // MessageBox.Show("merhaba ben yeni oluşturulan butonum");
        }

        void ButtonOlustur(int satirsayisi) {
            yavaslat:
            foreach (Control ctrl in this.Controls)//döngüler arasındaki en yavaş döngü foreach'tir
            {
                if (ctrl is Button)//gelen kontrol Button mu
                {
                    this.Controls.Remove(ctrl);//butonu kaldır
                    goto yavaslat;//sıçrama 
                }
                
            }

            //ilk döngü satır için işlem yapacak
            for (int i = 0; i < satirsayisi; i++)
            {
                //ikinci döngü sütun için işlem yapacak
                for (int j = 0; j < 20; j++)
                {
                    Button btn = new Button();//buton oluşturuyoruz
                    btn.Text = string.Format("{0}x{1}", i + 1, j + 1);//butonun üzerindeki ismi

                    btn.Width = 50;
                    btn.Height = 20;
                    btn.Left = j * 50;//butonları yanyana dizmek için (x konumu)
                    btn.Top = (i * 20) + 30;//(y konumu)//yukarıdan +30 daha boşluk bıraktık menünün altından kalmasını önledik butonların

                    // this.Width = btn.Right;//butonların kapladığı yer kadar formuda aynı şekilde kaplamak için
                    this.Controls.Add(btn);//butonların tüm genişliğiyle formun genişliğini aynı şekle getirmek için.
                }
            }
            this.Width = 50 * 20;//formun genişliği
            this.Height = (satirsayisi*20)+80;//formun yüksekliği
        }

        //10x20 ye basıldığında
        private void x20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ButtonOlustur(10);//1o satırlı 
        }

        //20x20 basıldığında
        private void x20ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ButtonOlustur(20);//20 satırlı
        }


    }
}
