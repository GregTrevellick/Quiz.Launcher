using System;
using System.Collections.Generic;
using System.Linq;
using Quiz.Questions.Categories.Geek.ThirdParty.CocktailHeroku;
using Quiz.Questions.Categories.Geek.ThirdParty.OpenTdb;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.Geek
{
    internal class GeekGateways : IGetQuizQuestionsExternally
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var rand = GetRandom();

            var quizQuestions = new List<QuizQuestion>();

            switch (rand)
            {
                case 1:
                    //guestimate 100
                    quizQuestions = new GeekQuestionsOpenTdb().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName).ToList();
                    break;
                case 2:
                    //guestimate 100
                    quizQuestions = new GeekQuestionsCocktailHeroku().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName).ToList();
                    break;
                case 3:
                    //approx 130
                    quizQuestions = new GeekQuestions().GetQuizQuestions().ToList();
                    break;
            }

            return quizQuestions;
        }

        private static int GetRandom()
        {
            var random = new Random();
            var rand = random.Next(1, 3);
            return rand;
        }
    }
}
