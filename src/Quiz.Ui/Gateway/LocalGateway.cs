using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class LocalGateway
    {
        private static GatewayResponse Get(DifficultyLevel difficultyLevel, string question, bool correctAnswer, bool wrongAnswer)
        {
            var result = Get(difficultyLevel, question, correctAnswer.ToString(), wrongAnswer.ToString());
            result.QuestionType = QuestionType.TrueFalse;
            return result;
        }

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
                QuestionType = QuestionType.MultiChoice
            };
            
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
                    Get(DifficultyLevel.Easy, "Sunday is a month ?", false, true),
                    //gregt opentdb submitable questions - cmmi ? solid ? grunt ? gulp ?
                };
            }
        }
    }
}
