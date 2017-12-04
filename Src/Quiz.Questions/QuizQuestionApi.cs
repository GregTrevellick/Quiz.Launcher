using System;
using MoreLinq;
using Quiz.Questions.Entities;
using System.Collections.Generic;
using System.Linq;
using Quiz.Questions.CategoryQuestions;
using Quiz.Questions.CategoryQuestions.CSharp;
using Quiz.Questions.CategoryQuestions.DotNet;
using Quiz.Questions.CategoryQuestions.FrontEnd;
using Quiz.Questions.CategoryQuestions.Geek;
using Quiz.Questions.CategoryQuestions.Javascript;
using Quiz.Questions.CategoryQuestions.Music;

namespace Quiz.Questions
{
    public class QuizQuestionApi : IQuizQuestionApi
    {
        private string errorDetails;

        public QuizQuestion GetQuizQuestion(Category singleCategory, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName)
        {
            IEnumerable<QuizQuestion> quizQuestions = null;

            IGetQuizQuestions getQuizQuestions;

            switch (singleCategory)
            {
                case Category.Unknown:
                    errorDetails = ErrorHelper.HandleArgumentOutOfRangeException(nameof(singleCategory), (int)singleCategory);
                    break;
                case Category.CSharp:
                    getQuizQuestions = new CSharpQuestions();
                    quizQuestions = getQuizQuestions.GetQuizQuestions();
                    break;
                case Category.DotNet:
                    getQuizQuestions = new DotNetQuestions();
                    quizQuestions = getQuizQuestions.GetQuizQuestions();
                    break;
                case Category.FrontEnd:
                    getQuizQuestions = new FrontEndQuestions();
                    quizQuestions = getQuizQuestions.GetQuizQuestions();
                    break;
                case Category.Geek:
                    var geekGateways = new GeekGateways();
                    quizQuestions = geekGateways.GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
                case Category.Javascript:
                    getQuizQuestions = new JavascriptQuestions();
                    quizQuestions = getQuizQuestions.GetQuizQuestions();
                    break;
                case Category.Music:
                    var musicGateways = new MusicGateways();
                    quizQuestions = musicGateways.GetQuizQuestions(timeOutInMilliSeconds, timeOutInMilliSecondsOptionLabel, optionName);
                    break;
                default:
                    errorDetails = ErrorHelper.HandleArgumentOutOfRangeException(nameof(singleCategory), (int)singleCategory);
                    break;
            }

            if (string.IsNullOrEmpty(errorDetails))
            {
                var quizQuestion = quizQuestions.RandomSubset(1).Single();

                quizQuestion.Category = singleCategory;//gregt this should be unnecessary as they are both the same but this is not always the case

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