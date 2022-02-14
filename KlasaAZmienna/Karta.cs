using System;
using System.Collections.Generic;
using System.Linq;

namespace KlasaAZmienna
{
    public class Karta
    {
        public Karta()
        {
            oceny = new List<float>();
        }
        //stan (zmienne - pola)
        public List<float> oceny;

        //zachowania (funkcje - metody)
        /// <summary>
        /// Dodaje nową ocenę do listy ocen
        /// </summary>
        /// <param name="ocena">Nowa ocena</param>
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
        }
        /// <summary>
        /// Oblicznie średniej
        /// </summary>
        /// <returns>Średnia</returns>
        public float ObliczSrednia()
        {
            
            float srednia = oceny.Average();
            return srednia; 
            
        }
        /// <summary>
        /// Najniższa ocena
        /// </summary>
        /// <returns>najniższa ocena</returns>
        public float NajnizszaOcena()
        {
            float min = oceny.Min();
            return min;
        }
        /// <summary>
        /// Najwyższa ocena
        /// </summary>
        /// <returns>najwyższa ocena</returns>
        public float NajwyzszaOcena()
        {
            float max = oceny.Max();
            return max;
        }
    }
}
