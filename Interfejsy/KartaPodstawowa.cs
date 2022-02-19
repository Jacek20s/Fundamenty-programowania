using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    public abstract class KartaPodstawowa :IKartaPodstawowa
    {
        protected string _nazwa;

        public string Nazwa
        {
            get { return _nazwa.ToUpper(); }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_nazwa != value)
                    {
                        ZmianaNazwyEventArgs args = new ZmianaNazwyEventArgs();
                        args.istniejacaNazwa = _nazwa;
                        args.zmianaNazwa = value;
                        ZmianaNazwy(this, args);
                    }

                    _nazwa = value;

                }
            }
        }
        public event ZmianaNazwyDelegat ZmianaNazwy;
        public abstract void DodajOcene(float ocena);
        public abstract KartaStatystyki ObliczStatystyki();
    }
}
