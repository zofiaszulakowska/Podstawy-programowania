using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1._31._03
{
    internal class Program
    {
        static void Main(string[] args) /*Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych (dodatnich i ujemnych) i wypisujący wczytane liczby na ekranie.*/

        {
            int[] tab;
            tab = new int[1000];
            int i, n; //i - licznik petli, n- ilosc elementow tablicy
            Console.Write("Podaj ilosc elementow tablicy (n<=1000) n:");
            n = Convert.ToInt32(Console.ReadLine());
            for   (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]:", tab[i]);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elementy tablicy:");
            for (i = 0; i < n; i++) 
            {
                Console.WriteLine("{0}", tab[i]);
            }
            Console.ReadKey();


        }
    }
}

