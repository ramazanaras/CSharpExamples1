using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console7_sayitahminoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //sayı tahmin oyunu

            //1.adım :rastgele sayı üretmek
            Random rnd = new Random();//referans tipli değişkenlerdir Ramde bir karşılığı vardır(turkuaz renginde referans tipli değişkenler)
            int tutulan = rnd.Next(10);// 0 ile 10 arasında değer üretir rnd.Next(100,150) 100 ile 150 arasında değer üretir.
            int hak = 5;

            //2.adım:kullanıcının rastgele tutulan sayıyı tahmin edene kadar Console'a sayı girmesini sağlamak
            int girilen = 0;

            do
            {
                if (hak == 0) {
                    Console.Write("Tahmin Hakkınız bitmiştir ");
                }
                else
                {
                    Console.Write("{0}.Tahmini  giriniz :",hak);
                    girilen = Convert.ToInt32(Console.ReadLine());//int ' e convert ettik.
                    if (girilen < tutulan) {
                        Console.WriteLine("Daha büyük bir sayı giriniz");
                    }
                    else if(girilen>tutulan)
                    {
                        Console.WriteLine("Daha küçük bir sayı giriniz");
                    }
                    hak--;
                }
               

            } while (girilen!=tutulan && hak!=0);

            if (girilen != tutulan && hak == 0) {
                Console.Write("Hakkınızı  bitmiştir,Tutulan Sayı {0}",tutulan);
            }
            else
            {
                Console.Write("tebrikler bildiniz");
               

            }
            Console.ReadLine();





        }
    }
}
