using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktor
{
    internal class Osoba
    {
        public Osoba()
        {
            imie = "default";
            nazwisko = "default";
            miasto = "default";
            ulica = "default";
            wiek = 10;
            Console.WriteLine("Zadziałał konstruktor domyślny");
        }
        public Osoba(string imie, string nazwisko, string miasto, string ulica, int wiek)
        {
            this.imie = imie;
            this.nazwisko=nazwisko;
            this.miasto = miasto;
            this.ulica = ulica;
            this.wiek = wiek;
            Console.WriteLine("Zadziałał konstruktor 5 parametrowy");
        }
        public Osoba(string imie, string nazwisko, string miasto)
        {
            this.imie = imie;
            this.nazwisko=nazwisko;
            this.miasto = miasto;
            Console.WriteLine("Zadziałał konstruktor 3 parametrowy");

        }
        public Osoba(string imie, string nazwisko) : this(imie,nazwisko,"Katowice", "Miła", 16)
        {
            Console.WriteLine("Zadziałał konstruktor 2 parametrowy");   
        }
        string imie;
        string nazwisko;
        string miasto;
        string ulica;
        int wiek;
    }
}
