using System.Collections.Generic;
using System.Linq;
using Quiz.Questions.Categories.Geek.CocktailHeroku;
using Quiz.Questions.Categories.Geek.OpenTdb;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.Geek
{
    internal class GeekGateways : IGetQuizQuestions
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            //greg weight and do just one of these three

            var quizQuestions1 = new GeekQuestionsOpenTdb().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
            var quizQuestions2 = new GeekQuestionsCocktailHeroku().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
            var quizQuestions3 = new GeekQuestions().GetQuizQuestions();//approx 75 live, 75 commented out

            var quizQuestions = new List<QuizQuestion>();
            quizQuestions = quizQuestions.Union(quizQuestions1).ToList();
            quizQuestions = quizQuestions.Union(quizQuestions2).ToList();
            quizQuestions = quizQuestions.Union(quizQuestions3).ToList();
            return quizQuestions;
        }
    }
}
