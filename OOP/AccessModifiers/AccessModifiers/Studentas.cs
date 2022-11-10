using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Studentas
    {
        public Studentas()
        {

        }

        public Studentas(string vardas, PazymiuKnygele pazymiuKnygele, List<Mokytojas> mokytojai)
        {
            Vardas = vardas;
            PazymiuKnygele = pazymiuKnygele;
            Mokytojai = mokytojai;
        }

        public string Vardas { get; set; }
        public PazymiuKnygele PazymiuKnygele { get; set; }
        public List<Mokytojas> Mokytojai { get; set; }
    }
}
