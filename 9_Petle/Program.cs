using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Petle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int length = 10;
                int[] tabela = new int[] { 1, 2, 3, 4, 5 };
                //for (int i = 0; i < length; i++)
                //{
                //    Console.WriteLine(i);
                //}
                //while (length>5)
                //{
                //    Console.WriteLine(length);
                //    length--;
                //}
                //do
                //{
                //    Console.WriteLine(length);
                //} while (length<5);
                foreach (var item in tabela)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            }
        }
    }
}
