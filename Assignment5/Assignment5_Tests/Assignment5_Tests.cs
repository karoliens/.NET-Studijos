namespace Assignment5_Tests
{
    [TestClass]
    public class Assignment5_Tests
    {
        [TestMethod]
        public void SudedaSkaicius1()
        {
            var fake1 = 1;
            var fake2 = 2;
            var expected = 3;

            var actual = Assignment5.Program.SudedaSkaicius(fake1, fake2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtimaSkaicius1()
        {
            var fake1 = 1;
            var fake2 = 2;
            var expected = -1;

            var actual = Assignment5.Program.AtimaSkaicius(fake1, fake2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DauginaSkaicius1()
        {
            var fake1 = 1;
            var fake2 = 2;
            var expected = 2;

            var actual = Assignment5.Program.DauginaSkaicius(fake1, fake2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DalinaSkaicius1()
        {
            var fake1 = 1;
            var fake2 = 2;
            var expected = 0.5;

            var actual = Assignment5.Program.DalinaSkaicius(fake1, fake2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrinaArDalinamaIsNulio1()
        {
            var fake = 0;
            var expected = "Dalyba iš 0 negalima";

            var actual = Assignment5.Program.TikrinaArDalinamaIsNulio(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrinaArIvestasSkaicius1()
        {
            var fake = "k";
            var expected = false;

            var actual = Assignment5.Program.TikrinaArIvestasSkaicius(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrinaArIvestasSkaicius2()
        {
            var fake = "0";
            var expected = true;

            var actual = Assignment5.Program.TikrinaArIvestasSkaicius(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrinaArIvestasSkaicius3()
        {
            var fake = "abc";
            var expected = false;

            var actual = Assignment5.Program.TikrinaArIvestasSkaicius(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeliaSkaiciuLaipsniu1()
        {
            var skaicius = 0;
            var laipsnis = 2;
            var expected = 0;

            var actual = Assignment5.Program.PakeliaSkaiciuLaipsniu(skaicius, laipsnis);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeliaSkaiciuLaipsniu2()
        {
            var skaicius = 5;
            var laipsnis = 1;
            var expected = 5;

            var actual = Assignment5.Program.PakeliaSkaiciuLaipsniu(skaicius, laipsnis);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeliaSkaiciuLaipsniu3()
        {
            var skaicius = 10;
            var laipsnis = 0;
            var expected = 1;

            var actual = Assignment5.Program.PakeliaSkaiciuLaipsniu(skaicius, laipsnis);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeliaSkaiciuLaipsniu4()
        {
            var skaicius = 3;
            var laipsnis = 3;
            var expected = 27;

            var actual = Assignment5.Program.PakeliaSkaiciuLaipsniu(skaicius, laipsnis);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeliaSkaiciuLaipsniu5()
        {
            var skaicius = 4;
            var laipsnis = 5;
            var expected = 1024;

            var actual = Assignment5.Program.PakeliaSkaiciuLaipsniu(skaicius, laipsnis);
            Assert.AreEqual(expected, actual);
        }
        /*
        [TestMethod()]
        public void SuperSkaiciuotuvasTest1()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            Program.Reset();
            foreach (var move in fake_moves)
            {
                Assignment5.Program.SuperSkaiciuotuvas(move);
            }
            var actual = Assignment5.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest2()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "3" };
            var expected = 60d;
            Assignment5.Program.Reset();
            foreach (var move in fake_moves)
            {
                Assignment5.Program.SuperSkaiciuotuvas(move);
            }
            var actual = Assignment5.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest3()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "1", "3", "2", "3", "3" };
            var expected = 6d;

            Assignment5.Program.Reset();
            foreach (var move in fake_moves)
            {
                Assignment5.Program.SuperSkaiciuotuvas(move);
            }
            var actual = Assignment5.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }*/

    }
}