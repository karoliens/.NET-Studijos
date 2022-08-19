using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Kalbejimas
    {
        public Kalbejimas()
        {
            Garsas = "tuščia";
        }

        public Kalbejimas(string garsas)
        {
            Garsas = garsas;
        }

        public string Garsas { get; set; }

        public void Kalbeti()
        {
            Console.WriteLine(Garsas);
        }
    }
}
