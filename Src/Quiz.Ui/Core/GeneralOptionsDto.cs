namespace Quiz.Ui.Core
{
    public class GeneralOptionsDto : HiddenOptionsDto
    {
        //////////////////////public int MaximumPopUpsPerDayWeekDay { get; set; }
        public int MaximumPopUpsWeekDay { get; set; }
        public int MaximumPopUpsWeekEnd { get; set; }
        public int PopUpIntervalInMins { get; set; }
        public SearchEngine SearchEngine { get; set; }
        public bool ShowQuizUponClosingSolution { get; set; }
        //public bool ShowQuizUponOpeningIde { get; set; }
        public bool ShowQuizUponOpeningStartPage { get; set; }
        public bool ShowQuizUponOpeningSolution { get; set; }
        public bool SuppressClosingWithoutSubmitingAnswerWarning { get; set; }
        public int TimeOutInMilliSeconds { get; set; }
    }
}