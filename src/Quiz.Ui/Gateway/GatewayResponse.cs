using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class GatewayResponse 
    {
        public string DifficultyLevel { get; set; }
        public IEnumerable<string> MultipleChoiceAnswers { get; set; }
        public string MultipleChoiceCorrectAnswer { get; set; }
        public string Question { get; set; }
        public QuestionType QuestionType { get; set; }
        public string ErrorDetails { get; set; }
    }
}
