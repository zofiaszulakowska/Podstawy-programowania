using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3_17._03
{
    internal class Program
    {
        static void Main(string[] args) //Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb
        {
            double a,b,c;
            Console.WriteLine("Podaj 1 liczbe");
            a= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj 2 liczbe");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj 3 liczbe");
            c = Convert.ToDouble(Console.ReadLine());
            if ((a >= b) & (a >= c))
                Console.WriteLine("Liczba {0} jest najwieksza", a);
            else if ((b >= a) & (b >= c))
                Console.WriteLine("Liczba {0} jest najwieksza", b);
            else Console.WriteLine("Liczba {0} jest najwieksza", c);
            if ((a <= b) & (a <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", a);
            else if ((b <= a) & (b <= c))
                Console.WriteLine("Liczba {0} jest najmniejsza", b);
            else Console.WriteLine("Liczba {0} jest najmniejsza", c);

            Console.ReadKey();
        }
    }
}
