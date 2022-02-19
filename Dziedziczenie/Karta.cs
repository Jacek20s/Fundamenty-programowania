using System;
using System.Collections.Generic;
using System.Linq;

namespace Dziedziczenie
{
    public class Karta
    {
        public Karta()
        {
            oceny = new List<float>();
        }
        //stan (zmienne - pola)
        public List<float> oceny;
        private string _nazwa;
        
        public string Nazwa
        {
            get { return _nazwa.ToUpper(); }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_nazwa!=value)
                    {
                        ZmianaNazwyEventArgs args = new ZmianaNazwyEventArgs();
                        args.istniejacaNazwa = _nazwa;
                        args.zmianaNazwa = value;
                        ZmianaNazwy(this,args);
                    }
                    
                    _nazwa = value;

                }
            }
        }
        public event ZmianaNazwyDelegat ZmianaNazwy;

        //zachowania (funkcje - metody)
        /// <summary>
        /// Dodaje nową ocenę do listy ocen
        /// </summary>
        /// <param name="ocena">Nowa ocena</param>
        public void DodajOcene(float ocena)
        {
            oceny.Add(ocena);
        }

        public virtual KartaStatystyki ObliczStatystyki()
        {
            KartaStatystyki stat = new KartaStatystyki();
            stat.NajnizszaOcena = oceny.Min();
            stat.NajwyzszaOcena = oceny.Max();
            stat.SredniaOcena = oceny.Average();
            return stat;
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
