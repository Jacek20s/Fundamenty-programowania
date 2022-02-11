using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Zmienne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklaracja zmiennej
            int liczbaCalkowita;
            //inicjalicacja zmiennej
            liczbaCalkowita = 20;
            //deklaracja z inicjalizacja zmiennej
            int liczba = 20;


            byte zmiennaMala = byte.MaxValue;
            short liczbaCalkowitaKrotka = 5;
            liczbaCalkowitaKrotka = short.MaxValue;
            int liczbaCalkowita2 = 500;
            liczbaCalkowita2 = int.MaxValue;
            long liczbaCalkowitaDluga = 50000;
            liczbaCalkowitaDluga = long.MinValue;
            float liczbaZmiennoprzecinkowaPojedynczejPrecyzji = 400.55f;
            liczbaZmiennoprzecinkowaPojedynczejPrecyzji = float.MaxValue;
            double liczbaZmiennoprzecinkowaPodwojnejPrecyzji = 500000.55;
            liczbaZmiennoprzecinkowaPodwojnejPrecyzji = double.MaxValue;
            bool zmiennaLogiczna = true;
            char zmiennaZnak = 'A';
            string zmiennaTekstowa = "tekst";

        }
    }
}
