using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.CategoryQuestions
{
    public interface IGetThirdPartyQuizQuestions
    {
        IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName);
    }
}