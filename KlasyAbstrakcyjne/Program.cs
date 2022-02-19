using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstrakcyjne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KartaPodstawowa karta = UtworzKarte();
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

        private static KartaPodstawowa UtworzKarte()
        {
            return new LepszaKarta();
        }
    }
}
