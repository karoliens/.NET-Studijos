﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class PazymiuKnygele
    {
        public Studentas Studentas { get; set; }
        public Dictionary<Pamoka, List<int>> Pamokos { get; set; }
    }
}
