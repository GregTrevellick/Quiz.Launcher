using Newtonsoft.Json;
using System.Linq;

namespace Quiz.Ui.Gateway
{
    public class QuestionsCocktailHerokuGateway
    {
        public static GatewayResponse SetGatewayResponseFromRestResponse(string responseContent)
        {
            var rootObject = JsonConvert.DeserializeObject<QuestionsCocktailHerokuRootObject>(responseContent);
            var gatewayResponse = GetGatewayResponse(rootObject);
            return gatewayResponse;
        }

        private static GatewayResponse GetGatewayResponse(QuestionsCocktailHerokuRootObject rootObject)
        {
            var firstOfOne = rootObject.Property1.First();

            var multipleChoiceCorrectAnswer = firstOfOne.answers.Single(x => x.correct).text;
            var multipleChoiceAnswers = firstOfOne.answers.Select(x => x.text);

            //////var question = CharacterHandler(firstOfOne.question);
            //////var difficultyLevel = UppercaseFirst(firstOfOne.difficulty);
            //gregt TODO Enum.TryParse(difficultyLevel, out DifficultyLevel difficulty);

            var gatewayResponse = new GatewayResponse
            {
                //gregt TODO DifficultyLevel = difficulty,
                MultipleChoiceAnswers = multipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = multipleChoiceCorrectAnswer,
                Question = firstOfOne.text,
                //gregt TODO QuestionType = firstOfOne.type == "boolean" ? QuestionType.TrueFalse : QuestionType.MultiChoice//gregt unit test reqd
            };

            return gatewayResponse;
        }

        //////static string UppercaseFirst(string str)//gregt unit test reqd //gregt dedupe
        //////{
        //////    if (string.IsNullOrEmpty(str))
        //////    {
        //////        return string.Empty;
        //////    }

        //////    return char.ToUpper(str[0]) + str.Substring(1);
        //////}

        //////static string CharacterHandler(string str)//gregt unit test reqd //gregt dedupe
        //////{
        //////    var result = WebUtility.HtmlDecode(str);
        //////    return result;
        //////}
    }
}