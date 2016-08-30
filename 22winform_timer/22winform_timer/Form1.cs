using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22winform_timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sayac = 0;
            //while (true)//sonsuza kadar sürecek.(sonsuz döngü)
            //{
            //    sayac++;
            //    label1.Text = sayac.ToString();
            //    Application.DoEvents();//bunu yazmasaydık form donardı.
            //}

            //int sayac = 0;//local değişken
            //while (true)//sonsuza kadar sürecek.(sonsuz döngü)
            //{
            //    sayac++;
            //    label1.Text = sayac.ToString();
            //    Application.DoEvents();
            //    Thread.Sleep(1000);//1 snde bir çalıştırır(işlemi uyutuyoruz.)
            //}



            timer1.Enabled = true;//timer'ı başlatıyoruz.

            
        }

        int sayac = 0;//global değişken(altta yada üstte yazmamızın farkı yok üstteki metodlardada kullanibiliriz.)
        private void timer1_Tick(object sender, EventArgs e)
        {
            // İnterval=1000 verdiysek her 1 saniyede bir timer1_tick eventi çalışır.

            sayac++;
            label1.Text = sayac.ToString();
        }


    }
}
