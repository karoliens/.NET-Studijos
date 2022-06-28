namespace P010_Methods_Tests
{
    [TestClass]
    public class P010_Methods_Test
    {
        [TestMethod]
        public void ZodziuKiekis_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P010_Methods.Program.ZodziuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZodziuKiekis_Test2()
        {
            var fake = "as mokausi programuoti                                ";
            var expected = 3;
            var actual = P010_Methods.Program.ZodziuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ZodziuKiekis_Test3()
        {
             var fake = "as mokausi        programuoti                                ";
             var expected = 3;
             var actual = P010_Methods.Program.ZodziuKiekis(fake);
             Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void TarpuKiekis_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 2;
            var actual = P010_Methods.Program.TarpuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpuKiekis_Test2()
        {
            var fake = " as mokausi programuoti ";
            var expected = 4;
            var actual = P010_Methods.Program.TarpuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpuKiekis_Test3()
        {
            var fake = " as mokausi programuoti     ";
            var expected = 8;
            var actual = P010_Methods.Program.TarpuKiekis(fake);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TekstoIlgis1()
        {
            var fake = "as mokausi programuoti";
            var expected = 22;
            var actual = P010_Methods.Program.TekstoIlgis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TekstoIlgis2()
        {
            var fake = " as mokausi programuoti ";
            var expected = 22;
            var actual = P010_Methods.Program.TekstoIlgis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TekstoIlgis3()
        {
            var fake = " as mokausi programuoti     ";
            var expected = 22;
            var actual = P010_Methods.Program.TekstoIlgis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiGalle1()
        {
            var fake = "as mokausi programuoti";
            var expected = 0;
            var actual = P010_Methods.Program.TarpaiGale(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiGale2()
        {
            var fake = " as mokausi programuoti ";
            var expected = 1;
            var actual = P010_Methods.Program.TarpaiGale(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiGale3()
        {
            var fake = " as mokausi programuoti     ";
            var expected = 5;
            var actual = P010_Methods.Program.TarpaiGale(fake);
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void TarpaiPradzioj1()
        {
            var fake = "as mokausi programuoti";
            var expected = 0;
            var actual = P010_Methods.Program.TarpaiPradzioj(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiPradzioj2()
        {
            var fake = " as mokausi programuoti ";
            var expected = 1;
            var actual = P010_Methods.Program.TarpaiPradzioj(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiPradzioj3()
        {
            var fake = "    as mokausi programuoti     ";
            var expected = 4;
            var actual = P010_Methods.Program.TarpaiPradzioj(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}