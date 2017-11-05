using System.Collections.Generic;
using System.Linq;

namespace Quiz.Ui.Gateway
{
    public class LocalGateway
    {
        private static GatewayResponse Get(DifficultyLevel difficultyLevel, string question, string correctAnswer, string wrongAnswer1, string wrongAnswer2 = null, string wrongAnswer3 = null)
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
            };

            if (result.MultipleChoiceAnswers.Any(x => x.ToLower().Contains("true")))
            {
                result.QuestionType = QuestionType.TrueFalse;
            }
            else
            {
                result.QuestionType = QuestionType.MultiChoice;
            }

            return result;
        }

        public static IEnumerable<GatewayResponse> GatewayResponses
        {
            get
            {
                return new List<GatewayResponse>
                {
                    Get(DifficultyLevel.Easy, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage", "A computing-related protocol", "A very bad day at work"),
                    Get(DifficultyLevel.Hard, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage"),
                    Get(DifficultyLevel.Medium, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage"),
                    Get(DifficultyLevel.Easy, "What is Brainfuck ?", "A Turing complete programming language", "An alcoholic beverage"),
                    //gregt opentdb submitable questions - cmmi ? solid ? grunt ? gulp ?
                };
            }
        }
    }
}
