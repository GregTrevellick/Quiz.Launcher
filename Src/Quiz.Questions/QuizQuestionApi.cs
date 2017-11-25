using System;
using MoreLinq;
using Quiz.Questions.Categories.Geek;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Questions
{
    public class QuizQuestionApi : IQuizQuestionApi
    {
        public QuizQuestion GetQuizQuestion(Category preferredCategoriesFromOptions, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            IEnumerable<QuizQuestion> quizQuestions = null;

            var categoryToSupply = CategoryHelper.GetCategoryToSupply(preferredCategoriesFromOptions);

            switch (categoryToSupply)
            {
                case Category.Unknown:
                    break;
                case Category.CSharp:
                    break;
                case Category.DotNet:
                    var gateways2 = new GeekGateways();
                    quizQuestions = gateways2.GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
                case Category.Geek:
                    var gateways = new GeekGateways();
                    quizQuestions = gateways.GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
                case Category.Javascript:
                    break;
                case Category.WebDev:
                    break;
            }

            var quizQuestion = quizQuestions.RandomSubset(1).Single();

            quizQuestion.Category = categoryToSupply;

            return quizQuestion;
        }

        public DifficultyLevel GetDifficultyLevel(string textBlockDifficultyText)
        {
            if (string.IsNullOrWhiteSpace(textBlockDifficultyText))
            {
                return DifficultyLevel.Medium;
            }
            else
            {
                var str = textBlockDifficultyText.Replace("Difficulty: ", string.Empty);
                str = CharacterHelper.UppercaseFirst(str.ToLower());
                Enum.TryParse(str, out DifficultyLevel difficultyLevel);
                return difficultyLevel;
            }
        }

        public void HandleUnexpectedError(Exception ex) 
        {
            ErrorHelper.HandleUnexpectedError(ex);
        }
    }
}