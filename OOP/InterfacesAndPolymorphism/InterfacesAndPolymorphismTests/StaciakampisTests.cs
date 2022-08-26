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
    public class StaciakampisTests
    {
        [TestMethod()]
        public void Perimetras_NiekoNepaduodame_ReturnsStaciakampioPerimetras()
        {
            double expected = 20;

            IGeometrija staciakampis = new Staciakampis(5, 5);

            double actual = staciakampis.Perimetras();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Plotas_NiekoNepaduodame_ReturnsStaciakampioPlotas()
        {
            double expected = 20;

            IGeometrija staciakampis = new Staciakampis(2, 10);

            double actual = staciakampis.Plotas();

            Assert.AreEqual(expected, actual);
        }
    }
}