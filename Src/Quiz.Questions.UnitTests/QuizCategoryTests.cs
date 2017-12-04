using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Questions.Entities;
using System.Linq;
using Quiz.Questions.CategoryQuestions.CSharp;
using Quiz.Questions.CategoryQuestions.DotNet;
using Quiz.Questions.CategoryQuestions.FrontEnd;
using Quiz.Questions.CategoryQuestions.Geek;
using Quiz.Questions.CategoryQuestions.Javascript;

namespace Quiz.Questions.UnitTests
{
    [TestClass]
    public class QuizCategoryTests
    {
        [TestMethod]
        public void CSharpQuestionsQuestionsTest()
        {
            // Arrange
            var sut = new CSharpQuestions();

            // Act
            var actual = sut.GetQuizQuestions();

            // Assert
            Assert.AreEqual(0, actual.Where(x => x.Category != Category.CSharp).Count());
        }

        [TestMethod]
        public void DotNetQuestionsTest()
        {
            // Arrange
            var sut = new DotNetQuestions();

            // Act
            var actual = sut.GetQuizQuestions();

            // Assert
            Assert.AreEqual(0, actual.Where(x => x.Category != Category.DotNet).Count());
        }

        [TestMethod]
        public void GeekQuestionsTest()
        {
            // Arrange
            var sut = new GeekQuestions();

            // Act
            var actual = sut.GetQuizQuestions();

            // Assert
            Assert.AreEqual(0, actual.Where(x => x.Category != Category.Geek).Count());
        }

        [TestMethod]
        public void JavascriptQuestionsTest()
        {
            // Arrange
            var sut = new JavascriptQuestions();

            // Act
            var actual = sut.GetQuizQuestions();

            // Assert
            Assert.AreEqual(0, actual.Where(x => x.Category != Category.Javascript).Count());
        }

        [TestMethod]
        public void FrontEndQuestionsTest()
        {
            // Arrange
            var sut = new FrontEndQuestions();

            // Act
            var actual = sut.GetQuizQuestions();

            // Assert
            Assert.AreEqual(0, actual.Where(x => x.Category != Category.FrontEnd).Count());
        }
    }
}
