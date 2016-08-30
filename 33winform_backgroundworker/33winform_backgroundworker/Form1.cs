using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33winform_backgroundworker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //bir kontole birden fazla iş parçaçığının erişimini engellemek için
            CheckForIllegalCrossThreadCalls = false;//çapraz threadlerin çalışmasını engelle(çapraz iş parçaçığı hatasını önler)
        }

        //thread:iş parçaçığı
        //NOT:senkron:eş zamanlı
        //asenkron:eş zamansız:yeni bir thread yolundan(işlem parçacığından) başka bir işlem yaptırabiliriz.

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int sayac1 = 0, sayac2 = 0;//global değişken
        private void button1_Click(object sender, EventArgs e)
        {
            //while (sayac1 < 100000)
            //{
            //    sayac1++;
            //    label1.Text = sayac1.ToString();
            //    Application.DoEvents();
            //}

            if (backgroundWorker1.IsBusy==false)//false ise yani çalışmıyorsa(meşgul değilse çalıştır)
            {
                backgroundWorker1.RunWorkerAsync();//asenkron olarak backgroundWorker1 çalışır.
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {//durdurma işlemi
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.CancelAsync();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //while (sayac2<100000)
            //{
            //    sayac2++;//while döngüsü o threadi çok yoğun olduğu için labele yazamıyor çünkü tekbir thread kullanılıyor.label  o threadi kullanamıyor çünkü çok yoğun o yüzde application.doevents kullandık.
            //    label2.Text = sayac2.ToString();
            //    Application.DoEvents();//başka bir işlem varsa bekle diğer işlemi yap.sonra devam et
            //}


            if (backgroundWorker2.IsBusy == false)//false ise yani çalışmıyorsa
            {
                backgroundWorker2.RunWorkerAsync();//asenkron olarak backgroundWorker1 çalışır.
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker2.CancelAsync();
           
        }

        //NOT: //backgroundWorker1:işlemci ve uygulama arasındaki threadden farklı olarak kendisi bir thread açar ve ordan devam eder

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac1 < 100000)
            {
                sayac1++;
                label1.Text = sayac1.ToString();
                if (backgroundWorker1.CancellationPending)//eğer true ise
                {
                    e.Cancel = true;
                    return;//metodu sonlandırır
                }
            }


        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            while (sayac2 < 100000)
            {
                sayac2++;
                label2.Text = sayac1.ToString();
                if (backgroundWorker2.CancellationPending)//eğer true ise
                {
                    e.Cancel = true;
                    return;//metodu sonlandırır
                }
            }
        }
    }
}
