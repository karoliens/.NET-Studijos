using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Bukle
    {
        private int amzius;

        public int Amzius
        {
            get { return amzius; }
            set { amzius = value; }
        }

        private bool arPaskolinta;

        public bool ArPaskolinta
        {
            get { return arPaskolinta; }
            set { arPaskolinta = value; }
        }

        private string kamPaskolinta;

        public string KamPaskolinta
        {
            get { return kamPaskolinta; }
            set { kamPaskolinta = value; }
        }
    }
}
