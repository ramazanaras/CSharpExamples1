using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console12_ikisayiarasindakiasalsayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            //kullanıcının girmiş oluduğu iki sayı arasındaki asal sayıları bulup ekrana yazan uygulamayı yazınız
            Console.Write("1.sayıyı giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı giriiniz");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            bool defne = true;
            if (sayi1 > sayi2)
            {
                for (int i = sayi2; i <= sayi1; i++)
                {
                    if (i == 2)
                    {
                        Console.WriteLine(i);
                    }
                    else if (i > 2)
                    {
                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                defne = false;
                                break;
                            }
                            else
                            {
                                defne = true;
                            }
                        }
                        if (defne == true)
                        {
                            //asal sayı 
                            Console.WriteLine(i);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
