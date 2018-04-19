using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowlingGame;

namespace bowlingGameTest
{
    [TestClass]
    public class gameTest
    {

        private Game _game;

        [TestInitialize()]
        public void Initialize() 
        {
            _game = new Game();
        }
        [TestMethod]
        public void testGutterGame()
        {
            for (int i=0; i<20; i++)
            {
                _game.roll(0);
            }
            Assert.AreEqual(0, _game.score());
        }
        [TestMethod]
        public void testAllOnes()
        {
            for (int i=0; i<20; i++) //FIXME duplicated loop
            {
                _game.roll(1);
            }
            Assert.AreEqual(20, _game.score());
        }
    }
}
