using System.Collections.Generic;
using System.Linq;
using Quiz.Questions.Jeopardy;
using Quiz.Questions.Mine;
using Quiz.Questions.WebCampTrainingKit;

namespace Quiz.Questions
{
    public class AllGateways
    {
        public static IEnumerable<GatewayResponse> GatewayResponses
        {
            get
            {
                //approx 5-10
                var gatewayResponsesMine = QuestionsMine.GetGatewayResponses();

                //approx 241
                var gatewayResponsesJeopardy = QuestionsJeopardy.GetGatewayResponses();

                //44
                var questionsWebCampTrainingKit = QuestionsWebCampTrainingKit.GetQuestions();
                var gatewayResponsesWebCampTrainingKit = QuestionsWebCampTrainingKit.GetGatewayResponses(questionsWebCampTrainingKit);

                var result = new List<GatewayResponse>();
                
                result = result.Union(gatewayResponsesMine).ToList();
                result = result.Union(gatewayResponsesJeopardy).ToList();
                result = result.Union(gatewayResponsesWebCampTrainingKit).ToList();

                return result;
            }
        }

    }
}
