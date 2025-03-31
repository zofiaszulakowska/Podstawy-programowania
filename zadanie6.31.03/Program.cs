using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6._31._03
{
    internal class Program
    {
        static void Main(string[] args) //Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli foreach.

        {
            string[] dni = new string[] { "poniedzialek", "wtorek", "sroda", "czwratek", "piatek", "sobota", "niedziela" };
            foreach (string elem in dni)
                Console.Write("{0}, ", elem);
        }
        
    }
   

}
       