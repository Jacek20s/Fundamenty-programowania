using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsy
{
    public class LepszaKarta : Karta
    {
        public override KartaStatystyki ObliczStatystyki()
        {
            float najnizsza = float.MaxValue;
            foreach (var item in oceny)
            {
                if (item<najnizsza)
                {
                    najnizsza = item;
                }
            }
            oceny.Remove(najnizsza);
            return base.ObliczStatystyki();
        }
    }
}
