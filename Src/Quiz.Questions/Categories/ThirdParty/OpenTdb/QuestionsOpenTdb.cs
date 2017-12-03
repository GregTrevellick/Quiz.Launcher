using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.ThirdParty.OpenTdb
{
    internal class QuestionsOpenTdb 
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName, string openTdbCategory)
        {
            var url = "https://opentdb.com/api.php?amount=1&category=" + openTdbCategory;

            var quizQuestion = Common.GetQuizQuestion(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, url, new QuestionsOpenTdbGateway());

            return new List<QuizQuestion> { quizQuestion };
        }
    }
}