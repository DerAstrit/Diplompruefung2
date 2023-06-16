using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spickerII
{
    internal class Persoenliche_Angaben : IAnzeigbar
    {   
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Email { get; set; }

        public virtual void Anzeigen()
        {
            Console.WriteLine("Vorname: " + Vorname);
            Console.WriteLine("Nachname: " + Nachname);
            Console.WriteLine("E-Mail: " + Email);

        }

    }
}
