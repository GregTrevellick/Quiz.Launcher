using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.Geek
{
    interface IGeekQuestions
    {
        IEnumerable<QuizQuestion> GetQuizQuestions();
    }
}
