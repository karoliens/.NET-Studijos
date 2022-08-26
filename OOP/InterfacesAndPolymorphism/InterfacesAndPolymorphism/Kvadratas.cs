using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public class Kvadratas : Figura, IGeometrija
    {
        public Kvadratas() { }
        public Kvadratas(int krastinesIlgis)
        {
            KrastinesIlgis = krastinesIlgis;
        }

        public int KrastinesIlgis { get; }

        public double Perimetras()
        {
            return KrastinesIlgis * 4;
        }

        public double Plotas()
        {
            return KrastinesIlgis * KrastinesIlgis;
        }
    }
}
