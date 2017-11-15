using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Quiz.Questions
{
    public class QuestionsOpenTdbGateway : IQuestionsGateway
    {
        public GatewayResponse SetGatewayResponseFromRestResponse(string responseContent)
        {
            var rootObject = JsonConvert.DeserializeObject<QuestionsOpenTdbRootObject>(responseContent);
            var gatewayResponse = GetGatewayResponse(rootObject);
            return gatewayResponse;
        }

        private GatewayResponse GetGatewayResponse(QuestionsOpenTdbRootObject rootObject)
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
                QuestionType = GetQuestionType(firstOfOne)
            };

            return gatewayResponse;
        }

        public static QuestionType GetQuestionType(Result firstOfOne)
        {
            return firstOfOne?.type?.ToLower() == "boolean" ? QuestionType.TrueFalse : QuestionType.MultiChoice;
        }
    }
}