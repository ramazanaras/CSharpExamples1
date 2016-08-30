using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console12_asalsayilar
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 ile 100 arasındaki sayıların hangilerinin asal olduğunu bulup ekrana yazan uygulama
            bool feriha = true;
            for (int i = 2; i <=100; i++)
            {
                if (i==2)
                {
                    //asal sayıdır
                    Console.WriteLine(i);
                }
                else if (i>2)
                {
                    for (int j = 2; j<i; j++)//1 'e ve kendisine bölmemiş oluyoruz
                    {
                        if (i % j == 0)
                        {
                            //asal olmayan sayı bölümü
                            feriha = false;
                            break;//kendine en yakın döngüyü sonlandırıyor.
                        }
                        else
                        {
                            //asal olan sayı bölümü
                            feriha = true;
                            
                        }
                    }
                    if (feriha==true)
                    {
                        Console.WriteLine(i);
                    }
                }
               
            }
            Console.ReadLine();

        }
    }
}
