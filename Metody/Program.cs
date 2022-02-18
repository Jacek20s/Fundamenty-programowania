using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta();
            karta.DodajOcene(2);
            karta.DodajOcene(3);
            karta.DodajOcene(4);
            KartaStatystyki stat = karta.ObliczStatystyki();
            wypiszWynik("Średnia", stat.SredniaOcena);
            wypiszWynik("Max", stat.NajwyzszaOcena);
            wypiszWynik("Min", stat.NajnizszaOcena);
            wypiszWynik("Params", 2, 3, 5, 2, 2);
            Console.ReadKey();
        }

        private static void wypiszWynik(string v, float wynik)
        {
            Console.WriteLine(v + ": " + wynik);
        }
        static void wypiszWynik(string opis, params float[] wynik)
        {

            Console.WriteLine(opis + ": " + wynik[0]);
        }

    }
}
