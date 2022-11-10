using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class PazymiuKnygele
    {
        public PazymiuKnygele()
        {

        }

        public PazymiuKnygele(Studentas studentas, Dictionary<Pamoka, List<int>> pazymiai)
        {
            Studentas = studentas;
            Pazymiai = pazymiai;
        }

        public Studentas Studentas { get; set; }
        public Dictionary<Pamoka, List<int>> Pazymiai { get; set; }
    }
}
