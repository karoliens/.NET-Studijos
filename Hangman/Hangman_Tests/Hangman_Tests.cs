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
        public void PanaikinaZodiIsSaraso1()
        {
            var fake1 = "Tomas";
            var fake2 = new string[] { "Jolanta", "Rolandas", "Ieva", "Greta", "Eglė", "Jonas", "Giedrė", "Jonas", "Tomas", "Armandas" };
            var expected = new string[] { "Jolanta", "Rolandas", "Ieva", "Greta", "Eglė", "Jonas", "Giedrė", "Jonas", "Armandas" };

            var actual = Hangman.Program.PanaikinaZodiIsSaraso(fake1, fake2);
            CollectionAssert.AreEqual(expected, actual);
        }
        

        [TestMethod]
        public void SpausdinaSpetasRaides1()
        {
            var fake1 = "karolis";
            var fake2 = 'x';
            var expected = 'x';

            var actual = Hangman.Program.SpausdinaSpetasRaides(fake1, fake2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpausdinaSpetasRaides2()
        {
            var fake1 = "karolis";
            var fake2 = 'k';
            var expected = ' ';

            var actual = Hangman.Program.SpausdinaSpetasRaides(fake1, fake2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TikrinaArRaideYraZodyje1()
        {
            var fake1 = "karolis";
            var fake2 = 'k';
            var expected = true;

            var actual = Hangman.Program.TikrinaArRaideYraZodyje(fake1, fake2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ParenkaSarasa1()
        {
            var fake = "1";
            var expected = new string[] { "Jolanta", "Rolandas", "Ieva", "Greta", "Eglė", "Jonas", "Giedrė", "Jonas", "Tomas", "Armandas" };

            var actual = Hangman.Program.ParenkaSarasa(fake);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}