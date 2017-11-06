using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsMine
    {
        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                Common.Get(DifficultyLevel.Easy, "What is Brainfuck?", "A Turing complete programming language", "An alcoholic beverage", "A computing-related protocol", "A very bad day at work"),
                Common.Get(DifficultyLevel.Hard, "What is gulp?", "A Turing complete programming language", "An alcoholic beverage"),
                Common.Get(DifficultyLevel.Medium, "What is grunt?", "A Turing complete programming language", "An alcoholic beverage"),
                //gregt add more here e.g.
                //xerox created javascript ?
                //what is parc ? (palo alto research centre)
                //whitehats are good ? true/false
          
            };

            return gatewayResponses;
        }
    }
}
