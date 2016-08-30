using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console2_veritipleri
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Veri Tipleri
             * 1-Tam sayı tipleri:İçerisinde sadece tam sayı barındıran tiplerdir.
             * 1-1-byte: 
             * -0-255 arasında değer tutar
             * -En küçük tam sayı tipidir.
             * -Ram'de 1 bytelık yer kaplar.
             * 1.2-sbyte:
             * - -128 ile +127 arasında değer tutar.
             * 
             * 1.3 -short:
             * -32768 ile +32767 arasında değer tutar.
             * -Ram'de 2 bytelık yer kaplar.
             * 
             * 1.4 ushort 
             * - 0 ile 65535 arasında değer tutar
             * 
             * 1.5 int:
             * -varsayılan tamsayı tipidir.
             * - -1.14 milyar ile +1.14 milyar arasında değer tutar
             * Ramde 4 bytelık yer kaplar.
             * 
             * 1.6 uint:
             * -0 ile 2.28 milyar arasında değer tutar.
             *  
             * 1.7 long 
             * -tamsayı tiplerinin en büyüğüdür 
             * Ramde 8 bytelık yer kaplar
             * -çok ile +çok arasında yer kaplar.
             * 
             * 1.8 ulong: 
             * 0 ile + çok arasında değer tutar.
             * 
             *  2-ondalıklı veri tipleri 
             *  
             *  2.1-float
             *  -uzunluk ,ölçü birimlerinde kullanılır
                 En küçük ondalıklı tiptir.
             *   
             * 2.2 double 
             * varsayılan ondalıklı tiptir
             * matematiksel işlemlerde kullanılır
             * 2.3 decimal
             * ondalıklı sayıların en büyüğüdür
             * Parasal işlemlerde kullanılır
             * Ramde 16 byte lık yer kaplar.
             * 
             * 3-mantıksal veri tipi
             * 
             * bool:
             * Ramde 1 bitlik yer kaplar.
             * İçerisinde sadece 1 veya 0 barındırır
             * 
             * 4.-metinsel veri tipleri
             * 
             * 4.1 char 
             * içerisinde sadece 1 karakter barındırır 
             * Örnek : 'A' ,'7' ,'?'
             * 
             * 4.2 string: 
             * Bizim ençok kullanacağımız tiptir 
             * İçerisinde metinsel ifadeler barındırır
             * Örnek :  "Deneme"
             * 
             * 5-Object(Nesne)
             * Özel bir tiptir
             * Bütün tipleri içerisinde barındırabilir.
  
             */

            //değişken tanımlama
            byte sayi = 5;
            string metin = "merhaba dünya";
            char karakter = 'A';
            bool mantiksal = true;
            double ondalikli = 14.5;
            object nesne = 4;//nesneye her türlü şey atayabilirsin.
            nesne = "Ahmet";
            nesne = 21.7;
            nesne = false;
            nesne = 7;

            mantiksal =(bool) nesne;//cast işlemi yaptık.



        }
    }
}
