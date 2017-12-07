using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Core.UnitTests
{
    [TestClass]
    public class QuizHelperCoreTests
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

        [TestMethod]
        public void GetPopulatedAnswersTest1()
        {
            Assert.AreEqual(null, QuizHelperCore.GetPopulatedAnswers(null));
        }

        [TestMethod]
        public void GetPopulatedAnswersTest2()
        {
            var multipleChoiceAnswers = new List<string> { "", "   ", string.Empty, null };
            Assert.AreEqual(null, QuizHelperCore.GetPopulatedAnswers(null));
        }

        [TestMethod]
        public void GetPopulatedAnswersTest3()
        {
            // Arrange
            var multipleChoiceAnswers = new List<string> { "", string.Empty, "a" };

            // Act
            var actual = QuizHelperCore.GetPopulatedAnswers(multipleChoiceAnswers);

            // Assert
            Assert.AreEqual(1, actual.ToList().Count);
            Assert.AreEqual("a", actual.First());
        }

        [TestMethod]
        public void GetPopulatedAnswersTest4()//gregt handle a result of 2 entries !!!
        {
            // Arrange
            var multipleChoiceAnswers = new List<string> { "", string.Empty, "a", "b" };

            // Act
            var actual = QuizHelperCore.GetPopulatedAnswers(multipleChoiceAnswers);

            // Assert
            var actualList = actual.ToList();
            Assert.AreEqual(2, actualList.Count);
            Assert.IsTrue(actualList.Contains("a"));
            Assert.IsTrue(actualList.Contains("b"));
        }



    }
}
