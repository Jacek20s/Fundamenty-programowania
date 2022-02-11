using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_IF
{
    internal class Program
    {
        private static int wiek;

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiek");
            wiek = int.Parse(Console.ReadLine());
            string test = wiek > 18 ? "jesteś pełnoletni" : "jesteś niepełnoletni";
            Console.WriteLine(test);
            SprawdzanieWieku();
            Console.ReadKey();

        }

        private static void SprawdzanieWieku()
        {

            if (wiek <= 8)
            {
                if (wiek < 4)
                {
                    Console.WriteLine("Twój wiek jest mniejszy niż 4");
                }
                else
                {
                    Console.WriteLine("Twój wiek jest mniejszy niż 8");
                }

                Method1();
            }
            else if (wiek < 18)
            {
                Console.WriteLine("Twój wiek jest mniejszy od 18 ale większy niż 8");
                Method1();
                Method2();
            }
            else if (wiek < 50)
            {
                Method1();
                Method2();
            }
            else
            {
                Console.WriteLine("Masz sporo lat");
                Method1();
            }
        }

        private static void Method2()
        {
            Console.WriteLine("Cześć");
        }

        private static void Method1()
        {
            Console.WriteLine("Wiek wynosi " + wiek);
        }
    }
}
