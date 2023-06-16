using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spicker
{
    internal class Freund : Person
    {
        public override void Anzeigen()
        {
            throw new NotImplementedException();
        }
        public List<Feundschaft> Feundschaften { get; set; }

    }
}
