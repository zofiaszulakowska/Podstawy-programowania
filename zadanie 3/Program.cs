using System;


namespace zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący z klawiatury liczbę całkowitą i wypisujący na ekranie sześcian wczytanej liczby.
            int a; //int : Przechowuje liczby całkowite. Przykład: int liczba = 42; double : Przechowuje liczby zmiennoprzecinkowe
            Console.Write("Podaj a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a^3={0}",a*a*a);
            Console.ReadKey();
  
            
           
        }
      
        
    }
}
