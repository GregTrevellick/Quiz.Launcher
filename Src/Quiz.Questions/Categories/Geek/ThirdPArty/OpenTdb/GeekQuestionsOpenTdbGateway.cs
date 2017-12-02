using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.Geek.ThirdParty.OpenTdb
{
    internal class GeekQuestionsOpenTdbGateway : IQuestionsGateway
    {
        public QuizQuestion SetQuizQuestionFromRestResponse(string responseContent)
        {
            var rootObject = JsonConvert.DeserializeObject<GeekQuestionsOpenTdbRootObject>(responseContent);
            var quizQuestion = GetQuizQuestion(rootObject);
            return quizQuestion;
        }

        private QuizQuestion GetQuizQuestion(GeekQuestionsOpenTdbRootObject rootObject)
        {
            var firstOfOne = rootObject.results.First();

            var multipleChoiceCorrectAnswer = firstOfOne.correct_answer;
            var multipleChoiceCorrectAnswerAsCollection = new List<string> {multipleChoiceCorrectAnswer};
            var multipleChoiceAnswers = multipleChoiceCorrectAnswerAsCollection.Union(firstOfOne.incorrect_answers);

            var question = CharacterHelper.CharacterHandler(firstOfOne.question);
            var difficultyLevel = CharacterHelper.UppercaseFirst(firstOfOne.difficulty);
            Enum.TryParse(difficultyLevel, out DifficultyLevel difficulty);

            var quizQuestion = new QuizQuestion
            {
                Category = Category.Geek,
                DifficultyLevel = difficulty,
                MultipleChoiceAnswers = multipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = multipleChoiceCorrectAnswer,
                Question = question,
                QuestionType = GetQuestionType(firstOfOne)
            };

            return quizQuestion;
        }

        internal static QuestionType GetQuestionType(Result firstOfOne)
        {
            return firstOfOne?.type?.ToLower() == "boolean" ? QuestionType.TrueFalse : QuestionType.MultiChoice;
        }
    }
}