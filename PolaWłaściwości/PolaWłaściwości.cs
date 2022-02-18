using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolaWłaściwości
{
    internal class Zwierze
    {
        private string _nazwa;
        private string _nazwa2;
        private readonly string _nazwa3;

        public Zwierze(string nazwa, string pole)
        {
            _nazwa = nazwa;
            _nazwa3 = pole;
        }
        public string nazwa 
        {
            get { return nazwa; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _nazwa = value;
                }
                
            }
        }
        
    }
}
