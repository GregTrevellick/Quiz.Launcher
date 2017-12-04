using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.CategoryQuestions.Geek
{
    interface IGeekQuestions
    {
        IEnumerable<QuizQuestion> GetQuizQuestions();
    }
}
