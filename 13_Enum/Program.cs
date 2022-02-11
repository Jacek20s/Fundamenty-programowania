using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imiona imiona = Imiona.Marcin;
            Console.WriteLine(Imiona.Jacek);
            switch (imiona)
            {
                case Imiona.Marcin:
                    break;
                case Imiona.Tomek:
                    break;
                case Imiona.Jacek:
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
        public enum Imiona
        {
            Marcin,
            Tomek,
            Jacek

        }
    }
}
