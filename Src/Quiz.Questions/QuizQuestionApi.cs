﻿using System;
using MoreLinq;
using Quiz.Questions.Categories.Geek;
using Quiz.Questions.Entities;
using System.Collections.Generic;
using System.Linq;
using Quiz.Questions.Categories;
using Quiz.Questions.Categories.CSharp;
using Quiz.Questions.Categories.DotNet;
using Quiz.Questions.Categories.Javascript;
using Quiz.Questions.Categories.Music;
using Quiz.Questions.Categories.WebDev;

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
                case Category.WebDev:
                    getQuizQuestions = new WebDevQuestions();
                    quizQuestions = getQuizQuestions.GetQuizQuestions();
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