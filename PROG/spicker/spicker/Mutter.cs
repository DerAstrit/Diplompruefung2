using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spicker
{
    internal class Mutter : Person
    {
        public Mutter() { }
        public override void Anzeigen()
        {
            throw new NotImplementedException();
        }
        public ICollection<Proband> Probanden { get; set; }  
    }
}
