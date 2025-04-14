using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._2.funckje
{
    class Program
    {
        // Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych zadanych jako argumenty tej funkcji. Napisz program wykorzystujący funkcję max. 
        
        static int max(int x, int y)
        {
            if (x > y) return x;
            else return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("max z 6 i 9 to {0}", max(6,9));
            Console.WriteLine("max z 9 i 6 to {0}", max(9,6));
            Console.WriteLine("max z 6 i 6 to {0}", max(6, 6));
            Console.ReadKey(true);

        }

    }
    }

