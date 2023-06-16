using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spickerII
{
    abstract class Tier : IAnzeigbar //Superklasse Tier zum vererben
    {
        public string? Name { get; set; }
        public abstract string Ordnung { get;  } 
        public string? Familie { get; set; }
        public abstract void Anzeigen();
    }
}
