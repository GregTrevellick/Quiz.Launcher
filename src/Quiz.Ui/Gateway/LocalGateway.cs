using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using RestSharp.Extensions;

namespace Quiz.Ui.Gateway
{
    public class LocalGateway
    {
        private static GatewayResponse GetGR(string diff, string q, string ans1, string wrong2, string wrong3 = null, string wrong4 = null)
        {
            Enum.Parse(diff, out DifficultyLevel diff2);

            var result = new GatewayResponse
            {
                DifficultyLevel = diff2,
                MultipleChoiceAnswers = new List<string>
                {
                    ans1,
                    wrong2,
                },
                MultipleChoiceCorrectAnswer = ans1,
                Question = q,
            };

            if (wrong3.HasValue()) 
            {
                result.MultipleChoiceAnswers.Add(wrong3);
            }

            if (wrong4.HasValue())
            {
                result.MultipleChoiceAnswers.Add(wrong4);
            }

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
                var a = GetGR("Easy", "What is Brainfuck ?", "A Turing complete programming language",
                    "An alcoholic beverage", "A computing-related protocol", "A very bad day at work");

                return new List<GatewayResponse>
                {
                    a,
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
