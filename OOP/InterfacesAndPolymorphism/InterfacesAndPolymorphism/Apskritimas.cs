using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public class Apskritimas : Figura, IGeometrija
    {
        public int SpindulioIlgis { get; }

        public Apskritimas() { }
        public Apskritimas(int spindulioIlgis)
        {
            SpindulioIlgis = spindulioIlgis;
        }

        public double Perimetras()
        {
            return 2 * Math.PI * SpindulioIlgis;
        }

        public double Plotas()
        {
            return Math.PI * Math.Sqrt(SpindulioIlgis);
        }
    }
}