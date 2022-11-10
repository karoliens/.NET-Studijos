using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Pamoka
    {
        public Pamoka()
        {

        }

        public Pamoka(string pavadinimas, List<Mokytojas> mokytojai, PazymiuKnygele pazymiuKnygele)
        {
            Pavadinimas = pavadinimas;
            Mokytojai = mokytojai;
            PazymiuKnygele = pazymiuKnygele;
        }

        public string Pavadinimas { get; set; }
        public List<Mokytojas> Mokytojai { get; set; }
        public PazymiuKnygele PazymiuKnygele { get; set; }
    }
}
