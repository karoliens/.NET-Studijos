namespace Hangman_Tests
{
    [TestClass]
    public class Hangman_Tests
    {
        [TestMethod]
        public void SpausdinaPiesini1()
        {
            var fake = 7;
            var expected = @"   - - - - - - |   
|              
|              
|              
|               
|
|
|
_ _ _ _";

            var actual = Hangman.Program.SpausdinaPiesini(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PakeiciaIBruksnelius1()
        {
            var fake = "karolis";
            var expected = new char[] { '_', '_', '_', '_', '_', '_', '_' };

            var actual = Hangman.Program.PakeiciaIBruksnelius(fake);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrinaMenuPasirinkima1()
        {
            var fake = "5";
            var expected = "5 temos nėra, bandykite iš naujo";

            var actual = Hangman.Program.TikrinaMenuPasirinkima(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrinaMenuPasirinkima2()
        {
            var fake = "a";
            var expected = "a temos nėra, bandykite iš naujo";

            var actual = Hangman.Program.TikrinaMenuPasirinkima(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PanaikinaZodiIsSaraso1()
        {
            var fake1 = "Tomas";
            var fake2 = new List<string> { "Jolanta", "Rolandas", "Ieva", "Greta", "Eglė", "Jonas", "Giedrė", "Jonas", "Tomas", "Armandas" };
            var expected = new List<string> { "Jolanta", "Rolandas", "Ieva", "Greta", "Eglė", "Jonas", "Giedrė", "Jonas", "Armandas" };

            var actual = Hangman.Program.PanaikinaZodiIsSaraso(fake1, fake2);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}