using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spickerII
{
    sealed class Benutzer : Persoenliche_Angaben
    {
        public string Passwort { private get; set;}

        public string Benutzername { private get; set; }
        public override void Anzeigen()
        {   
            Console.Write("\nPasswort: ");
            for (int i = Passwort.Count(); i >= 0; i --)
            { Console.Write("*"); }

            
            Console.WriteLine("\nBenutzername " + Benutzername);
            base.Anzeigen();
        }
    }
}
