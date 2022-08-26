using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism
{
    public interface IMatematika
    {
        public int Prideti(int skaicius);
        public int Atimti(int skaicius);
        public int Padauginti(int skaicius);
        public double Padalinti(int skaicius);
        public int PakeltiKvadratu();
        public int PakeltiKubu();
    }

    public class Skaicius : IMatematika
    {
        public int SveikasisSkaicius { get; }

        public Skaicius() { }

        public Skaicius(int sveikasisSkaicius)
        {
            SveikasisSkaicius = sveikasisSkaicius;
        }

        public int Prideti(int skaicius)
        {
            return SveikasisSkaicius + skaicius;
        }

        public int Atimti(int skaicius)
        {
            return SveikasisSkaicius - skaicius;
        }

        public double Padalinti(int skaicius)
        {
            return (double)SveikasisSkaicius / skaicius;
        }

        public int Padauginti(int skaicius)
        {
            return SveikasisSkaicius * skaicius;
        }

        public int PakeltiKubu()
        {
            return SveikasisSkaicius * SveikasisSkaicius * SveikasisSkaicius;
        }

        public int PakeltiKvadratu()
        {
            return SveikasisSkaicius * SveikasisSkaicius;
        }
    }
}
