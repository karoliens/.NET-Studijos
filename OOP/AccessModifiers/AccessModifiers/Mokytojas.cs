using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Mokytojas
    {
        public Mokytojas()
        {

        }

        public Mokytojas(string vardas, List<Studentas> studentai, Mokykla mokykla, Pamoka pamoka)
        {
            Vardas = vardas;
            Studentai = studentai;
            Mokykla = mokykla;
            Pamoka = pamoka;
        }

        public string Vardas { get; set; }
        public List<Studentas> Studentai { get; set; }
        public Mokykla Mokykla { get; set; }
        public Pamoka Pamoka { get; set; }
    }
}
