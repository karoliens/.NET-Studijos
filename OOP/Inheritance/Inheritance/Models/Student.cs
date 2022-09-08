using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Student : UniversityPerson
    {
        private Profession profession;

        public override Profession Profession
        {
            get { return profession; }
            set { profession = value; }
        }

    }
}
