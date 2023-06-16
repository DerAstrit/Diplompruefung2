using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spicker
{
    internal class Pate : Person
    {   
        public Pate() { }
        public override void Anzeigen()
        {
            throw new NotImplementedException();
        }
        public Proband? Proband { get; set; }

    }
}
