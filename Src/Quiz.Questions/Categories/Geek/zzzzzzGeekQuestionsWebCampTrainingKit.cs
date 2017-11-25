using Quiz.Questions.Entities;
using System.Collections.Generic;

namespace Quiz.Questions.Categories.Geek
{
    internal class GeekQuestionsWebCampTrainingKit : IGetGeeks
    {
        public IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
            };

            return gatewayResponses;
        }
    }
}
