using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories
{
    public interface IGetQuizQuestions
    {
        IEnumerable<QuizQuestion> GetQuizQuestions();
    }
}