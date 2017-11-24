using Quiz.Questions.Categories.Geek.WebCampTrainingKit;
using System.Collections.Generic;
using System.Linq;
using Quiz.Questions.Categories.Geek.CocktailHeroku;
using Quiz.Questions.Categories.Geek.OpenTdb;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.Geek
{
    internal class GeekGateways : IGetGatewayResponses
    {
        public IEnumerable<GatewayResponse> GetGatewayResponses(int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            //greg weight and do just one of these three

            //remote
            var gatewayResponses1 = new QuestionsOpenTdb().GetGatewayResponses(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
            var gatewayResponses2 = new QuestionsCocktailHeroku().GetGatewayResponses(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);

            //local
            var gatewayResponsesMine = new QuestionsMineGeek().GetGatewayResponses();//approx 5-10
            var gatewayResponsesJeopardy =new QuestionsJeopardy().GetGatewayResponses();//approx 241
            var gatewayResponsesWebCampTrainingKit = new QuestionsWebCampTrainingKit().GetGatewayResponses();//approx 44

            var result = new List<GatewayResponse>();
            result = result.Union(gatewayResponses1).ToList();
            result = result.Union(gatewayResponses2).ToList();
            result = result.Union(gatewayResponsesMine).ToList();
            result = result.Union(gatewayResponsesJeopardy).ToList();
            result = result.Union(gatewayResponsesWebCampTrainingKit).ToList();
            return result;
        }
    }
}
