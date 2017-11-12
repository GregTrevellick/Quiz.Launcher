using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Quiz.Questions
{
    public class QuestionsCocktailHerokuGateway : IQuestionsGateway
    {
        public GatewayResponse SetGatewayResponseFromRestResponse(string responseContent)
        {
            var rootObject = JsonConvert.DeserializeObject<List<QuestionsCocktailHerokuRootObject>>(responseContent);
            var gatewayResponse = GetGatewayResponse(rootObject.First());
            return gatewayResponse;
        }

        private GatewayResponse GetGatewayResponse(QuestionsCocktailHerokuRootObject rootObject)
        {
            var multipleChoiceCorrectAnswer = rootObject.answers.Single(x => x.correct).text;
            var multipleChoiceAnswers = rootObject.answers.Select(x => x.text);

            var question = Common.CharacterHandler(rootObject.text);

            var gatewayResponse = new GatewayResponse
            {
                DifficultyLevel = DifficultyLevel.Medium,
                MultipleChoiceAnswers = multipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = multipleChoiceCorrectAnswer,
                Question = question,
                QuestionType = multipleChoiceCorrectAnswer.ToLower() == "true" ||
                               multipleChoiceCorrectAnswer.ToLower() == "false" 
                               ? QuestionType.TrueFalse 
                               : QuestionType.MultiChoice//gregt unit test reqd
            };

            return gatewayResponse;
        }
    }
}