using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_11_NamuDarbas_2
{
    internal class SkaiciuKrepselis
    {
        private List<int> skaiciuSarasas;

        public void PridėtiSkaiciu(int skaicius)
        {
            skaiciuSarasas.Add(skaicius);
        }

        public double ApskaiciuotiVidurki()
        {
            int suma = 0;

            foreach(var skaicius in skaiciuSarasas)
            {
                suma = suma + skaicius;
            }

            return suma / skaiciuSarasas.Count();
        }
    }
}
