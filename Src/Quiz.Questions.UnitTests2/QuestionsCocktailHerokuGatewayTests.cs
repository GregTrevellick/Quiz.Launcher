using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Questions.CocktailHeroku;

namespace Quiz.Questions.UnitTests
{
    [TestClass]
    public class QuestionsCocktailHerokuGatewayTests
    {
        [DataRow("true", QuestionType.TrueFalse)]
        [DataRow("True", QuestionType.TrueFalse)]
        [DataRow("TRUE", QuestionType.TrueFalse)]
        [DataRow("true", QuestionType.TrueFalse)]
        [DataRow("false", QuestionType.TrueFalse)]
        [DataRow("False", QuestionType.TrueFalse)]
        [DataRow("FALSE", QuestionType.TrueFalse)]
        [DataRow("falsE", QuestionType.TrueFalse)]
        [DataRow("", QuestionType.MultiChoice)]
        [DataRow(null, QuestionType.MultiChoice)]
        [DataTestMethod]
        public void GetQuestionTypeTest(string multipleChoiceCorrectAnswer, QuestionType expected)
        {
            Assert.AreEqual(expected, QuestionsCocktailHerokuGateway.GetQuestionType(multipleChoiceCorrectAnswer));
        }
    }
}
