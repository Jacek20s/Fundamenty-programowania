using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struktury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zmienna;
            zmienna = 8;
            Ksiazka ksiazka;
            ksiazka.Autor = "Kowalski";
            ksiazka.Tytul = "Programowanie w C#";
            ksiazka.Id = 1;
            Console.WriteLine("Tytuł książki: {0}", ksiazka.Tytul);
        }
    }

}
