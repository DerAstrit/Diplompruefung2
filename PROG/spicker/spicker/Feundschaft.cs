using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spicker
{
    internal class Feundschaft
    {
        public int ProbandID { get; set; }
        public Proband Proband { get; set; }
        public int FreundID { get; set; }
        public Freund Freund { get; set; }

    }
}
