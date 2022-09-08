using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inheritance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inheritance.InitialData;

namespace Inheritance.Models.Tests
{
    public class FakeRandom : Random
    {
        private int iterator = -1;
        public override int Next(int minValue, int maxValue)
        {
            iterator++;
            return iterator switch
            {
                0 => 2,
                1 => 0,
                2 => 0,
                3 => 3,
                4 => 2,
                5 => 5,
            };
        }
    }


    [TestClass()]
    public class UniversityPersonTests
    {
        [TestMethod()]
        public void SetHobbiesTest()
        {
            UniversityPerson person = new UniversityPerson(new FakeRandom());
            person.SetHobbies(HobbyInitialData.DataSeedCsv);

            Assert.AreEqual(2, person.Hobbies.Count);
            Assert.AreEqual("Astrology", person.Hobbies[0].Text);
            Assert.AreEqual("Blogging", person.Hobbies[1].Text);
        }
    }
}