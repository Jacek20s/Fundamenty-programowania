using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Kolekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[10];
            List<int> lista = new List<int>();
            tablica[0] = 1;
            tablica[1] = 2;
            tablica[2] = 3;
            tablica[3] = 4;
            tablica[4] = 5;
            tablica[5] = 6;
            tablica[6] = 7;
            tablica[7] = 8;
            tablica[8] = 9;
            tablica[9] = 10;

            foreach (var item in tablica)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
