using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_KartaOcenFilmow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta();
            //Karta kartaUzytkownika = new Karta();
            //PrzykladowaKarta(kartaUzytkownika);
            karta.DodajOcene(6);
            karta.DodajOcene(8);
            karta.DodajOcene(3);
            karta.DodajOcene(4.4f);
            KartaStatystyki statystyki = karta.ObliczStatystyki();
            Console.WriteLine(statystyki.SredniaOcena + " " + statystyki.NajwyzszaOcena + " " + statystyki.NajnizszaOcena);

            Console.ReadKey();
        }

        private static void PrzykladowaKarta(Karta kartaUzytkownika)
        {
            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1-10");
                float ocena;
                bool wynik = float.TryParse(Console.ReadLine(), out ocena);

                if (ocena == 11)
                {
                    break;
                }
                if (ocena > 0 && ocena <= 10)
                {
                    kartaUzytkownika.DodajOcene(ocena);
                }
                else
                {
                    Console.WriteLine("Liczba spoza zakresu");
                }

            }
            if (kartaUzytkownika.oceny.Count() > 0)
            {
                float min = kartaUzytkownika.NajnizszaOcena();
                float max = kartaUzytkownika.NajwyzszaOcena();
                float srednia = kartaUzytkownika.ObliczSrednia();
                Console.WriteLine($"Średnia = {srednia}, Min = {min}, Max = {max}");
            }
        }
    }
}
