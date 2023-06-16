using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spickerII
{
    internal class Saeugetier : Tier
    {
        public bool Gefaerdung;

        public override string Ordnung
        {
            get { return "Säugetier"; }
        }

        public override void Anzeigen()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Familie: " +Familie);
            Console.WriteLine("Ordnung: " + Ordnung);
            Console.WriteLine("Gefährtung: " + Gefaerdung);
        }

    }
}