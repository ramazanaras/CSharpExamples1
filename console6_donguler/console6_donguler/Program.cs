using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console6_donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Döngüler
             * Belirli kod bloğunu belirli bir koşula göre tekrar tekrar çalıştırmayı sağlayan yapılardır
             * 
             * 4 tane döngü çeşidi vardır
             * 
             * 1-while döngüsü
             * while(){
             * 
             * }
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             */

            int sayi = 100;
            while (sayi >0)
            {
                Console.WriteLine("Merhaba dünya--{0}",sayi);
                sayi--;

            }
            Console.Clear();//console 'u temizler

            int tekToplam = 0, ciftToplam = 0;

            int deger = 0;
            while (deger <100) {

                if (deger%2==0)
                {
                    ciftToplam += deger;
                    
                }
                else
                {
                    tekToplam += deger;
                }
                deger++;
            }
            Console.WriteLine("Çift Sayıların toplamı {0}", ciftToplam);
            Console.Write("Tek sayıların toplamı {0}", tekToplam);


            Console.ReadLine();
        }
    }
}
