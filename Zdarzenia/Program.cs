using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta();
            karta.ZmianaNazwy += KiedyZmianaNazwy;
            karta.ZmianaNazwy += KiedyZmianaNazwy2;
            karta.Nazwa = "karta Marcina";
            karta.Nazwa = "karta Jacka";
            Console.ReadKey();

        }

        private static void KiedyZmianaNazwy2(object sender, ZmianaNazwyEventArgs args)
        {
            Console.WriteLine("*********************");
        }

        private static void KiedyZmianaNazwy(object sender, ZmianaNazwyEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.istniejacaNazwa} na {args.zmianaNazwa}");
            
        }
    }
}
