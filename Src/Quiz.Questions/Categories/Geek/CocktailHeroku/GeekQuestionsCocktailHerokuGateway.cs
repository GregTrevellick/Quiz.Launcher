using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.Geek.CocktailHeroku
{
    internal class GeekQuestionsCocktailHerokuGateway : IQuestionsGateway
    {
        public QuizQuestion SetQuizQuestionFromRestResponse(string responseContent)
        {
            var rootObject = JsonConvert.DeserializeObject<List<GeekQuestionsCocktailHerokuRootObject>>(responseContent);
            var gatewayResponse = GetGatewayResponse(rootObject.First());
            return gatewayResponse;
        }

        private QuizQuestion GetGatewayResponse(GeekQuestionsCocktailHerokuRootObject rootObject)
        {
            var multipleChoiceCorrectAnswer = rootObject.answers.Single(x => x.correct).text;
            var multipleChoiceAnswers = rootObject.answers.Select(x => x.text);

            var question = Common.CharacterHandler(rootObject.text);

            var gatewayResponse = new QuizQuestion
            {
                Category = Category.Geek,
                DifficultyLevel = DifficultyLevel.Medium,
                MultipleChoiceAnswers = multipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = multipleChoiceCorrectAnswer,
                Question = question,
                QuestionType = GetQuestionType(multipleChoiceCorrectAnswer)
            };

            return gatewayResponse;
        }

        public static QuestionType GetQuestionType(string multipleChoiceCorrectAnswer)
        {
            return multipleChoiceCorrectAnswer?.ToLower() == "true" ||
                   multipleChoiceCorrectAnswer?.ToLower() == "false" 
                ? QuestionType.TrueFalse 
                : QuestionType.MultiChoice;
        }
    }
}