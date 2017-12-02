using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Questions.Categories.Geek.ThirdParty.OpenTdb;
using Quiz.Questions.Entities;

namespace Quiz.Questions.UnitTests
{
    [TestClass]
    public class GeekQuestionsOpenTdbGatewayTests
    {
        [TestMethod]
        public void GetQuestionTypeTest()
        {
            Assert.AreEqual(QuestionType.MultiChoice, GeekQuestionsOpenTdbGateway.GetQuestionType(null));
            Assert.AreEqual(QuestionType.MultiChoice, GeekQuestionsOpenTdbGateway.GetQuestionType(new Result()));
            Assert.AreEqual(QuestionType.MultiChoice, GeekQuestionsOpenTdbGateway.GetQuestionType(new Result{type=""}));
            Assert.AreEqual(QuestionType.TrueFalse, GeekQuestionsOpenTdbGateway.GetQuestionType(new Result{type="boolean"}));
            Assert.AreEqual(QuestionType.TrueFalse, GeekQuestionsOpenTdbGateway.GetQuestionType(new Result { type = "Boolean" }));
            Assert.AreEqual(QuestionType.TrueFalse, GeekQuestionsOpenTdbGateway.GetQuestionType(new Result { type = "booleaN" }));
        }
    }
}
