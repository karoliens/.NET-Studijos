using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Mokykla
    {
        public Mokykla()
        {

        }

        public Mokykla(string pavadinimas, List<Mokytojas> mokytojai)
        {
            Pavadinimas = pavadinimas;
            Mokytojai = mokytojai;
        }

        public string Pavadinimas { get; set; }
        public List<Mokytojas> Mokytojai { get; set; }
    }
}
