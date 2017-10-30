using System.Collections.Generic;
using Quiz.Ui.Gateway;

namespace Quiz.Ui.Core
{
    public class QuizDialogDto
    {
        public IEnumerable<string> MultipleChoiceAnswers { get; set; }
        public QuestionType QuestionType { get; set; }
        public string ErrorDetails { get; set; }
        public string QuestionDifficulty { get; set; }
        public string MultipleChoiceCorrectAnswer { get; set; }
        public string QuizQuestion { get; set; }
        public string PopUpTitle { get; set; }
    }
}