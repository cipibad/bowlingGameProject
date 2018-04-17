using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowlingGame;

namespace bowlingGameTest
{
    [TestClass]
    public class gameTest
    {

        [TestMethod]
        public void testGutterGame()
        {
            Game g = new Game();
            for (int i=0; i<20; i++)
            {
                g.roll(0);
            }
            Assert.AreEqual(0, g.score());
        }
        [TestMethod]
        public void testAllOnes()
        {
            Game g = new Game(); //FIXME duplicated initialisation
            for (int i=0; i<20; i++) //FIXME duplicated loop
            {
                g.roll(1);
            }
            Assert.AreEqual(20, g.score());
        }
    }
}
