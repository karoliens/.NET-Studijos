using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public class StatusisTrikampis : Figura, IGeometrija
    {
        public StatusisTrikampis() { }

        public StatusisTrikampis(int krastinesAIlgis, int krastinesBIlgis, int krastinesCIlgis)
        {
            KrastinesAIlgis = krastinesAIlgis;
            KrastinesBIlgis = krastinesBIlgis;
            KrastinesCIlgis = krastinesCIlgis;
        }

        public int KrastinesAIlgis { get; }
        public int KrastinesBIlgis { get; }
        public int KrastinesCIlgis { get; }

        public double Perimetras()
        {
            return KrastinesAIlgis + KrastinesBIlgis + KrastinesCIlgis;
        }

        public double Plotas()
        {
            return ((double)KrastinesAIlgis * KrastinesBIlgis) / 2;
        }
    }
}
