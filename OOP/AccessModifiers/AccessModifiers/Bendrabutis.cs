using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Bendrabutis
    {
        public int BendrabucioId { get; set; }
        public int KambariuSkaicius { get; set; }
        public int Kaina { get; set; }
        public List<Zmogus> Zmones { get; set; } = new List<Zmogus>();
    }
}
