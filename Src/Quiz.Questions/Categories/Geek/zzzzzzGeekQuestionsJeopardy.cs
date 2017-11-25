using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.Geek
{
    internal class GeekQuestionsJeopardy: IGetGeeks
    {
        private static GatewayResponse Get(DifficultyLevel difficultyLevel, string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2, string wrongAnswer3, string wrongAnswer4 = null)
        {
            var result = Common.Get(Category.Geek, difficultyLevel, question, correctAnswer, wrongAnswer1, wrongAnswer2, wrongAnswer3, wrongAnswer4);
            return result;
        }

        public IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {

            };

            return gatewayResponses;
        }

    }
}
