using Microsoft.VisualStudio.TestTools.UnitTesting;
using bowlingGame;

namespace bowlingGameTest
{
    [TestClass]
    public class AdderService_addTest
    {
        private readonly AdderService _adderService;

        public AdderService_addTest()
        {
            _adderService = new AdderService();
        }
        [TestMethod]
        public void Return2GivenValueOf1And1()
        {
            var result = _adderService.add(1,1);
            Assert.AreEqual (2, result, "1 added to 1 should return 2");
        }
    }
}
