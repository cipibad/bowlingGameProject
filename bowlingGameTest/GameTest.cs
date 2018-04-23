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
            for (int i = 0; i < 20; i++)
            {
                g = g.roll(0);
            }
            Assert.AreEqual(0, g.score());
        }

        // [TestMethod]
        // public void testAllOnes()
        // {
        //     rollMany(20, 1);
        //     Assert.AreEqual(20, _game.score());
        // }

        // [TestMethod]
        // public void testOneSpare()
        // {
        //     rollSpare();
        //     _game.roll(3);
        //     rollMany(17,0);
        //     Assert.AreEqual(16, _game.score());
        // }

        // [TestMethod]
        // public void testOneStrike()
        // {
        //     rollStrike();
        //     _game.roll(3);
        //     _game.roll(4);
        //     rollMany(16,0);
        //     Assert.AreEqual(24, _game.score());
        // }
        // [TestMethod]
        // public void testPerfectGame()
        // {
        //     rollMany(12,10);
        //     Assert.AreEqual(300, _game.score());
        // }

        // private void rollStrike()
        // {
        //     _game.roll(10);
        // }

        // private void rollSpare()
        // {
        //     _game.roll(5);
        //     _game.roll(5);
        // }
    }
}
