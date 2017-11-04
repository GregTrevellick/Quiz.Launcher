using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace Quiz.Ui.Gateway
{
    public class ClientGatewayQuiz
    {
        public static GatewayResponse SetGatewayResponseFromRestResponse(string responseContent)
        {
            var rootObject = JsonConvert.DeserializeObject<RootObject>(responseContent);
            var gatewayResponse = GetGatewayResponse(rootObject);
            return gatewayResponse;
        }

        private static GatewayResponse GetGatewayResponse(RootObject rootObject)
        {
            var firstOfOne = rootObject.results.First();

            var multipleChoiceCorrectAnswer = firstOfOne.correct_answer;
            var multipleChoiceCorrectAnswerAsCollection = new List<string> {multipleChoiceCorrectAnswer};
            var multipleChoiceAnswers = multipleChoiceCorrectAnswerAsCollection.Union(firstOfOne.incorrect_answers);

            var question = CharacterHandler(firstOfOne.question);
            var difficultyLevel = UppercaseFirst(firstOfOne.difficulty);
            Enum.TryParse(difficultyLevel, out DifficultyLevel d);

            var gatewayResponse = new GatewayResponse
            {
                DifficultyLevel = d,
                MultipleChoiceAnswers = multipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = multipleChoiceCorrectAnswer,
                Question = question,
                QuestionType = firstOfOne.type == "boolean" ? QuestionType.TrueFalse : QuestionType.MultiChoice//gregt unit test reqd
            };

            return gatewayResponse;
        }

        static string UppercaseFirst(string str)//gregt unit test reqd
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return char.ToUpper(str[0]) + str.Substring(1);
        }

        static string CharacterHandler(string str)//gregt unit test reqd
        {
            var result = WebUtility.HtmlDecode(str);
            return result;
        }
    }
}