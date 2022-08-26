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
            garsas = garsas;
        }

        public string Garsas { get; set; }

        // private string garsas;

        public void Kalbeti()
        {
            Console.WriteLine(Garsas);
        }
    }
}
