using System;
using System.Collections.Generic;
using System.Linq;
using Quiz.Questions.Categories.ThirdParty.CocktailHeroku;
using Quiz.Questions.Categories.ThirdParty.OpenTdb;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.Geek
{
    internal class GeekGateways : IGetThirdPartyQuizQuestions
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var rand = GetRandom();

            var quizQuestions = new List<QuizQuestion>();

            switch (rand)
            {
                case 1:
                    //guestimate 100
                    quizQuestions = new QuestionsOpenTdb().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, "18").ToList();
                    break;
                case 2:
                    //guestimate 100
                    quizQuestions = new QuestionsCocktailHeroku().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, "science-computers").ToList();
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
