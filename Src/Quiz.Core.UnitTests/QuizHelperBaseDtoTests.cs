using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quiz.Core.UnitTests
{
    [TestClass]
    public class QuizHelperBaseDtoTests
    {
        [TestMethod]
        public void TotalQuestionsAnsweredCorrectlyTest()
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
