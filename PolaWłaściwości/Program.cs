using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolaWłaściwości
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta();
            karta.Nazwa = "karta Marcina";
            karta.Nazwa = "";
            Console.WriteLine(karta.Nazwa);
            Console.ReadKey();


        }
    }
}
