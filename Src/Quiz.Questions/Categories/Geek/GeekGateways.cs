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

            var gatewayResponses1 = new GeekQuestionsOpenTdb().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
            var gatewayResponses2 = new GeekQuestionsCocktailHeroku().GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
            var gatewayResponses3 = new GeekQuestions().GetGatewayResponses();//approx 75 live, 75 commented out

            var result = new List<QuizQuestion>();
            result = result.Union(gatewayResponses1).ToList();
            result = result.Union(gatewayResponses2).ToList();
            result = result.Union(gatewayResponses3).ToList();
            return result;
        }
    }
}
