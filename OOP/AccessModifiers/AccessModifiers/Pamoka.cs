using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Pamoka
    {
        public string Pavadinimas { get; set; }
        public List<Mokytojas> Mokytojai { get; set; }
        public PazymiuKnygele PazymiuKnygele { get; set; }
    }
}
