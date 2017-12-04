using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.CategoryQuestions
{
    public interface IGetQuizQuestions
    {
        IEnumerable<QuizQuestion> GetQuizQuestions();
    }
}