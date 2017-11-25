using Quiz.Questions.Entities;

namespace Quiz.Questions.Interfaces
{
    public interface IQuestionsGateway
    {
        QuizQuestion SetQuizQuestionFromRestResponse(string responseContent);
    }
}