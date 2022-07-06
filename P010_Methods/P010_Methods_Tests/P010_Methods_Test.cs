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
        public void TekstoIlgis1_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 22;
            var actual = P010_Methods.Program.TekstoIlgis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TekstoIlgis_Test2()
        {
            var fake = " as mokausi programuoti ";
            var expected = 22;
            var actual = P010_Methods.Program.TekstoIlgis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TekstoIlgis_Test3()
        {
            var fake = " as mokausi programuoti     ";
            var expected = 22;
            var actual = P010_Methods.Program.TekstoIlgis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiGale_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 0;
            var actual = P010_Methods.Program.TarpaiGale(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiGale_Test2()
        {
            var fake = " as mokausi programuoti ";
            var expected = 1;
            var actual = P010_Methods.Program.TarpaiGale(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiGale_Test3()
        {
            var fake = " as mokausi programuoti     ";
            var expected = 5;
            var actual = P010_Methods.Program.TarpaiGale(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiPradzioj_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 0;
            var actual = P010_Methods.Program.TarpaiPradzioj(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiPradzioj_Test2()
        {
            var fake = " as mokausi programuoti ";
            var expected = 1;
            var actual = P010_Methods.Program.TarpaiPradzioj(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiPradzioj_Test3()
        {
            var fake = "    as mokausi programuoti     ";
            var expected = 4;
            var actual = P010_Methods.Program.TarpaiPradzioj(fake);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void AKiekis_Test1()
        {
            var fake = "as mokausi programuoti";
            var expected = 3;
            var actual = P010_Methods.Program.AKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AKiekis_Test2()
        {
            var fake = " as  aa mokausi programuoti ";
            var expected = 5;
            var actual = P010_Methods.Program.AKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AKiekis_Test3()
        {
            var fake = "a    as mokausi programuoti     a";
            var expected = 5;
            var actual = P010_Methods.Program.AKiekis(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNe_Test1()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNe(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNe_Test2()
        {
            var fake = " as labai mokausiprogramuoti     ";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNe(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PirmosARaidesIndex_Test1()
        {
            var fake = " as labai mokausiprogramuoti     ";
            var expected = 1;
            var actual = P010_Methods.Program.PirmosARaidesIndex(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test1()
        {
            var fake = " as labai mokausi programuoti     ";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test2()
        {
            var fake = "aslabaimokausiprogramuoti";
            var expected = "ne";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test3()
        {
            var fake = "mokausi programuoti labai    ";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test4()
        {
            var fake = "as mokausi, labai stipriai";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test5()
        {
            var fake = "as mokausi!";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test6()
        {
            var fake = "as mokausi?";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test7()
        {
            var fake = "as studijuoju (mokausi)";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test8()
        {
            var fake = "as studijuojumokausi)";
            var expected = "ne";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test9()
        {
            var fake = "Aš mokausilabaisunkiai.";
            var expected = "ne";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test10()
        {
            var fake = "Labaimokausi programuoti.";
            var expected = "ne";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TaipArbaNeNesulipes_Test11()
        {
            var fake = "Aš \"mokausi\" programuoti ";
            var expected = "taip";
            var actual = P010_Methods.Program.TaipArbaNeNesulipes(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}