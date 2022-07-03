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


        [TestMethod]
        public void AKiekis1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P010_Methods.Program.AKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AKiekis2()
        {
            var fake = " as  aa mokausi programuoti ";
            var expected = 5;
            var actual = P010_Methods.Program.AKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AKiekis3()
        {
            var fake = "a    as mokausi programuoti     a";
            var expected = 5;
            var actual = P010_Methods.Program.AKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNe1()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNe(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNe2()
        {
            var fake = " as labai mokausiprogramuoti     ";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNe(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PirmosARaidesIndex1()
        {
            var fake = " as labai mokausiprogramuoti     ";
            var expected = 1;
            var actual = P010_Methods.Program.PirmosARaidesIndex(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes1()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes2()
        {
            var fake = "aslabaimokausiprogramuoti";
            var expected = "ne";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes3()
        {
            var fake = "mokausi programuoti labai    ";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes4()
        {
            var fake = "as mokausi, labai stipriai";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes5()
        {
            var fake = "as mokausi!";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes6()
        {
            var fake = "as mokausi?";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes7()
        {
            var fake = "as studijuoju (mokausi)";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes8()
        {
            var fake = "as studijuojumokausi)";
            var expected = "ne";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}