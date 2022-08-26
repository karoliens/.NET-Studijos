using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public interface IGeometrija
    {
        public double Plotas();
        public double Perimetras();
    }

    public class Figura
    {
        public string Pavadinimas { get; }

        public Figura() { }

        public Figura(string pavadinimas)
        {
            Pavadinimas = pavadinimas;
        }
    }
}
