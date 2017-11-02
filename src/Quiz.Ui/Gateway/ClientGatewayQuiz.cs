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

            var question = CharacterHandler(firstOfOne.question);
            var difficultyLevel = UppercaseFirst(firstOfOne.difficulty);

            var gatewayResponse = new GatewayResponse
            {
                DifficultyLevel = difficultyLevel,
                MultipleChoiceAnswers = multipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = multipleChoiceCorrectAnswer,
                Question = question,
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

        internal static string CharacterHandler(string str)
        {
            str = str.Replace("<i>", string.Empty);
            str = str.Replace("</i>", string.Empty);
            str = str.Replace(@"\'", "'");
            str = char.ToUpper(str[0]) + str.Substring(1);

            return str;
        }
    }
}