using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public class Staciakampis : Figura, IGeometrija
    {
        public Staciakampis() { }
        public Staciakampis(int krastinesAIlgis, int krastinesBIlgis)
        {
            KrastinesAIlgis = krastinesAIlgis;
            KrastinesBIlgis = krastinesBIlgis;
        }

        public int KrastinesAIlgis { get; }
        public int KrastinesBIlgis { get; }

        public double Perimetras()
        {
            return (KrastinesAIlgis * 2) + (KrastinesBIlgis * 2);
        }

        public double Plotas()
        {
            return KrastinesAIlgis * KrastinesBIlgis;
        }
    }
}
