using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _32winform_hataayiklamayontemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
        HATA TÜRLERİ
         * 1-DERLEME Hataları(Build Error)
         * 2-Çalışma Zamanı(Runtime Error)
         * 3-Mantıksal Hatalar(Logical Error)
         * 
         * 
         */


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           //çalışma zamanı hatalarını tespit edip yakalamak için try catch yapısı kullanılır
            string sayi1 = textBox1.Text;

            string sayi2 = textBox2.Text;

            try
            {
                int s1 = Convert.ToInt32(sayi1);
                int s2 = Convert.ToInt32(sayi2);
                int toplam = s1 + s2;
                textBox3.Text = toplam.ToString();
            }
            //herhangi bir hata olduğu zaman catch'e düşecek.
            catch (FormatException ex)//sayı yerine harfli sayılı karışık birşeyler girmişse
            {
                //ex.message hatanın açıklamasını verir.
                MessageBox.Show(ex.Message + "Sayı girmelisiniz");
            }

            catch (OverflowException ex)
            {//taşıcak bir sayı girmişse kullanıcı

                MessageBox.Show(ex.Message + "Daha küçük bir sayı giriniz");

            }
                //try bloğu hata versede vermesede finally bloğu çalışır.
            finally 
            {
            
                //try içerisindeki komutlar hata versede vermesede finally bloğu her halükarda çalışır.Örn:Bağlantı kapatılması

            }



        }
        //mantıksal hatalar break point ile çözülür.
        //f10 tuşu ile bir sonraki adıma geçilir.
        //eğer metod var ise f11 ilede metod içerisine girilir.
        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <=100; i++)
            {
                toplam += i;
            }
            hesapla();
            MessageBox.Show(toplam.ToString());
        }
        void hesapla() { 
        
        //asdadas
        }

    }
}
