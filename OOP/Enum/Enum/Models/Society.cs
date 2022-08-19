using Praktika.InitialData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika.Models
{
    public class Society
    {
        public List<Person> People;
        public void FillPeople()
        {
            People = PersonInitialData.DataSeed.ToList();
        }
        public List<Person> OldPeople
        {
            get
            {
                var lst = new List<Person>();
                foreach(var p in People)
                {
                    if (p.BirthDate < new DateTime(2001,1,1))
                        lst.Add(p);
                }
                return lst;
            }
        }
        public List<Person> Men;
        public List<Person> Women;
        public void FillMen()
        {
            Men = PersonInitialData.DataSeed.ToList();
        }
        public void FillWomen()
        {
            Women = PersonInitialData.DataSeed.ToList();
        }
    }
}
