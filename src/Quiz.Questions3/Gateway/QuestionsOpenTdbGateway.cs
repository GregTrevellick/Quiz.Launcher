using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;

namespace Quiz.Ui.Gateway
{
    public class QuestionsOpenTdbGateway
    {
        public static GatewayResponse SetGatewayResponseFromRestResponse(string responseContent)
        {
            var rootObject = JsonConvert.DeserializeObject<QuestionsOpenTdbRootObject>(responseContent);
            var gatewayResponse = GetGatewayResponse(rootObject);
            return gatewayResponse;
        }

        private static GatewayResponse GetGatewayResponse(QuestionsOpenTdbRootObject rootObject)
        {
            var firstOfOne = rootObject.results.First();

            var multipleChoiceCorrectAnswer = firstOfOne.correct_answer;
            var multipleChoiceCorrectAnswerAsCollection = new List<string> {multipleChoiceCorrectAnswer};
            var multipleChoiceAnswers = multipleChoiceCorrectAnswerAsCollection.Union(firstOfOne.incorrect_answers);

            var question = Common.CharacterHandler(firstOfOne.question);
            var difficultyLevel = Common.UppercaseFirst(firstOfOne.difficulty);
            Enum.TryParse(difficultyLevel, out DifficultyLevel difficulty);

            var gatewayResponse = new GatewayResponse
            {
                DifficultyLevel = difficulty,
                MultipleChoiceAnswers = multipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = multipleChoiceCorrectAnswer,
                Question = question,
                QuestionType = firstOfOne.type == "boolean" ? QuestionType.TrueFalse : QuestionType.MultiChoice//gregt unit test reqd
            };

            return gatewayResponse;
        }
    }
}