﻿using System.Collections.Generic;
using GeekQuiz.Gateway;

namespace GeekQuiz.Common
{
    public class TriviaDialogGeekQuizDto : TriviaDialogDtoBase
    {
        public TriviaDialogGeekQuizDto(AppName appName, string optionsName, string popUpTitle, string errorDetails) : base(appName, optionsName, popUpTitle, errorDetails)
        {
        }

        public string GeekQuizDifficulty { get; set; }
        public IEnumerable<string> GeekQuizMultipleChoiceAnswers { get; set; }
        public string GeekQuizMultipleChoiceCorrectAnswer { get; set; }
        public QuestionType GeekQuizQuestionType { get; set; }
        public string GeekQuizQuestion { get; set; }
    }
}