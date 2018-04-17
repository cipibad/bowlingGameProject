using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowlingGame;

namespace bowlingGameTest
{
    [TestClass]
    public class gameTest
    {

        private Game g; //FIXME bad naming

        [TestInitialize()]
        public void Initialize() 
        {
            g = new Game();
        }
        [TestMethod]
        public void testGutterGame()
        {
            for (int i=0; i<20; i++)
            {
                g.roll(0);
            }
            Assert.AreEqual(0, g.score());
        }
        [TestMethod]
        public void testAllOnes()
        {
            for (int i=0; i<20; i++) //FIXME duplicated loop
            {
                g.roll(1);
            }
            Assert.AreEqual(20, g.score());
        }
    }
}
