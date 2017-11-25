using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Interfaces
{
    public interface IGetQuizQuestionsExternally
    {
        IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName);
    }
}