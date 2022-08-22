using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Namas
    {
        public Namas()
        {
            plotas = 0;
            vieta = "nežinoma";
            kambariuSkaicius = 0;
        }

        public Namas(int plotas, string vieta, int kambariuSkaicius, Stogas stogas)
        {
            this.plotas = plotas;
            this.vieta = vieta;
            this.kambariuSkaicius = kambariuSkaicius;
            this.stogas = stogas;
        }

        public Namas(int plotas, string vieta)
        {
            this.plotas = plotas;
            this.vieta = vieta;
        }

        private Stogas stogas;

        public Stogas Stogas
        {
            get { return stogas; }
            set { stogas = value; }
        }

        public int plotas;
        public string vieta;
        public int kambariuSkaicius;
    }
}
