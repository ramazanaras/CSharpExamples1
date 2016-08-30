using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console5_switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Karar Yapıları 
             * 
             * 2-Switch case 
             * 
             * Yazılışı: 
             * 
             * switch(koşul){
             * 
             * case 1: şunu yap; break;
             * case 2:şunu yap ;break;
             * 
             * Not:if else yapısından daha yeteneksizdir
             * 
             * 
             * 
             * 
             * 
             * }
             * 
             * 
             * 
             * 
             */

            //kullanıcının girdiği mevsimde bulunan ayları listeleyen uygulamayı yazınız

            Console.Write("Mevsim giriniz:");
            string mevsim = Console.ReadLine();//readline string değer döndürür.

            switch (mevsim)
            {
                case "Yaz": Console.Write("Haziran Temmuz Ağustos"); break;
                case "Kış": Console.Write("Aralık Ocak Şubat"); break;
                case "Sonbahar": Console.Write("Eylül -Ekim -Kasım "); break;
                case "İlkbahar": Console.Write("Mart Nisan Mayıs"); break;

                default: Console.Write("Girilen değer yanlıştır lütfen mevsim giriniz"); break;


            }
            Console.ReadLine();//yazı dursun

        }
    }
}
