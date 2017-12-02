using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Core;

namespace Quiz.Ui.UnitTests
{
    [TestClass]
    public class QuizHelperTests
    {
        [DataRow(5, 20, 25)]
        [DataRow(1, 1, 100)]
        [DataRow(0, 1, 0)]
        [DataRow(1, 0, 0)]
        [DataRow(0, 0, 0)]
        [DataRow(null, 0, 0)]
        [DataRow(0, null, 0)]
        [DataRow(null, 1, 0)]
        [DataRow(1, null, 0)]
        [DataTestMethod]
        public void GetPercentageSuccessTest(int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked, int expected)
        {
            Assert.AreEqual(expected, QuizHelperCore.GetPercentageSuccess(totalQuestionsAnsweredCorrectly, totalQuestionsAsked));
        }
    }
}
