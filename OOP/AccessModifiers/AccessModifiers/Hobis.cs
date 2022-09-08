using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Hobis
    {
        public Hobis() { }

        public Hobis(int id, string tekstasLietuviskai, string tesktasAngliskai)
        {
            Id = id;
            TekstasLietuviskai = tekstasLietuviskai;
            TekstasAngliskai = tesktasAngliskai;
        }

        public int Id { get; private set; }
        public string TekstasLietuviskai { get; private set; }
        public string TekstasAngliskai { get; set; }

    }
}
