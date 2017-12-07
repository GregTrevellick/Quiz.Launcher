using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiz.Core.UnitTests
{
    [TestClass]
    public class QuizHelperBaseDtoTests
    {
        [TestMethod]
        public void TotalQuestionsAnsweredCorrectlyTest(int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked, int expected)
        {
            // Arrange
            var sut = new QuizHelperBaseDto
            {
                TotalQuestionsAnsweredCorrectlyEasy = 1,
                TotalQuestionsAnsweredCorrectlyMedium = 2,
                TotalQuestionsAnsweredCorrectlyHard = 3
            };
            
            // Act / Assert
            Assert.AreEqual(6, sut.TotalQuestionsAnsweredCorrectly);
        }
    }
}
