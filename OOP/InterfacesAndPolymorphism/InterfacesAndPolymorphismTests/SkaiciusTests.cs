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
    public class SkaiciusTests
    {
        [TestMethod()]
        public void Prideti_SveikajiSkaiciu_ReturnsSudetasRezultatas()
        {
            int expected = 10;

            Skaicius penketas = new Skaicius(5);

            int actual = penketas.Prideti(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Atimti_SveikajiSkaiciu_ReturnsAtimtasRezultatas()
        {
            int expected = 7;

            IMatematika desimt = new Skaicius(10);

            int actual = desimt.Atimti(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Padalinti_SveikajiSkaiciu_ReturnsDalybosRezultatas()
        {
            double expected = 2.5;

            IMatematika desimt = new Skaicius(10);

            double actual = desimt.Padalinti(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Padauginti_SveikajiSkaiciu_ReturnsDaugybosRezultatas()
        {
            int expected = 30;

            IMatematika desimt = new Skaicius(10);

            int actual = desimt.Padauginti(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PakeltiKubu_SveikajiSkaiciu_ReturnsPakeltasKubuRezultatas()
        {
            int expected = 1000;

            IMatematika desimt = new Skaicius(10);

            int actual = desimt.PakeltiKubu();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PakeltiKvadratu_SveikajiSkaiciu_ReturnsPakeltasKvadratuRezultatas()
        {
            int expected = 100;

            IMatematika desimt = new Skaicius(10);

            int actual = desimt.PakeltiKvadratu();

            Assert.AreEqual(expected, actual);
        }
    }
}