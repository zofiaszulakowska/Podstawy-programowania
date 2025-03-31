using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._3._31._03
{
    internal class Program
    {
        static void Main(string[] args) //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i wypisujący posortowane liczby na ekranie
        {
            int[] tab = new int[1000];
            int i, k, n, tmp;
            Console.Write("Podaj ilosc elementow tablicy (n<=1000) n:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]:", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
                for (k = i + 1; k < n; k++)
                    if (tab[i] > tab[k])
                    { tmp = tab[i]; tab[i] = tab[k]; tab[k]= tmp; }
            Console.Write("Elementy tablicy: ");
            for(i = 0; i < n;i++)
            {
                Console.Write("{0}, ',tab[i]");
            }
            Console.ReadKey();
        }
    }
}
