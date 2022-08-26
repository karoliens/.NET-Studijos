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
    public class EmployeeTests
    {
        [TestMethod()]
        public void IsgautiAlga_NiekoNepaduodame_ReturnsIsgautiAlga()
        {
            var expected = 800;

            IPayable employee = new Employee(800);

            var actual = employee.IsgautiAlga();    

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsgautiUzmokescioAdresa_NiekoNepaduodame_ReturnsUzmokescioAdresa()
        {
            var expected = "Linkmenų g. 58-177";

            IPayable employee = new Employee("Linkmenų g. 58-177");

            var actual = employee.IsgautiUzmokescioAdresa();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PadidintiAlga_NiekoNepaduodame_ReturnsPadidintiAlga()
        {
            var expected = 1200;

            IPayable employee = new Employee(800);

            var actual = employee.PadidintiAlga(400);

            Assert.AreEqual(expected, actual);
        }
    }
}