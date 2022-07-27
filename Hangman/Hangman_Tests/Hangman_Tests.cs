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
        }
    }
}