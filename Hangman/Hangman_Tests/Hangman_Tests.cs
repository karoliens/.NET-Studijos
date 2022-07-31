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

            var actual = Hangman.Program.ArRaideYraZodyje(fake1, fake2);
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

        [TestMethod]
        public void ArChar1()
        {
            var fake = "karolis";
            var expected = false;

            var actual = Hangman.Program.ArChar(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArChar2()
        {
            var fake = "k";
            var expected = true;

            var actual = Hangman.Program.ArChar(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArChar3()
        {
            string fake = "";
            var expected = false;

            var actual = Hangman.Program.ArChar(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArChar4()
        {
            string fake = null;
            var expected = false;

            var actual = Hangman.Program.ArChar(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArSkaicius1()
        {
            var fake = "1";
            var expected = true;

            var actual = Hangman.Program.ArSkaicius(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArSkaicius2()
        {
            string fake = null;
            var expected = false;

            var actual = Hangman.Program.ArSkaicius(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtverciaRaides1()
        {
            var fake1 = "karolis";
            var fake2 = 'k';
            var expected = new char[] { 'k', '_', '_', '_', '_', '_', '_' };

            var actual = Hangman.Program.AtverciaRaides(fake1, fake2);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AtverciaRaides2()
        {
            var fake1 = "karolis";
            var fake2 = 'r';
            var expected = new char[] { '_', '_', 'r', '_', '_', '_', '_' };

            var actual = Hangman.Program.AtverciaRaides(fake1, fake2);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArTeisingasMenuPasirinkimas1()
        {
            var fake = "1";
            var expected = true;

            var actual = Hangman.Program.ArTeisingasMenuPasirinkimas(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArTeisingasMenuPasirinkimas2()
        {
            var fake = "5";
            var expected = false;

            var actual = Hangman.Program.ArTeisingasMenuPasirinkimas(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArSpejimasValidus1()
        {
            var fake = "1";
            var expected = false;

            var actual = Hangman.Program.ArSpejimasValidus(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArSpejimasValidus2()
        {
            var fake = "a";
            var expected = true;

            var actual = Hangman.Program.ArSpejimasValidus(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArSpejimasValidus3()
        {
            var fake = "";
            var expected = false;

            var actual = Hangman.Program.ArSpejimasValidus(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArSpejimasValidus4()
        {
            var fake = "a;";
            var expected = true;

            var actual = Hangman.Program.ArSpejimasValidus(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}