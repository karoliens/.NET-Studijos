using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P018_Composition
{
    internal class Salis
    {
        public int Plotas { get; set; }
        public string Kalba { get; set; }
        public int GyventojuSkaicius { get; set; }
        public Miestas miestas { get; set; }
    }
}
