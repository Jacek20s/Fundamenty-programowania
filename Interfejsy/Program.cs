using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKartaPodstawowa karta = UtworzKarte();
            karta.DodajOcene(4);
            karta.DodajOcene(8);
            karta.DodajOcene(6);
            karta.DodajOcene(3);

            KartaStatystyki statystyki = karta.ObliczStatystyki();

            Console.WriteLine("Srednia " + statystyki.SredniaOcena);
            Console.WriteLine("Min " + statystyki.NajnizszaOcena);
            Console.WriteLine("Max " + statystyki.NajwyzszaOcena);
            Console.ReadLine();
        }

        private static IKartaPodstawowa UtworzKarte()
        {
            return new Karta();
        }
    }
}
