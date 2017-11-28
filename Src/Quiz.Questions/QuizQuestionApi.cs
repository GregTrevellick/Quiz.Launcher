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
        private string errorDetails;

        public QuizQuestion GetQuizQuestion(Category preferredCategoriesFromOptions, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            IEnumerable<QuizQuestion> quizQuestions = null;

            var categoryToSupply = CategoryHelper.GetCategoryToSupply(preferredCategoriesFromOptions);

            //gregt weight and do just one of these five - weight dynamically based upon size of questions in each collection ?

            switch (categoryToSupply)
            {
                case Category.Unknown:
                    errorDetails = ErrorHelper.HandleArgumentOutOfRangeException(nameof(categoryToSupply), (int)categoryToSupply);
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
                default:
                    errorDetails = ErrorHelper.HandleArgumentOutOfRangeException(nameof(categoryToSupply), (int)categoryToSupply);
                    break;
            }

            if (string.IsNullOrEmpty(errorDetails))
            {
                var quizQuestion = quizQuestions.RandomSubset(1).Single();

                quizQuestion.Category = categoryToSupply;//gregt this should be unnecessary as they are both the same but this is not always the case

                return quizQuestion;
            }
            else
            {
                return new QuizQuestion { ErrorDetails = errorDetails };
            }
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

        public string HandleArgumentOutOfRangeException(string argumentName, int argumentValue) 
        {
            return ErrorHelper.HandleArgumentOutOfRangeException(argumentName, argumentValue);
        }
    }
}