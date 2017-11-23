using Microsoft.VisualStudio.TestTools.UnitTesting;
using Quiz.Questions.OpenTdb;

namespace Quiz.Questions.UnitTests
{
    [TestClass]
    public class QuestionsOpenTdbGatewayTests
    {
        [TestMethod]
        public void GetQuestionTypeTest()
        {
            Assert.AreEqual(QuestionType.MultiChoice, QuestionsOpenTdbGateway.GetQuestionType(null));
            Assert.AreEqual(QuestionType.MultiChoice, QuestionsOpenTdbGateway.GetQuestionType(new Result()));
            Assert.AreEqual(QuestionType.MultiChoice, QuestionsOpenTdbGateway.GetQuestionType(new Result{type=""}));
            Assert.AreEqual(QuestionType.TrueFalse, QuestionsOpenTdbGateway.GetQuestionType(new Result{type="boolean"}));
            Assert.AreEqual(QuestionType.TrueFalse, QuestionsOpenTdbGateway.GetQuestionType(new Result { type = "Boolean" }));
            Assert.AreEqual(QuestionType.TrueFalse, QuestionsOpenTdbGateway.GetQuestionType(new Result { type = "booleaN" }));
        }
    }
}
