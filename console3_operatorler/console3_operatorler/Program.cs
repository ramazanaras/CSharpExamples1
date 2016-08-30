using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3_operatorler
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Operatorler
             * 1-Matematiksel Operatorler
             *  *,/,+,-
             * ++,--
             * %
             * -= ,+=,*=,/=
             * 
             * Not:++ veya -- operatorü değişkenin önünde (solunda) ise değişkeni önce işleme sokar daha sonra 
             * kullanırız
             * Not:++ veya -- operatörü değişkenin arkasında (sağında ) ise önce değişkeni kullanıırız sonra işleme sokar.
             * 
             */

            int a = 5;
            a = a + 10;
            a += 10;
            a -= 10;
            a *= 10;
            a /= 10;
            int b = 0;
            b = ++a;
            b = a++;

            //a = 5;
            //a = a++ + --a;   ?sonucu nedir
            //a = 5 + --6;
            //a = 5 + 5;//a=10 olur.

            /*
             * 2-ilişkisel operatorler
             * 
             * ==  -> Eşit mi 
             * 
             * < ->  Küçük mü

             * >  -> Büyük mü 
             * <=  Küçük veya eşit mi
             * >= Büyük veya eşit mi
             *!=  -> eşit değil mi 
             *!< 
             *!>
             *!
             * 
             *
             * 3 -mantıksal operatorler 
             * &  ve 
             * | veya
             * !  değil
             * 
             * 
             */

        }
    }
}
