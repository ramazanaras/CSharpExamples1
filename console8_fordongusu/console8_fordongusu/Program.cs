using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console8_fordongusu
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * For döngüsü

             * 
             * 
             */

            int deger = 15;
            for (int sayi = 0; sayi <= 100 && deger==15; sayi++) {

                Console.WriteLine(sayi);
                
            }

            
            Console.Clear();




            //Kullanıcının girmiş olduğu sayının faktöriyelini hesaplayan uygulamayı yazınız.

            //1.adım:Kullanıcının sayı girmesini sağlamak ve girilen sayıyı bir değişkende tutmak
            Console.Write("Faktöriyeli hesaplanacak sayıyı giriniz: ");
            int faktor = Convert.ToInt32(Console.ReadLine());

            //2.adım:Sayının Faktöriyelinin Hesaplanması
            if (faktor==0)
            {
                Console.Write("0 sayısının faktöriyeli 1 dir.");
            }
            else
            {
                int sonuc = 1;
                for (int i = faktor; i > 0; i--)
                {
                    if (i==3)
                    {
                        break;//direk döngüden çıkar (continue deseydik bu aşamayı geçip diğer aşamadan devam ederdi.)
                    }
                    Console.Write("{0}*",i);
                    sonuc *= i;
                }
                Console.Write("\n {0} sayısının Faktöriyeli: {1}", faktor, sonuc);

            }        
        

            Console.ReadLine();
        }
    }
}
