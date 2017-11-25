using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.Geek.OpenTdb
{
    internal class GeekQuestionsOpenTdb : IGetQuizQuestions
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var url = "https://opentdb.com/api.php?amount=1&category=18";

            var quizQuestion = Common.GetQuizQuestion(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, url, new GeekQuestionsOpenTdbGateway());

            return new List<QuizQuestion> { quizQuestion };
        }
    }
}