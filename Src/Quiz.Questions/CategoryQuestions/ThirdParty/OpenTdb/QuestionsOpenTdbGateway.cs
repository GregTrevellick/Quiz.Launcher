using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Quiz.Questions.Entities;

namespace Quiz.Questions.CategoryQuestions.ThirdParty.OpenTdb
{
    internal class QuestionsOpenTdbGateway : IQuestionsGateway
    {
        public QuizQuestion SetQuizQuestionFromRestResponse(string responseContent)
        {
            var rootObject = JsonConvert.DeserializeObject<QuestionsOpenTdbRootObject>(responseContent);
            var quizQuestion = GetQuizQuestion(rootObject);
            return quizQuestion;
        }

        private QuizQuestion GetQuizQuestion(QuestionsOpenTdbRootObject rootObject)
        {
            var firstOfOne = rootObject.results.First();

            var question = CharacterHelper.CharacterHandler(firstOfOne.question);
            var multipleChoiceCorrectAnswer = CharacterHelper.CharacterHandler(firstOfOne.correct_answer);
            var multipleChoiceCorrectAnswerAsCollection = new List<string> { CharacterHelper.CharacterHandler(multipleChoiceCorrectAnswer) };
            var multipleChoiceAnswers = multipleChoiceCorrectAnswerAsCollection.Union(firstOfOne.incorrect_answers);

            var difficultyLevel = CharacterHelper.UppercaseFirst(firstOfOne.difficulty);
            Enum.TryParse(difficultyLevel, out DifficultyLevel difficulty);

            var quizQuestion = new QuizQuestion
            {
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////Category = Category.Geek,
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