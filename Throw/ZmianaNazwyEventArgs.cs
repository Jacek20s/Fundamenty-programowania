using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Throw
{
    public class ZmianaNazwyEventArgs : EventArgs
    {
        public string istniejacaNazwa { get; set; }
        public string zmianaNazwa   { get; set; }
    }
}
