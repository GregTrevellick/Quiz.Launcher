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

            var gatewayResponse = new GatewayResponse
            {
                DifficultyLevel = difficultyLevel,
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
            //"Which internet company began life as an online bookstore called &#039;Cadabra&#039;?"

            //var result = WebUtility.UrlEncode(str);

            //str= char.ToUpper(str[0]) + str.Substring(1);



            //var chrs = str.ToCharArray();
            //foreach (var chr in chrs)
            //{
            //    // int unicode = 65;
            //    // char character = (char) unicode;
            //    char character = (char)chr;
            //    string text = character.ToString();
            //}


            string myStringToDecode = str;//"Hello &#39;World&#39;";

            //string decodedString = System.Web.HttpUtility.HtmlDecode(myStringToDecode);
            // or
            string decodedString = System.Net.WebUtility.HtmlDecode(myStringToDecode);
            var result = decodedString;
            return result;
        }
    }
}