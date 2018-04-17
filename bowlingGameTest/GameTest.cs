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
        }
    }
}
