using System.Collections.Generic;
using System.Linq;

namespace Quiz.Ui.Gateway
{
    public class AllGateways
    {
        public static IEnumerable<GatewayResponse> GatewayResponses
        {
            get
            {
                var gatewayResponsesMine = QuestionsMine.GetGatewayResponses();

                var gatewayResponsesJeopardy = QuestionsJeopardy.GetGatewayResponses();

                var questionsWebCampTrainingKit = QuestionsWebCampTrainingKit.GetQuestions();
                var gatewayResponsesWebCampTrainingKit = GetGatewayResponses(questionsWebCampTrainingKit);

                var result = new List<GatewayResponse>();
                
                result = result.Union(gatewayResponsesMine).ToList();
                result = result.Union(gatewayResponsesJeopardy).ToList();
                result = result.Union(gatewayResponsesWebCampTrainingKit).ToList();

                return result;
            }
        }

        private static IEnumerable<GatewayResponse> GetGatewayResponses(IEnumerable<Question> triviaQuestions)
        {
            var gatewayResponses = new List<GatewayResponse>();

            foreach (var triviaQuestion in triviaQuestions)
            {
                var localTriviaQuestion = new GatewayResponse
                {
                    DifficultyLevel = triviaQuestion.DifficultyLevel,
                    MultipleChoiceAnswers = triviaQuestion.Answers.Select(x => x.AnswerText),
                    MultipleChoiceCorrectAnswer = triviaQuestion.Answers.Where(x => x.IsCorrect).Select(x => x.AnswerText).Single(),
                    Question = triviaQuestion.QuestionText,
                    QuestionType = QuestionType.MultiChoice
                };

                gatewayResponses.Add(localTriviaQuestion);
            }

            return gatewayResponses;
        }
    }
}
