using System.Collections.Generic;
using System.Linq;
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

            //gregt CharacterHandler(rootObject.answer); like jeopardy

            var difficultyLevel = UppercaseFirst(firstOfOne.difficulty);

            var gatewayResponse = new GatewayResponse
            {
                DifficultyLevel = difficultyLevel + ": ",
                MultipleChoiceAnswers = multipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = multipleChoiceCorrectAnswer,
                Question = firstOfOne.question,
                QuestionType = firstOfOne.type == "boolean" ? QuestionType.TrueFalse : QuestionType.MultiChoice
            };

            return gatewayResponse;
        }

        static string UppercaseFirst(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }

            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}