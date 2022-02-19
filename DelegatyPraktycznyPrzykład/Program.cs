using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatyPraktycznyPrzykład
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta();
            karta.ZmianaNazwy = new ZmianaNazwyDelegat(KiedyZmianaNazwy);
            karta.ZmianaNazwy += new ZmianaNazwyDelegat(KiedyZmianaNazwy2);
            karta.Nazwa = "karta Marcina";
            karta.Nazwa = "karta Jacka";
            Console.ReadKey();

        }

        private static void KiedyZmianaNazwy2(string istniejacaNazwa, string zmianaNazwa)
        {
            Console.WriteLine("*********************");
        }

        private static void KiedyZmianaNazwy(string istniejacaNazwa, string zmianaNazwa)
        {
            Console.WriteLine($"Zmiana nazwy z {istniejacaNazwa} na {zmianaNazwa}");
        }
    }
}
