using Quiz.Questions.Entities;

namespace Quiz.Questions.CategoryQuestions.ThirdParty
{
    public interface IQuestionsGateway
    {
        QuizQuestion SetQuizQuestionFromRestResponse(string responseContent);
    }
}