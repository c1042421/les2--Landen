using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefLanden
{
    class Monarchie: Land
    {
        public string Koning { get; set; }

        public Monarchie(string naam, string hoofdstad, string koning): base(naam, hoofdstad)
        {
            Koning = koning;
        }

        public override string ToString()
        {
            return string.Format("{0} (Koning(in): {1})", base.ToString(), Koning);
        }
    }
}
