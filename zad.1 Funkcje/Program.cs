using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._1_Funkcje
{
    class Program
    {
         //Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami całkowitymi. Napisz program wykorzystujący funkcję suma. 
        
            static int suma(int a, int b)
            {
                return a + b;
            }

            static void Main(string[] args)
            {
                Console.WriteLine("4+6={0}", suma(4, 6));
                Console.ReadKey(true);

            }
        }
    }

