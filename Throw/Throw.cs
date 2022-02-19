using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    internal class Throw
    {
        static void Metoda()
        {
            Console.WriteLine("Podaj liczbę");
            int wiek = int.Parse(Console.ReadLine());

            if (wiek == 20)
            {
                throw new ArgumentException("20 jest niedozwoloną wartością do wprowadzenia");
            }
        }

    }
}
