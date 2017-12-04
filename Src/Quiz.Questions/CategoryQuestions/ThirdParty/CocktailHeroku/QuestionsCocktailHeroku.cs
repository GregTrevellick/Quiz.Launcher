using System;
using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.CategoryQuestions.ThirdParty.CocktailHeroku
{
    internal class QuestionsCocktailHeroku
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName, string cocktailHerokuCategory)
        {
            var urlBase = "http://cocktail-trivia-api.herokuapp.com/api/category/" + cocktailHerokuCategory;
            var urlEasy = urlBase  + "/difficulty/easy/count/1";
            var urlMedium = urlBase + "/difficulty/medium/count/1";
            var urlHard = urlBase + "/difficulty/hard/count/1";

            var random = new Random();
            var remote = random.Next(1, 3);
            var url = string.Empty;

            switch (remote)
            {
                case 1:
                    url = urlEasy;
                    break;
                case 2:
                    url = urlMedium;
                    break;
                case 3:
                    url = urlHard;
                    break;
            }
            
            var quizQuestion = Common.GetQuizQuestion(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, url, new QuestionsCocktailHerokuGateway());

            return new List<QuizQuestion>{ quizQuestion };
        }
    }
}