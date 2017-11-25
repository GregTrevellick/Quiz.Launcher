namespace Quiz.Ui.Core
{
    public class GeneralOptionsDto : HiddenOptionsDto
    {
        public bool IncludeQuizCategoryCSharp { get; set; } 
        public bool IncludeQuizCategoryDotNet { get; set; } 
        public bool IncludeQuizCategoryGeek { get; set; } 
        public bool IncludeQuizCategoryJavascript { get; set; } 
        public bool IncludeQuizCategoryWebDev { get; set; } 
        public int MaximumPopUpsWeekDay { get; set; }
        public int MaximumPopUpsWeekEnd { get; set; }
        public int PopUpIntervalInMins { get; set; }
        public SearchEngine SearchEngine { get; set; }
        public bool ShowQuizUponClosingSolution { get; set; }
        public bool ShowQuizUponOpeningStartPage { get; set; }
        public bool ShowQuizUponOpeningSolution { get; set; }
        public bool SuppressClosingWithoutSubmitingAnswerWarning { get; set; }
        public int TimeOutInMilliSeconds { get; set; }
    }
}