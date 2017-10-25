using System.Collections.Generic;
using GeekQuiz.Ui.GeekQuiz.Gateway;

namespace GeekQuiz.Ui.GeekQuiz.Common
{
    public class TriviaDialogGeekQuizDto : TriviaDialogDtoBase
    {
        public TriviaDialogGeekQuizDto(string optionsName, string popUpTitle, string errorDetails) : base(optionsName, popUpTitle, errorDetails)
        {
        }

        public string GeekQuizDifficulty { get; set; }
        public IEnumerable<string> GeekQuizMultipleChoiceAnswers { get; set; }
        public string GeekQuizMultipleChoiceCorrectAnswer { get; set; }
        public QuestionType GeekQuizQuestionType { get; set; }
        public string GeekQuizQuestion { get; set; }
    }
}