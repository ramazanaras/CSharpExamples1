using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console9_diziisimornegi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen adet kadar isim girdirilmeli ve girilen isimler arasından arama yapılmalı

            //1.adım:Kullanıcının kaç tane isim giriceği bilgisini almak
            Console.Write("Kaç isim girilecek");
            int adet = Convert.ToInt32(Console.ReadLine());

            //2.adım Girilen adet boyutunda dizi tanımlanmalı
            string[] isimler=new string[adet];

            //3.adım belirtilen adet kadar kullanıcının isim girmesini sağlamak ve girilen isimleri sıra ile diziye atamak
            for (int i = 0; i <isimler.Length; i++)
            {
                Console.Write("{0}.İsmi giriniz: ",i+1);
                isimler[i] = Console.ReadLine();//diziye değerleri atadık.
                 
            }


            //4.adım:Kullanıcıdan liste içerisinde hangi ismi arayacağını sormak ve bu ismi almak.
            Console.Write("Aramak istediğiniz isim:");
            string aranan = Console.ReadLine();

            //5.Adım:
            int sayac = 0;
            for (int i = 0; i <isimler.Length; i++)
            {
                if (isimler[i] == aranan)
                {
                    sayac++;
                }
            }

            //6.adım:Kullanıcıya aramak istediği isimden listede kaç tane olduğu bilgisi verilmeli
            Console.Write("{0} isminden listede {1} tane vardır",aranan,sayac);

            Console.ReadLine();
        }
    }
}
