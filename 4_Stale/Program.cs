using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Stale
{
    internal class Program
    {
        const float PI = 3.1415f;
        public static float R = 5f;
        const string nazwa = "ABC";
        static void Main(string[] args)
        {
            ObliczPoleKola();
            Console.ReadKey();
        }

        public static void ObliczPoleKola()
        {
            float pole = PI * R * R;
            Console.WriteLine($"Pole koła = {pole}");
        }
        public void Method1(string nazwaFirmy)
        {

        }
        public void Method2()
        {
            Method1(nazwa);
        }
    }
}
