using Microsoft.VisualStudio.TestTools.UnitTesting;
using LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void FilterEvenNumbersTest()
        {
            List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var actual = Program.FilterEvenNumbers(numbers);
            var expected = new List<int> { 0, 2, 4, 6, 8 };

            CollectionAssert.AreEqual(actual,expected);
        }
    }
}