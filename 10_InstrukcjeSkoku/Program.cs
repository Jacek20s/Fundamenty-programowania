using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_InstrukcjeSkoku
{
    internal class Program
    {
        static int[] liczby = { 1, 3, 5, 6, 7, 44, 343, };
        static void Main(string[] args)
        {
            
            Method1();

            //foreach (var item in liczby)
            //{
            //    Console.WriteLine(item);
            //    if (item ==3)
            //    {
            //        Console.WriteLine("3");
            //        continue;
            //    }
            //    if (item == 6)
            //    {
            //        Console.WriteLine("liczba to 6");
            //        break;
            //    }
            //}
            Console.ReadKey();

        }

        private static void Method1()
        {
            foreach (var liczba in liczby)
            {
                if (liczba==5)
                {
                    Console.WriteLine("liczba wynosi 8");
                    return;
                }
            }
            Console.WriteLine("test");
        }
    }
}
