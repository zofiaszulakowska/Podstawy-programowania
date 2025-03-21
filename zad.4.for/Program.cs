using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._4.@for
{
    class Program
    {
        static void Main(string[] args) //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt posiadający n wierszy i k kolumn.Użyj pętli for
        {
            int i, n, k, j;
            Console.Write("Podaj liczbe naturalna dodatnia n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe naturalna dodatnia k:");
            k = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= k; j++) 
                Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey();
        } 
        
    }
}
