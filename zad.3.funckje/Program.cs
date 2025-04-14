using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._3.funckje
{
    class Program
    {
        //Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca obliczoną wartość pola koła. Napisz program wykorzystujący funkcję pole_kola. 
        static double polekola(double r)
        {
            return Math.PI * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dla r=1,5 Pole ={0}", polekola(2.0));
            Console.ReadKey(true);
        }
    }
}

