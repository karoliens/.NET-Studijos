namespace Assignment5_Tests
{
    [TestClass]
    public class Assignment5_Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

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
        }

    }
}