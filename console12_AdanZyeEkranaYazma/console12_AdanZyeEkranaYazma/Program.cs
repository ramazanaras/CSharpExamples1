using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console12_AdanZyeEkranaYazma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Console ekranına a dan z ye kadar harfleri yazan uygulamayı yazınız.
             * 
             * 
             * 
             */

            for (char i = 'a'; i <='z'; i++)
            {
                Console.WriteLine(i);
            }
            Console.Clear();//ekranı temizleyelim

            //asci kodlarını kullanarak yazalım birde 
            for (int i = 97; i <=122; i++)//küçük harfler 97 den 122 ye kadar asci kodları
            {
               // char harf = Convert.ToChar(i);
                //Console.WriteLine(harf);
                Console.WriteLine((char)i);//böylede yapılabilir
            }


            Console.ReadLine();
        }
    }
}
