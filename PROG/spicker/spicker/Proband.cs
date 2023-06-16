using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spicker
{
    class Proband : Person
    {   
        public string Geschlecht { get; set; }
        public override void Anzeigen()
        {
            throw new NotImplementedException();
        }
        public int MutterID { get; set; }   // int ist verlangt die existenz einer Mutter
        public Mutter? Mutter { get; set; }

        public int? PateId { get; set; }   // int? ist nullable, was bedeutet, dass es ein oder kein Pate geben kann
        public Pate? Pate { get; set; }

        public List<Feundschaft>? Feundschaften { get; set; }
    }
}
