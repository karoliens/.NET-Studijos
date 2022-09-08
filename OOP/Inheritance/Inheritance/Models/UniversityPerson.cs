using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class UniversityPerson : Person
    {
        private Random _rnd;

        public UniversityPerson()
        {
            _rnd = new Random();
        }

        public UniversityPerson(Random rnd)
        {
            _rnd = rnd;
        }

        public void SetHobbies(string[] data)
        {
            Hobbies = new List<Hobby>();
            var indexesTaken = new List<int>();
            int hobbiesCount = _rnd.Next(0, 5);

            for (int i = 0; i < hobbiesCount; i++)
            {
                int hobbyIndex;

                do
                {
                    hobbyIndex = _rnd.Next(0, data.Length);
                }
                while(indexesTaken.Contains(hobbyIndex));
                

                indexesTaken.Add(hobbyIndex);
            }
        }

        public void SetProfession(Profession[] data)
        {
            var randomProfessionIndex = _rnd.Next(0, data.Length);

            Profession = data[randomProfessionIndex];
        }

        public void SetProfession(string[] data)
        {
            var randomProfessionIndex = _rnd.Next(0, data.Length);

            Profession = new Profession(randomProfessionIndex);
        }

        public virtual Profession Profession { get; set; }
        public List<Hobby> Hobbies { get; set; }
    }
}
