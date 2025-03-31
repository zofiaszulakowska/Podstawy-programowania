using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie._5._31._03
{
    internal class Program
    {
        static void Main(string[] args) //Wczytaj liczbę naturalną n i wypisz na ekranie tą liczbę w systemie dwójkowym
        {
            int[] tab = new int[1000];
            int i=0, k, liczba;
            Console.Write("Podaj liczbe naturalna");
            liczba = Convert.ToInt32(Console.ReadLine());


            while ((liczba/2!=0) || ((liczba/2==0) && (liczba%2!=0)))

                        {
                tab[i++] = liczba % 2;
                liczba /= 2;
            }
            for (k=i-1;k>=0;k--)
                Console.Write(tab[k]);
            Console.ReadKey();
        }
        
    }
}
