using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiz.Ui.UnitTests
{
    [TestClass]
    public class QuizHelperTests
    {
        [TestMethod]
        public void GetPercentageSuccess2Test()
        {
            Assert.AreEqual(25, QuizHelper.GetPercentageSuccess2(5, 20));
        }
    }
}