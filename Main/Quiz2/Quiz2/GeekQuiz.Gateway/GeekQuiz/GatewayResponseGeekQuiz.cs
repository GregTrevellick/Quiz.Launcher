﻿using System.Collections.Generic;

namespace Quiz2.GeekQuiz.Gateway.GeekQuiz
{
    public class GatewayResponseGeekQuiz : GatewayResponseBase
    {
        public string DifficultyLevel { get; set; }
        public IEnumerable<string> MultipleChoiceAnswers { get; set; }
        public string MultipleChoiceCorrectAnswer { get; set; }
        public string Question { get; set; }
        public QuestionType QuestionType { get; set; }
    }
}
