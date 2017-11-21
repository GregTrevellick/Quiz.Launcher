using System.ComponentModel;
using Microsoft.VisualStudio.Shell;
using Quiz.Ui.Core;

namespace Quiz.Ui.Options
{
    public class GeneralOptions : DialogPage
    {
        private string caption = Constants.GetCaption(Vsix.Name, Vsix.Version);
        private bool firstTimeOpeningOptions = true;
        private string maximumPopUpsWeekDay;
        private string maximumPopUpsWeekEnd;
        private string popUpIntervalInMins;
        private bool proceedToSaveOptions;
        private string timeOutInMilliSeconds;

        [Category(Constants.CategorySubLevelFrequency)]
        [DisplayName(Constants.MaximumPopUpsWeekDayOptionLabel)]
        [Description(Constants.MaximumPopUpsWeekDayDetailedDescription)]
        public string MaximumPopUpsWeekDay
        {
            get => string.IsNullOrEmpty(maximumPopUpsWeekDay) ? Constants.DefaultMaximumPopUpsWeekDay : maximumPopUpsWeekDay;
            set
            {
                if (value.IsNonNegativeInteger())
                {
                    maximumPopUpsWeekDay = value;
                }
                else
                {
                    MessageBoxes.DisplayInvalidIntegerError(Constants.MaximumPopUpsWeekDayOptionLabel, caption);
                }
            }
        }

        [Category(Constants.CategorySubLevelFrequency)]
        [DisplayName(Constants.MaximumPopUpsWeekEndOptionLabel)]
        [Description(Constants.MaximumPopUpsWeekEndDetailedDescription)]
        public string MaximumPopUpsWeekEnd
        {
            get => string.IsNullOrEmpty(maximumPopUpsWeekEnd) ? Constants.DefaultMaximumPopUpsWeekEnd : maximumPopUpsWeekEnd;
            set
            {
                if (value.IsNonNegativeInteger())
                {
                    maximumPopUpsWeekEnd = value;
                }
                else
                {
                    MessageBoxes.DisplayInvalidIntegerError(Constants.MaximumPopUpsWeekEndOptionLabel, caption);
                }
            }
        }

        [Category(Constants.CategorySubLevelFrequency)]
        [DisplayName(Constants.PopUpIntervalInMinsOptionLabel)]
        [Description(Constants.PopUpIntervalInMinsOptionDetailedDescription)]
        public string PopUpIntervalInMins
        {
            get => string.IsNullOrEmpty(popUpIntervalInMins) ? Constants.DefaultPopUpIntervalInMins : popUpIntervalInMins;
            set
            {
                if (value.IsNonNegativeInteger())
                {
                    popUpIntervalInMins = value;
                }
                else
                {
                    MessageBoxes.DisplayInvalidIntegerError(Constants.PopUpIntervalInMinsOptionLabel, caption);
                }
            }
        }

        [Category(Constants.CategorySubLevelMiscellaneous)]
        [DisplayName(Constants.TimeOutInMilliSecondsOptionLabel)]
        [Description(Constants.TimeOutInMilliSecondsOptionDetailedDescription)]
        public string TimeOutInMilliSeconds
        {
            get => string.IsNullOrEmpty(timeOutInMilliSeconds) ? Constants.DefaultTimeOutInMilliSeconds : timeOutInMilliSeconds;
            set
            {
                if (value.IsNonNegativeInteger())
                {
                    if (value.IsWithinRecommendedTimeoutLimits())
                    {
                        timeOutInMilliSeconds = value;
                    }
                    else
                    {
                        if (proceedToSaveOptions)
                        {
                            timeOutInMilliSeconds = value;
                        }
                        else
                        {
                            if (firstTimeOpeningOptions)
                            {
                                firstTimeOpeningOptions = false;
                                timeOutInMilliSeconds = value;
                            }
                            else
                            {
                                proceedToSaveOptions = MessageBoxes.ConfirmProceedToSaveTimeOutInMilliSeconds(caption);
                                if (proceedToSaveOptions)
                                {
                                    timeOutInMilliSeconds = value;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBoxes.DisplayInvalidIntegerError(Constants.TimeOutInMilliSecondsOptionLabel, caption);
                }
            }
        }

        [Category(Constants.CategorySubLevelPreferences)]
        [DisplayName(Constants.UseBingInsteadOfGoogleOptionLabel)]
        [Description(Constants.UseBingInsteadOfGoogleOptionDetailedDescription)]
        public bool UseBingInsteadOfGoogle { get; set; } = false;

        [Category(Constants.CategorySubLevelTriggers)]
        [DisplayName(Constants.ShowQuizUponClosingSolutionOptionLabel)]
        [Description(Constants.ShowQuizUponClosingSolutionOptionDetailedDescription)]
        public bool ShowQuizUponClosingSolution { get; set; } = false;

        [Category(Constants.CategorySubLevelTriggers)]
        [DisplayName(Constants.ShowQuizUponOpeningSolutionOptionLabel)]
        [Description(Constants.ShowQuizUponOpeningSolutionOptionDetailedDescription)]
        public bool ShowQuizUponOpeningSolution { get; set; } = false;

        [Category(Constants.CategorySubLevelTriggers)]
        [DisplayName(Constants.ShowQuizUponOpeningStartPageOptionLabel)]
        [Description(Constants.ShowQuizUponOpeningStartPageOptionDetailedDescription)]
        public bool ShowQuizUponOpeningStartPage { get; set; } = false;

        [Category(Constants.CategorySubLevelPreferences)]
        [DisplayName(Constants.SuppressClosingWithoutSubmitingAnswerWarningOptionLabel)]
        [Description(Constants.SuppressClosingWithoutSubmitingAnswerWarningOptionDetailedDescription)]
        public bool SuppressClosingWithoutSubmitingAnswerWarning { get; set; } = false;
    }
}