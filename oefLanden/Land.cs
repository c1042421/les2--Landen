using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefLanden
{
    class Land
    {
        public Land(string naam, string hoofdstad)
        {
            Naam = naam;
            Hoofdstad = hoofdstad;
        }

        public Land(): this("", "") { }

        public string Naam { get; set; }
        public string Hoofdstad { get; set; }

        public override string ToString()
        {
            return string.Format("{0} heeft als hoofdstad {1}", Naam, Hoofdstad);
        }

        public override bool Equals(object obj)
        {
            var land = obj as Land;
            return land != null &&
                   Naam == land.Naam &&
                   Hoofdstad == land.Hoofdstad;
        }

        public override int GetHashCode()
        {
            var hashCode = -1428672537;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Naam);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Hoofdstad);
            return hashCode;
        }
    }
}
