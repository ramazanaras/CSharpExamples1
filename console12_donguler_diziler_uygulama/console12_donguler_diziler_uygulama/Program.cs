using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console12_donguler_diziler_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
             /*
              1-10 elemanlı bir diziyi her sayıdan bir tane bulunmak koşuluyla rastgele sayılarla dolduran ve bu sayıları ekrana yazan uygulamayı yazın
              */

            //1.adım:10 elemanlı bir dizi oluşturulur.
            int[] sayilar = new int[10];
            
            //2.adım:Rastgele sayılarla doldurmak için rastgele sayı üreten bir değişken tanımlamak
            Random rnd = new Random();
         

            //3.adım diziyi her sayıdan bir tane bulunmak koşulu ile rastgele sayılarla doldurmak

            int sayac = 0;   //int tanımlanan değişkene başlangıçta 0 atanır.
            
            for (int i = 1; i < sayilar.Length; i++) 
            {
                int sayi=rnd.Next(10);//0 ile 10 arasında rastgele sayı üretir 10 dahil değil
               if (sayilar.Contains(sayi))//dizide sayi var mı (sayilar.Contains(sayi)==true da yazılabilir.)
	            {
		        sayac++;
                   i--;//bir geriye gitsin bir daha sayı seçsin
	            }else
	            {
                    sayilar[i] = sayi;
	            }

            
            }

            //4.adım:Dizide bulunan rastgele sayıları ekrana yazdırmak
            foreach (int item in sayilar)
            {
                Console.WriteLine(item);
            }

            Console.Write("\nAynı sayıdan {0} defa üretilmiştir", sayac);
            Console.ReadLine();
        }
    }
}
