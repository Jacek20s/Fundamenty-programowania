using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametryMetody
{
    internal class Program
    {
        static void UstawNazwe(ref Karta karta)
        {
            karta.Nazwa = "karta Marcina";
        }
        static void Main(string[] args)
        {
            Karta karta = new Karta();
            Karta karta2 = karta;
            UstawNazwe(ref karta);
            Console.WriteLine(karta2.Nazwa);
            Console.ReadKey();
        }
    }
}
