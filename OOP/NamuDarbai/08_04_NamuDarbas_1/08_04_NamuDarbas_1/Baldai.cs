using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Baldai
    {
        private bool yraSofa;

        public bool YraSofa
        {
            get { return yraSofa; }
            set { yraSofa = value; }
        }

        private bool yraTelevizorius;

        public bool YraTelevizorius
        {
            get { return yraTelevizorius; }
            set { yraTelevizorius = value; }
        }

        private bool yraStalas;

        public bool YraStalas
        {
            get { return yraStalas; }
            set { yraStalas = value; }
        }

        private int kedziuSkaicius;

        public int KedziuSKaicius
        {
            get { return kedziuSkaicius; }
            set { kedziuSkaicius = value; }
        }

        private int spinteliuSkaicius;

        public int SpinteliuSkaicius
        {
            get { return spinteliuSkaicius; }
            set { spinteliuSkaicius = value; }
        }
    }
}
