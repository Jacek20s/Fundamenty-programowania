using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Karta karta = new Karta();
            karta.ZmianaNazwy += KiedyZmianaNazwy;
            karta.ZmianaNazwy += KiedyZmianaNazwy2;
            Console.WriteLine("Podaj nazwe karty");
            try
            {
                karta.Nazwa = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("ll");
            }
            Console.ReadLine();
            
            


        }
        private static void KiedyZmianaNazwy2(object sender, ZmianaNazwyEventArgs args)
        {
            Console.WriteLine("*********************");
        }

        private static void KiedyZmianaNazwy(object sender, ZmianaNazwyEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.istniejacaNazwa} na {args.zmianaNazwa}");

        }
    }
}
