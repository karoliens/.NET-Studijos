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
    public class KvadratasTests
    {
        [TestMethod()]
        public void Perimetras_NiekoNeperduodame_ReturnsKvadratoPerimetras()
        {
            // Arrange
            double expected = 20;
            IGeometrija kvadratas = new Kvadratas(5);

            // Act
            double actual = kvadratas.Perimetras();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Plotas_NiekoNeperduodame_ReturnsKvadratoPlotas()
        {
            // Arrange
            double expected = 25;
            IGeometrija kvadratas = new Kvadratas(5);

            // Act
            double actual = kvadratas.Plotas();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}