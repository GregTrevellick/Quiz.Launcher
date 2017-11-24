using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.DotNet
{
    internal class QuestionsMineDotNet
    {
        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                Common.Get(Category.Geek, DifficultyLevel.Hard, "What was the initial name for Visual Studio?",
                    "Boston",
                    "Phoenix",
                    "Portland",
                    "Seattle",
                    "Timbuktu"),
            };

            return gatewayResponses;
        }
    }
}
