using System;
using System.Collections.Generic;
using System.Linq;
using Quiz.Questions.CategoryQuestions.ThirdParty.CocktailHeroku;
using Quiz.Questions.CategoryQuestions.ThirdParty.OpenTdb;
using Quiz.Questions.Entities;

namespace Quiz.Questions.CategoryQuestions.Music
{
    internal class MusicGateways : IGetThirdPartyQuizQuestions
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var rand = GetRandom();

            var quizQuestions = new List<QuizQuestion>();

            switch (rand)
            {
                case 1:
                    quizQuestions = new QuestionsOpenTdb().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, "12").ToList();
                    break;
                case 2:
                    quizQuestions = new QuestionsCocktailHeroku().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, "entertainment-music").ToList();
                    break;
            }

            return quizQuestions;
        }

        private static int GetRandom()
        {
            var random = new Random();
            var rand = random.Next(1, 2);
            return rand;
        }
    }
}
