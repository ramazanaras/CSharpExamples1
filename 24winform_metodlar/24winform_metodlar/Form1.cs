using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24winform_metodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             * Metotlar:
             * içerisine parametre alan,parametre almayan,geriye değer döndüren ve geriye değer döndürmeyen metotlar olarak metotlar birbirinden ayrışır.
             * 
             * 
             * 
             */
            Uyariver();
            Topla(17,25);
            decimal tutar=KdvHesapla(100M);//decimal olarak parametre gönderdik.decimal(100) şeklindede parametre yollayabilirdik.
            MessageBox.Show(tutar.ToString());
            int toplam = Toplama();
            MessageBox.Show(toplam.ToString());
            decimal tutar2=KdvHesapla(100, (decimal)0.20);//0.20M de diyebilirdik decimal anlamına gelir.
            MessageBox.Show(tutar2.ToString());
                decimal tutar3=KdvHesapla(0.30);//double olarak parametre gönderdik.
                MessageBox.Show(tutar3.ToString());
                
            
        }
        //Void kelimesi bu metodun geriye hiçbirşey döndermeyeceği anlamına gelir
        //metodun geriye değer döndürmeyen hali içerisindeki kodlar çalışır sonra biter.
        //İsmi uyarı ver olan parametre almayan geriye değer döndürmeyen metottur
        void Uyariver()
        {
            MessageBox.Show("Uyari");
        }
        //geriye değer döndermeyen ve içine iki tane parametre alan metotdur.
        void Topla(int s1,int s2) {
            int topla = s1 + s2;
        }
        //içerisine bir parametre alan ve geriye decimal tipinde değer döndüren metotdur.
        decimal KdvHesapla(decimal fiyat) {//decimal ondalıklı tiptir(virgüllü) genelde parasal işlemlerde kullanılır.
            decimal tutar = fiyat + (fiyat * 0.18M);//M decimal tipli olduğunu söylüyoruz.yada (decimal)0.18 da yapabiliriz(cast işlemi benzer türler arası dönüşüm).Çünkü başlangıçta 0.18 double tipindedir double tip ile decimal tip birbiri ile çarpılmaz 0.18M yapınca decimal yapmış oluruz

            //metot içerisinde geriye değer dönderme işlemini return komutu yapar.

            return tutar;
        }
        //metot overload yaptık(aynı metottan iki tane tanımladık)
        decimal KdvHesapla(decimal fiyat,decimal kdvOran) {
            decimal tutar = fiyat + (fiyat * kdvOran);
            return tutar;
        }
        decimal KdvHesapla(double kdvOran) {
            decimal tutar = Convert.ToDecimal(200 + (200 * kdvOran));
            return tutar;
        }

        //içerisine parametre almayan ve geriye int tipinde değer döndüren metottur
        int Toplama() {
            return 14 + 28;
        }
        /*metodların imzası vardır.Her metodun imzası bulunur.
        Metodu imzasını içerisine aldığı parametre sayısı ve tipi belirler
         * Aynı isimde metot oluşturmaya izin verilmezken aynı isimli metodun imzası değiştirilirse birden fazla çalışma yapısı kazandırılmış olur.
         * Metodun imzasını yani parametre sayısını ve tipini değiştirerek farklı çalışma yapısı kazandırma işine metot overloadu denir.
         */
        

    }
}
