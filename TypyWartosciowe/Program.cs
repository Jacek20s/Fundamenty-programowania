using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypyWartosciowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 6;
            int x2 = x1;
            x1 = 4;
            Console.WriteLine(x2);
            Console.ReadKey();
        }
    }
}
