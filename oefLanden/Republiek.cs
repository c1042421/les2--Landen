using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefLanden
{
    class Republiek: Land
    {
        public Republiek(string naam, string hoofdstad, string president): base(naam,hoofdstad)
        {
            President = president;
        }

        public string President { get; set; }

        public override string ToString()
        {
            return string.Format("{0} (president: {1})", base.ToString(), President);
        }
    }
}
