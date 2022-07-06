namespace P011_Methods_Tests
{
    [TestClass]
    public class P011_Methods_Tests

    {
        [TestMethod]
        public void Skaiciuotuvas_Test1()
        {
            //fakes
            var pirmasSkaicius = 3;
            var antrasSkaicius = 2;
            //expected
            var expected = 6;
            //actual
            var actual = P011_Methods.Program.Skaiciuotuvas(pirmasSkaicius, antrasSkaicius, "*");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KeturkampioPlotoSkaiciavimas_Test1()
        {
            //fakes
            var krastiniuIlgis = 0.5;
            var krastiniuKiekis = 4;
            //expected
            var expected = 2;
            //actual
            var actual = P011_Methods.Program.KeturkampioPlotas(krastiniuKiekis, krastiniuIlgis);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TrikampioPlotoSkaiciavimas_Test1()
        {
            //fakes
            var krastiniuIlgis = 0.5;
            var aukstis = 3;
            //expected
            var expected = 0.75;
            //actual
            var actual = P011_Methods.Program.TrikampioPlotas(krastiniuIlgis, aukstis);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void VisuKituPlotoSkaiciavimas_Test1()
        {
            //fakes
            var krastiniuIlgis = 0.5;
            var krastiniuKiekis = 5;
            var statmuo = 3;
            //expected
            var expected = 3.75;
            //actual
            var actual = P011_Methods.Program.VisuKituPlotas(krastiniuKiekis, krastiniuIlgis, statmuo);

            Assert.AreEqual(expected, actual);
        }
    }
}