using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb z uwzględnieniem części całkowitej i reszty z dzielenia
            int a, b;
            Console.WriteLine("Podaj a");
                a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wynik dzielenia z reszta :{0} reszta {1} ", a/b, a % b);
                Console.ReadLine();

        }
    }
}
