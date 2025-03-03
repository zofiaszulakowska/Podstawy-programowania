using System;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący imię użytkownika i wypisujący na ekranie tekst "Witaj imię!"
            string imie; //string odnosi sie do zmiennej gdzie trzeba wpisac tekst
            Console.Write("Podaj imie:"); //Write robi kursor od razu po tekscie, Writeline wyprowadza dane jako ciąg, po którym następuje znak nowej linii, czyli enter na nowy wiersz.
            imie = Console.ReadLine();
            Console.WriteLine("Witaj {0}!", imie); //{0} odnosi sie do 1 zmiennej czyli tutaj do imie (1 po przecinku)
            /*lub int x=5;
             * int y=5;
             * Console.WriteLine("liczba to {0} i {1}", x, y);
             * Console.WriteLine($"liczba to {x} i {y}");
          
            Console.ReadKey(true);
        }
    }
}
