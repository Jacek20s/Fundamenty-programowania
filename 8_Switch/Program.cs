using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Switch
{
    internal class Program
    {
        private static string imie;

        static void Main(string[] args)
        {

            Console.WriteLine("Podaj imie");
            imie = Console.ReadLine();

            switch (imie)
            {

                case "Jacek":
                    Method1();
                    Method2();
                    break;
                case "Marcin":
                    Method3();
                    Method4();
                    break;
                case "Tomek":
                    Method5();
                    Method6();
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }
            Console.ReadKey();
        }

        private static void Method6()
        {
            Console.WriteLine("Jesteś w metodzie 6");
        }

        private static void Method5()
        {
            Console.WriteLine("Jesteś w metodzie 5");
        }

        private static void Method4()
        {
            Console.WriteLine("Jesteś w metodzie 4");
        }

        private static void Method3()
        {
            Console.WriteLine("Jesteś w metodzie 3");
        }

        private static void Method2()
        {
            Console.WriteLine("Jesteś w metodzie 2");
        }

        private static void Method1()
        {
            Console.WriteLine("Jesteś w metodzie 1");
        }
    }
}
