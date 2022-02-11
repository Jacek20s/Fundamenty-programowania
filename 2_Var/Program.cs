using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte zmiennaMala;
            short liczbaCalkowitaKrotka;
            int liczbaCalkowita2;
            long liczbaCalkowitaDluga;
            float liczbaZmiennoprzecinkowaPojedynczejPrecyzji;
            double liczbaZmiennoprzecinkowaPodwojnejPrecyzji;
            bool zmiennaLogiczna;
            char zmiennaZnak;
            string zmiennaTekstowa = "tekst";
            var zmiennaVar = "tekst";
            Console.WriteLine(zmiennaVar);
            Console.ReadLine();
        }
        public int liczba = 50;
        public void Method1()
        {
            var zmienna1 = liczba;
        }
        public void Method2()
        {
            var zmienna1 = liczba;

        }
        public void Method3()
        {
            var zmienna1 = liczba;

        }
    }
}
