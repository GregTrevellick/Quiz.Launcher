using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsMine
    {
        public static IEnumerable<GatewayResponse> GetGatewayResponses()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                Common.Get(DifficultyLevel.Easy, "What is Brainfuck?", "A Turing complete programming language", "", "", "", "A very bad day at work"),
                Common.Get(DifficultyLevel.Hard, "What is gulp?", "A Turing complete programming language", "", "", "", "An alcoholic beverage"),
                Common.Get(DifficultyLevel.Hard, "Did the Xerox Corporation help create Javascript ?", "True", "False"),
                Common.Get(DifficultyLevel.Medium, "What is grunt?", "A task runner", "", "", "", "A methane gas"),
                Common.Get(DifficultyLevel.Easy, "What is a blackhat?", "A malicious hacker", "", "", "", "A teenage spot"),
                Common.Get(DifficultyLevel.Medium, "What is PARC?", "Palo Alto Research Centre", "", "", "", "Somewhere to take the kids"),
                Common.Get(DifficultyLevel.Easy, "Are whitehats good ?", "True", "False"),
                Common.Get(DifficultyLevel.Easy, "What does the S in SOLID stand for?", "", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What does the O in SOLID stand for?", "", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What does the L in SOLID stand for?", "", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What does the I in SOLID stand for?", "", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What does the D in SOLID stand for?", "", "", "", "", ""),
                Common.Get(DifficultyLevel.Easy, "What is DRY short for?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
                //Common.Get(DifficultyLevel.Easy, "What ?", "", "", "", "", ""),
          
            };

            return gatewayResponses;
        }
    }
}
