using System;
using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.Geek.ThirdParty.CocktailHeroku
{
    internal class GeekQuestionsCocktailHeroku : IGetQuizQuestionsExternally
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            var urlEasy = "http://cocktail-trivia-api.herokuapp.com/api/category/science-computers/difficulty/easy/count/1";
            var urlMedium = "http://cocktail-trivia-api.herokuapp.com/api/category/science-computers/difficulty/medium/count/1";
            var urlHard = "http://cocktail-trivia-api.herokuapp.com/api/category/science-computers/difficulty/hard/count/1";

                            

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
            
            var quizQuestion = Common.GetQuizQuestion(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName, url, new GeekQuestionsCocktailHerokuGateway());

            return new List<QuizQuestion>{ quizQuestion };
        }
    }
}