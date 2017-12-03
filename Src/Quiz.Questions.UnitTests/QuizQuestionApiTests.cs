using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Questions.Entities;

namespace Quiz.Questions.UnitTests
{
    [TestClass]
    public class QuizQuestionApiTests
    {
        [DataRow(null, DifficultyLevel.Medium)]
        [DataRow("", DifficultyLevel.Medium)]
        [DataRow("easy", DifficultyLevel.Easy)]
        [DataRow("Easy", DifficultyLevel.Easy)]
        [DataRow("medium", DifficultyLevel.Medium)]
        [DataRow("Medium", DifficultyLevel.Medium)]
        [DataRow("hard", DifficultyLevel.Hard)]
        [DataRow("Hard", DifficultyLevel.Hard)]
        [DataRow("abc", DifficultyLevel.Medium)]
        [DataRow("hARD", DifficultyLevel.Hard)]
        [DataRow("Difficulty:Hard", DifficultyLevel.Medium)]
        [DataRow("Difficulty: Hard", DifficultyLevel.Hard)]
        [DataTestMethod]
        public void GetDifficultyLevelTest(string str, DifficultyLevel expected)
        {
            Assert.AreEqual(expected, new QuizQuestionApi().GetDifficultyLevel(str));
        }
    }
}
