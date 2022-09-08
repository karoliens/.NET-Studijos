using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Domain.Models.Tests
{
    [TestClass()]
    public class CordinateTests
    {
        // AddNode_AddingNewNode_ReturnsNewCount

        [TestMethod()]
        public void GetCordinateTest()
        {
            var expected = "20 30";

            var cordinateString = new Cordinate<string>("20", "30");

            var actual = cordinateString.GetCordinate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetCordinateTest1()
        {
            var expected = "20 50";

            var cordinateInt = new Cordinate<int>(20, 50);

            var actual = cordinateInt.GetCordinate();

            Assert.AreEqual(expected, actual);
        }
    }
}