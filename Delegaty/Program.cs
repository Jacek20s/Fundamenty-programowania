using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wiadomosc wiadomosc = new Wiadomosc(); 
            Action<string> action = wiadomosc.WypiszWiadomosc;
            action += metoda;
            //Wypisz wypisz = new Wypisz(wiadomosc.WypiszWiadomosc);
            action("Bla bla");
            Console.ReadKey();

        }

        private static void metoda(string obj)
        {
            Console.WriteLine("!!!!!!!!!!");
        }
    }
}
