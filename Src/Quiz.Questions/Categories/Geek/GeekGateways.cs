using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using Quiz.Questions.Categories.Geek.WebCampTrainingKit;

namespace Quiz.Questions.Categories.Geek
{
    internal class GeekGateways
    {
        public GatewayResponse GetGatewayResponse()
        {
            //approx 5-10
            var gatewayResponsesMine = QuestionsMineGeek.GetGatewayResponses();

            //approx 241
            var gatewayResponsesJeopardy = QuestionsJeopardy.GetGatewayResponses();

            //44
            var questionsWebCampTrainingKit = QuestionsWebCampTrainingKit.GetQuestions();
            var gatewayResponsesWebCampTrainingKit = QuestionsWebCampTrainingKit.GetGatewayResponses(questionsWebCampTrainingKit);

            var result = new List<GatewayResponse>();
                
            result = result.Union(gatewayResponsesMine).ToList();
            result = result.Union(gatewayResponsesJeopardy).ToList();
            result = result.Union(gatewayResponsesWebCampTrainingKit).ToList();

            return result.RandomSubset(1).Single();
        }
    }
}
