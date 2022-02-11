using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ZasiegZmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                int zmienna = 10;
                var wynik = 100 + zmienna;
            }

        }
        public int liczba = 50; // zmienna dostąpna
        internal int zmienna2 = 2; // dostępna w namespace
        private int zmienna3 = 2; // dostępna tylko w klasie
        protected int zmienna4 = 2; // dostępna tylko w klasie i w klasach dziedziczących
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
