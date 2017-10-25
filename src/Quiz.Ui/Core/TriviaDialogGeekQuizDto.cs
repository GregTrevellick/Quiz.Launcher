using System.Collections.Generic;
using Quiz.Ui.Gateway;

namespace Quiz.Ui.Core
{
    public class TriviaDialogGeekQuizDto ///////////: TriviaDialogDtoBase
    {
        //public TriviaDialogGeekQuizDto(string optionsName, string popUpTitle, string errorDetails) : base(optionsName, popUpTitle, errorDetails)
        //{
        //}

        public string GeekQuizDifficulty { get; set; }
        public IEnumerable<string> GeekQuizMultipleChoiceAnswers { get; set; }
        public string GeekQuizMultipleChoiceCorrectAnswer { get; set; }
        public QuestionType GeekQuizQuestionType { get; set; }
        public string GeekQuizQuestion { get; set; }
        public string ErrorDetails { get; set; }
        public string OptionsName { get; set; }
        public string PopUpTitle { get; set; }
    }
}