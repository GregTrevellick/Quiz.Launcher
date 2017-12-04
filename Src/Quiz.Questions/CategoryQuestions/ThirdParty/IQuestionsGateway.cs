using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.ThirdParty
{
    public interface IQuestionsGateway
    {
        QuizQuestion SetQuizQuestionFromRestResponse(string responseContent);
    }
}