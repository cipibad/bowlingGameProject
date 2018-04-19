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
        private void rollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                _game.roll(pins);
            }
        }

        [TestMethod]        
        public void testGutterGame()
        {
            rollMany(20, 0);
            Assert.AreEqual(0, _game.score());
        }

        [TestMethod]
        public void testAllOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, _game.score());
        }
    }
}
