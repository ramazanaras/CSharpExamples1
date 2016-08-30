using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console9_diziler
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * Diziler:
             * -Aynı iş ve aynı amaç için içerisinde birden fazla değer barındırmayı sağlayan yapılardır.
             * -Dizileri tanımlarken ne kadar yer kaplayacakları yani içerisinde kaç tane eleman barındıracakları belli olsun diye tanımlama
             * sırasıda adet verilir.
             * Her tipin dizisi olabilir
             * Herhangi bir tipi dizi haline getirmek için tipin sonuna "[]" konulur.
             * Faydası:Aynı isim altında bir tipe ait birden fazla değer tutubilir.
             * 
             * Dizilerde numaralandırma index diye adlandırılır
             * ve 0 dan başlar.Yani 1.sıradaki elemanın index numarası 0 dır.
             * 
             * Tanımlama Şekli:
             * string[] isimler=new string[10]
             * 
             * 
             */
            string[] isimler = new string[10];//dizilerde referans tipli değişkenlerdir.
            int[] sayilar = new int[5];

            //Diziye değer atama yöntemi:
            isimler[4] = "Ahmet";
            sayilar[0] = 4;

            //object initializer
            char[] karakterler = {'A','7','?','B','C'};

            //Dizilerin boyutu nasıl artılır?
            Array.Resize(ref karakterler, 6);
            
            //Dizilerin boyutunu öğrenme
            int boyut = isimler.Length;

            //Herhangi bir dizinin boyutunu var olan boyutundan 1 artırmak istersek ne yapmalıyız.
            Array.Resize(ref isimler, isimler.Length + 1);



        }
    }
}
