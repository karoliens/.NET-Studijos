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
    public class StatusisTrikampisTests
    {
        [TestMethod()]
        public void Perimetras_NiekoNeperduodame_ReturnsStaciojotrikampioPerimetras()
        {
            var expected = 15;

            IGeometrija statusisTrikampis = new StatusisTrikampis(5, 5, 5);

            double actual = statusisTrikampis.Perimetras();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Plotas_NiekoNeperduodame_ReturnsStaciojotrikampioPlotas()
        {
            var expected = 12.5;

            IGeometrija statusisTrikampis = new StatusisTrikampis(5, 5, 5);

            double actual = statusisTrikampis.Plotas();

            Assert.AreEqual(expected, actual);
        }
    }
}