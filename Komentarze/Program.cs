using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komentarze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // komentarz jednowierszowy
            /* komentarz wielowierdzowy
             * 
             */

            #region operatory
            int liczba1 = 10;
            int liczba2 = 20;
            bool liczba3 = true;
            bool liczba4 = false;

            var wynik1 = liczba1 + liczba2;
            var wynik2 = liczba1 - liczba2;
            var wynik3 = liczba1 * liczba2;
            var wynik4 = liczba1 / liczba2;
            var wynik5 = liczba1 % liczba2;
            var wynik6 = liczba1++;
            var wynik7 = liczba1--;

            var wynik8 = (liczba1 == liczba2);
            var wynik9 = (liczba1 != liczba2);
            var wynik10 = (liczba1 > liczba2);
            var wynik11 = (liczba1 < liczba2);
            var wynik12 = (liczba1 <= liczba2);
            var wynik13 = (liczba1 >= liczba2);

            var wynik14 = (liczba3 && liczba4);
            var wynik15 = (liczba3 || liczba4);
            var wynik16 = (!liczba3);

            liczba1 += 4;
            liczba1 -= 4;
            liczba1 *= 4;
            liczba1 /= 4;
            #endregion

        }
        /// <summary>
        /// Metoda pobiera liczbę i wykonuje obliczenia
        /// </summary>
        /// <param name="liczba">Parametr od jeden do dziesiec</param>
        /// <returns>true lub false</returns>
        public static bool Method1(int liczba)
        {
            return true;
        }
    }
}
