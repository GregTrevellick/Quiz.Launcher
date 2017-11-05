using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class LocalGateway
    {
        public static IEnumerable<GatewayResponse> GatewayResponses
        {
            get
            {
                return new List<GatewayResponse>
                {
                    new GatewayResponse
                    {
                        DifficultyLevel = DifficultyLevel.Easy,
                        MultipleChoiceAnswers = new List<string>
                        {
                            "An alcoholic beverage",
                            "A computing-related protocol",
                            "A Turing complete programming language",
                            "A very bad day at work"
                        },
                        MultipleChoiceCorrectAnswer = "A Turing complete programming language",
                        Question = "What is Brainfuck ?",
                        QuestionType = QuestionType.MultiChoice
                    },
                    new GatewayResponse
                    {
                        DifficultyLevel = DifficultyLevel.Medium,
                        MultipleChoiceAnswers = new List<string>
                        {
                            "single r",
                            "silly",
                            "stupid",
                            "sexy"
                        },
                        MultipleChoiceCorrectAnswer = "single r",
                        Question = "tststststststststs is s in solid",
                        QuestionType = QuestionType.MultiChoice
                    },
                    new GatewayResponse
                    {
                        DifficultyLevel = DifficultyLevel.Hard,
                        MultipleChoiceAnswers = new List<string>
                        {
                            "single r",
                            "silly",
                            "stupid",
                            "sexy"
                        },
                        MultipleChoiceCorrectAnswer = "single r",
                        Question = "1111111111111111111111111111111",
                        QuestionType = QuestionType.MultiChoice
                    }
                };
            }
        }
    }
}
