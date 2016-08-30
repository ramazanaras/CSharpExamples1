using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console11_sesliharfbulma
{
    class Program
    {
        static void Main(string[] args)
        {

            //sesli harf bulma uygulaması
            //1.adım:kullanıcıdan kelime istenmeli ve bu kelime bir değişkende tutulmalı
            Console.Write("Kelime: ");
            string kelime = Console.ReadLine();

            char[] sesliHarfler = {'a','b','e','i','ö','o','u','ü','ı','A','E','İ','I','O','Ü','Ö','U'};
            int sayac = 0;
            foreach (char harf in kelime)//kelimeyi harf harf alıyoruz.
            {
                if (sesliHarfler.Contains(harf))//harf içeriyor mu
                {
                    sayac++;
                    Console.WriteLine(harf);
                }
 
            }
            Console.Write("{0} kelimesinde {1} tane sesli harf vardır", kelime, sayac);
            Console.ReadLine();
        }
    }
}
