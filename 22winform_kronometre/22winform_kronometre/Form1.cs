using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22winform_kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //aynı tipte birden fazla değişken tanımlanacaksa aralarına virgül koyarak tanımlabilir.
        int saat = 0, dakika = 0, saniye = 0;//global değişkenler

        private void timer1_Tick(object sender, EventArgs e)//her 1 saniyede bir burası çalışır
        {
            //1000 milisaniye=1sn=Interval özelliği

            saniye++;
            if (saniye>59)
            {
                dakika++;
                if (dakika>59)
                {
                    saat++;
                    //ternary if
                    lblSaat.Text = saat < 10 ? string.Format("0{0}", saat) : saat.ToString();
                    dakika = 0;
                }
                //ternary if
                lblDakika.Text = dakika < 10 ? string.Format("0{0}", dakika) : dakika.ToString();
                saniye = 0;
            }
            //TERNARY İF (tek satırda if yazma işlemidir.)
            lblSaniye.Text = saniye < 10 ?string.Format("0{0}", saniye) : saniye.ToString();//aşağıdaki yerine yapabiliriz daha kısa

            //if (saniye<10)
            //{
            //    lblSaniye.Text = string.Format("0{0}",saniye);//saniyeyi 01,02 şeklinde yapıyoruz.
            //}
            //else
            //{
            //    lblSaniye.Text = saniye.ToString();
            //}
            


        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();//timerı başlat.
        }
    }
}
