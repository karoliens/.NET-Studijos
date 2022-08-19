using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_11_NamuDarbas_2
{
    internal class SkaiciuKrepselis
    {
        private List<int> SkaiciuSarasas;

        public void PridetiSkaiciu(int skaicius)
        {
            SkaiciuSarasas.Add(skaicius);
        }

        public double ApskaiciuotiVidurki(List<int> skaiciuSarasas)
        {
            var sum = 0;

            foreach (var skaicius in skaiciuSarasas)
            {
                sum += skaicius;
            }

            return sum / skaiciuSarasas.Count();
        }
    }
}
