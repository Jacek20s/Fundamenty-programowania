using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyReferencyjne
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Karta karta1 = new Karta();
            Karta karta2 = karta1;
            karta1.Nazwa = "karta Marcina";
            Console.WriteLine(karta2.Nazwa);

        }
    }
}
