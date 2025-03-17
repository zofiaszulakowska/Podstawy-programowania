using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4_warunkowe17._03
{
    internal class Program
    {
        static void Main(string[] args) //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej i największej z tych liczb.

        {
            double a, b, c, d, e, min, max;
            Console.WriteLine("Podaj 1 liczbe");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj 2 liczbe");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj 3 liczbe");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj 4 liczbe");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj 5 liczbe");
            e = Convert.ToDouble(Console.ReadLine());
            min = a;
            if (b < min) min=b;
            if (c < min) min = c;
            if (d < min) min = d;
            if (e < min) min = e;
            Console.WriteLine("Liczba jest {0} najmniejsza",min);
            max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;
            if (e > max) max = e;
            Console.WriteLine("Liczba jest {0} najwieksza",max);
            Console.ReadKey();



        }
    }
}
