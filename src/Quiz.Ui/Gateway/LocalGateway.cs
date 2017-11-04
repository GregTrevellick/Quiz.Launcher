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
                        DifficultyLevel = "jj",
                        MultipleChoiceAnswers = new List<string>
                        {
                            "single r",
                            "silly",
                            "stupid",
                            "sexy"
                        },
                        MultipleChoiceCorrectAnswer = "single r",
                        Question = "what is s in solid",
                        QuestionType = QuestionType.MultiChoice
                    },
                    new GatewayResponse
                    {
                        DifficultyLevel = "jgsgsgsgsgsgsgsgsgsgsgsgj",
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
                        DifficultyLevel = "1",
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
