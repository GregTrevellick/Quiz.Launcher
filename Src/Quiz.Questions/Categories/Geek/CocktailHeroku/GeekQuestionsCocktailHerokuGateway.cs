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
            var quizQuestion = GetQuizQuestion(rootObject.First());
            return quizQuestion;
        }

        private QuizQuestion GetQuizQuestion(GeekQuestionsCocktailHerokuRootObject rootObject)
        {
            var multipleChoiceCorrectAnswer = rootObject.answers.Single(x => x.correct).text;
            var multipleChoiceAnswers = rootObject.answers.Select(x => x.text);

            var question = CharacterHelper.CharacterHandler(rootObject.text);

            var quizQuestion = new QuizQuestion
            {
                Category = Category.Geek,
                DifficultyLevel = DifficultyLevel.Medium,
                MultipleChoiceAnswers = multipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = multipleChoiceCorrectAnswer,
                Question = question,
                QuestionType = GetQuestionType(multipleChoiceCorrectAnswer)
            };

            return quizQuestion;
        }

        internal static QuestionType GetQuestionType(string multipleChoiceCorrectAnswer)
        {
            return multipleChoiceCorrectAnswer?.ToLower() == "true" ||
                   multipleChoiceCorrectAnswer?.ToLower() == "false" 
                ? QuestionType.TrueFalse 
                : QuestionType.MultiChoice;
        }
    }
}