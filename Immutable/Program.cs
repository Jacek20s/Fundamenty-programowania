using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2022, 02, 18);
            data.AddDays(3);
            Console.WriteLine(data);
            string name = "   Marcin   ";
            name = name.Trim();
            Console.WriteLine(name);
        }
    }
}
