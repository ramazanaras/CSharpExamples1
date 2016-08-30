using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console12_carpimtablosu
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console Ekranına çarpım tablosunu uygulamayı yazınız
             * Örneğn 
             * 1*1=1
             * 2*2=4
             * 
             * 
             * 
             */

            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    int carpim = i * j;
                    Console.WriteLine("{0}*{1}={2}",i,j,carpim);
                }
            }

            Console.ReadLine();

        }
    }
}
