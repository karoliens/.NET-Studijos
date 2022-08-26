using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterfacesAndPolymorphism;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndPolymorphism.Tests
{
    [TestClass()]
    public class ApskritimasTests
    {
        [TestMethod()]
        public void Perimetras_NiekoNeperduodame_ReturnsApskritimoPerimetras()
        {
            var expected = 31.41592653589793;

            IGeometrija apskritimas = new Apskritimas(5);

            double actual = apskritimas.Perimetras();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Plotas_NiekoNeperduodame_ReturnsApskritimoPlotas()
        {
            var expected = 7.024814731040727;

            IGeometrija apskritimas = new Apskritimas(5);

            double actual = apskritimas.Plotas();

            Assert.AreEqual(expected, actual);
        }
    }
}