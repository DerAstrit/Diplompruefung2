using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spickerII
{
    internal class Fisch : Tier
    {
        public sealed override string Ordnung
        {
            get { return "Fisch"; }
        }

        public override void Anzeigen()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Familie: " + Familie);
            Console.WriteLine("Ordnung: " + Ordnung);
        }
    }
}
