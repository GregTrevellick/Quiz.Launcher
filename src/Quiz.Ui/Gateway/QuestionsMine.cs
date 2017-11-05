using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class QuestionsMine
    {
        public static IEnumerable<GatewayResponse> GetGatewayResponsesMine()
        {
            var gatewayResponses = new List<GatewayResponse>
            {
                //gregt add more here
                GetGatewayResponse(DifficultyLevel.Easy, "What is Brainfuck?", "A Turing complete programming language", "An alcoholic beverage", "A computing-related protocol", "A very bad day at work"),
                GetGatewayResponse(DifficultyLevel.Hard, "What is gulp?", "A Turing complete programming language", "An alcoholic beverage"),
                GetGatewayResponse(DifficultyLevel.Medium, "What is grunt?", "A Turing complete programming language", "An alcoholic beverage"),
                GetGatewayResponse(DifficultyLevel.Easy, "SOLID sucks?", false, true),
            };
            return gatewayResponses;
        }

        private static GatewayResponse GetGatewayResponse(DifficultyLevel difficultyLevel, string question, bool correctAnswer, bool wrongAnswer)
        {
            var result = GetGatewayResponse(difficultyLevel, question, correctAnswer.ToString(), wrongAnswer.ToString());
            result.QuestionType = QuestionType.TrueFalse;
            return result;
        }

        private static GatewayResponse GetGatewayResponse(DifficultyLevel difficultyLevel, string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2 = null, string wrongAnswer3 = null)
        {
            var result = new GatewayResponse
            {
                DifficultyLevel = difficultyLevel,
                MultipleChoiceAnswers = new List<string>
                {
                    correctAnswer,
                    wrongAnswer1,
                    wrongAnswer2,
                    wrongAnswer3,
                },
                MultipleChoiceCorrectAnswer = correctAnswer,
                Question = question,
                QuestionType = QuestionType.MultiChoice
            };

            return result;
        }
    }
}
