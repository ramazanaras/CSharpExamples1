using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console5_kararyapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Karar Yapılari
             * 1-if else
             * Yazımı
             * if(koşul){
             * 
             * }else if(koşul){
             * 
             * }else{
             * 
             * }
             * 
             * 
             */
            string kullaniciAdi = "Admin";
            string parola = "123";

            Console.Write("Kullanici Adı: ");
            string ka = Console.ReadLine();
            Console.Write("Parola:");
            string prl = Console.ReadLine();

            if (ka == kullaniciAdi && prl == parola)
            {
                Console.Write("Hoşgeldin {0} ", ka);

            }
            else
            {
                Console.Write("Kullanıcı Adı veya Parola Yanlış");
            }
            Console.Clear();//consolu temizler



            //Giirilen iki sayıdan hangisinin büyük hangisinin küçük olduğunu söyleyen uygulamayı yazınız
            Console.Write("1.sayıyı giriniz");
            int s1 = Convert.ToInt32(Console.ReadLine());// Console.Readline string döndürüyor
            Console.Write("2.sayıyı giriiniz");
            int s2 = Convert.ToInt32(Console.ReadLine());

            if (s1 > s2)
            {
                Console.Write("{0} sayısı {1} sayısından büyüktür", s1, s2);
            }
            else if (s2 > s1)
            {
                Console.Write("{0} sayısı {1} sayısından büyüktür", s2, s1);
            }
            else
            {
                Console.Write("sayılar eşittir");
            }

            Console.ReadLine();


        }
    }
}
