using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Questions.Entities;
using RestSharp;

namespace Quiz.Questions.UnitTests
{
    [TestClass]
    public class CommonTests
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

        [DataRow("", "")]
        [DataRow(null, "")]
        [DataRow("Abc", "Abc")]
        [DataRow("Ab cd", "Ab cd")]
        [DataRow("abc", "Abc")]
        [DataRow("ab cd", "Ab cd")]
        [DataRow("aBc", "ABc")]
        [DataRow("aB Cd", "AB Cd")]
        [DataTestMethod]
        public void UppercaseFirstTest(string str, string expected)
        {
            Assert.AreEqual(expected, CharacterHelper.UppercaseFirst(str));
        }

        [TestMethod]
        public void HasErrorOccuredTest1()
        {
            Assert.IsTrue(ErrorHelper.HasErrorOccured(null));
        }

        [TestMethod]
        public void HasErrorOccuredTest2()
        {
            IRestResponse response = new RestResponse();
            Assert.IsFalse(ErrorHelper.HasErrorOccured(response));
        }

        [TestMethod]
        public void HasErrorOccuredTest3()
        {
            IRestResponse response = new RestResponse
            {
                ErrorMessage = "abc"
            };
            Assert.IsTrue(ErrorHelper.HasErrorOccured(response));
        }

        [TestMethod]
        public void HasErrorOccuredTest4()
        {
            IRestResponse response = new RestResponse
            {
                ErrorException = new Exception()
            };
            Assert.IsTrue(ErrorHelper.HasErrorOccured(response));
        }
    }
}
