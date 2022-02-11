using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<long> lista = new List<long>();
            lista.Add(3);
            lista.Add(5);
            lista.Add(7);
            lista.Add(4);
            lista.Add(2);
            lista.Sort();
            lista.Reverse();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
