namespace Quiz.Ui.Core
{
    public class TriviaDialogDtoBase
    {
        public TriviaDialogDtoBase(string optionsName, string popUpTitle, string errorDetails)
        {
            ErrorDetails = errorDetails;
            OptionsName = optionsName;
            PopUpTitle = popUpTitle;
        }

        public string ErrorDetails { get; set; }
        public string OptionsName { get; set; }
        public string PopUpTitle { get; set; }
    }
}