using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console10_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Foreach Döngüsü
             * 
             * -üç önemli kuralı vardır.
             * 1-Sadece ileri gider
             * 2-Readonlydir.(Sadece okunabilir.Yani koleksiyon içerisindeki elemana değer ataması yapılamaz)
             * 3-koleksiyon yapısı foreach'in çalışması sırasında değiştirilemez.
             * 
             * 
             * -Yazılışı
             * foreach(elemanTipi degiskenIsmi in koleksiyon){
             * 
             * }
             *
             * Döngüler arasında en çok kullanacağımız döngü yapısıdır.
             
             * 
             
             */

            char[] karakterler={'A','5','f'};
            foreach (char item  in karakterler)
            {
                //item = 'i';  değer ataması yapılmaz hata verir.
            
            
            }

            Console.Write("Kaç isim girilecek:");
            int adet = Convert.ToInt32(Console.ReadLine());
            string[] isimler = new string[adet];

            for (int i = 0; i <isimler.Length; i++)
            {
                Console.Write("{0}.ismi giriniz",i+1);
                isimler[i] = Console.ReadLine();
            }

            Console.Write("Aranacak isim");
            string aranacak = Console.ReadLine();

            int sayac = 0;
            foreach (string eleman in isimler)
            {
                if (eleman==aranacak)
                {
                    sayac++;

                }  
            }
            Console.Write("{0} isminden listede {1}  tane vardır", aranacak, sayac);
            Console.ReadLine();

        }
    }
}
