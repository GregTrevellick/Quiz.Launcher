using System;

namespace Quiz.Core
{
    public static class Constants
    {
        public const int RecommendedMaximumTimeoutMilliSeconds = 3000;
        public const int RecommendedMinimumTimeoutMilliSeconds = 400;
        public const string CategoryFromQuestions = " category.";
        public const string CategorySubLevelFrequency = "Frequency";
        public const string CategorySubLevelGeneral = "General";
        public const string CategorySubLevelMiscellaneous = "Miscellaneous";
        public const string CategorySubLevelPreferences = "Preferences";
        public const string CategorySubLevelQuizCategories = "Categories";
        public const string CategorySubLevelTriggers = "Triggers";        
        public const string DefaultMaximumPopUpsPerDay = "1";
        public const string DefaultMaximumPopUpsWeekDay = "1";
        public const string DefaultMaximumPopUpsWeekEnd = "99";
        public const string DefaultPopUpIntervalInMins = "0";
        public const string DefaultTimeOutInMilliSeconds = "1500";     
        public const string DescriptionCSharp = "C#";
        public const string DescriptionDotNet = ".Net";
        public const string DescriptionGeek = "Geek";
        public const string DescriptionJavascript = "Javascript";
        public const string DescriptionFrontEnd = "Front End";
        public const string Include = "Include ";
        public const string IncludeOrOmitQuestionsInThe = "Include or omit questions in the ";
        public const string IncludeQuizCategoryCSharpOptionDetailedDescription = IncludeOrOmitQuestionsInThe + DescriptionCSharp + CategoryFromQuestions;
        public const string IncludeQuizCategoryCSharpOptionLabel = Include + DescriptionCSharp + Questions;
        public const string IncludeQuizCategoryDotNetOptionDetailedDescription = IncludeOrOmitQuestionsInThe + DescriptionDotNet + CategoryFromQuestions;
        public const string IncludeQuizCategoryDotNetOptionLabel = Include + DescriptionDotNet + Questions;
        public const string IncludeQuizCategoryFrontEndOptionDetailedDescription = IncludeOrOmitQuestionsInThe + DescriptionFrontEnd + CategoryFromQuestions;
        public const string IncludeQuizCategoryFrontEndOptionLabel = Include + DescriptionFrontEnd + Questions;
        public const string IncludeQuizCategoryGeekOptionDetailedDescription = IncludeOrOmitQuestionsInThe + DescriptionGeek + CategoryFromQuestions;
        public const string IncludeQuizCategoryGeekOptionLabel = Include + DescriptionGeek + Questions;
        public const string IncludeQuizCategoryJavascriptOptionDetailedDescription = IncludeOrOmitQuestionsInThe + DescriptionJavascript + CategoryFromQuestions;
        public const string IncludeQuizCategoryJavascriptOptionLabel = Include + DescriptionJavascript + Questions;
        public const string MaximumPopUpsWeekDayDetailedDescription = "The maximum number of quiz questions you will see on any one week day. Use this setting to reduce the volume of quiz questions during the working week.";
        public const string MaximumPopUpsWeekDayOptionLabel = "Daily pop-up limit (midweek)";
        public const string MaximumPopUpsWeekEndDetailedDescription = "The maximum number of quiz questions you will see on either a Saturday or a Sunday. Use this setting to increase the volume of quiz questions in your free time.";
        public const string MaximumPopUpsWeekEndOptionLabel = "Daily pop-up limit (weekend)";
        public const string PopUpIntervalInMinsOptionDetailedDescription = "Use this setting to reduce the overall frequency with which you see quiz questions (especially if you open a lot of solution files in a short time frame). This is the minimum number of minutes after a quiz question is displayed before you will see another quiz question.";
        public const string PopUpIntervalInMinsOptionLabel = "Number of minutes between pop-ups";
        public const string Questions = " questions";
        public const string ShowQuizUponClosingSolutionOptionDetailedDescription = ShowQuizUponClosingSolutionOptionLabel + " (requires restart of Visual Studio).";
        public const string ShowQuizUponClosingSolutionOptionLabel = "Show pop-up when closing a solution";
        public const string ShowQuizUponOpeningSolutionOptionDetailedDescription = ShowQuizUponOpeningSolutionOptionLabel + " (requires restart of Visual Studio).";
        public const string ShowQuizUponOpeningSolutionOptionLabel = "Show pop-up when opening a solution";
        public const string ShowQuizUponOpeningStartPageOptionDetailedDescription = ShowQuizUponOpeningStartPageOptionLabel + " (requires restart of Visual Studio).";
        public const string ShowQuizUponOpeningStartPageOptionLabel = "Show pop-up when opening start page";
        public const string SuppressClosingWithoutSubmitingAnswerWarningOptionDetailedDescription = "Suppress the warning that appears when closing the quiz window without having answered the question first. By showing the warning you can avoid being disappointed by closing the quiz question without ever knowing the answer.";
        public const string SuppressClosingWithoutSubmitingAnswerWarningOptionLabel = "Suppress early closure warning";
        public const string TimeOutInMilliSecondsOptionDetailedDescription = "The maximum time in milliseconds for this extension to spend retrieving the quiz question data from the third party data source. This value is used as the timeout parameter when calling the external web service. A value of zero is ignored by the external web service call and will not cause an instant timeout.";
        public const string TimeOutInMilliSecondsOptionLabel = "Timeout limit (milliseconds)";
        public const string UseBingInsteadOfGoogleOptionDetailedDescription = "Once a question has been answered a hyperlink for the question appears. By default this link will search for the question using the google search engine. If you prefer the bing search engine set this to 'true'.";
        public const string UseBingInsteadOfGoogleOptionLabel = "Bing instead of Google";
        public static string TimeOutInMilliSecondsIsOutsideRecommendedTimeoutLimits = $"Are you sure ?{Environment.NewLine}{Environment.NewLine}The value for '{TimeOutInMilliSecondsOptionLabel}' is outside the recommended limits, which means the data retrieval may timeout before completion or may wait for a long time to complete.";

        public static string GetCaption(string vsixName, string vsixVersion)
        {
            return $"{vsixName} {vsixVersion}";
        }

        public static string GetInvalidInteger(string labelName)
        {
            return $"Invalid integer value specified for '{labelName}'";
        }

        //public static string HelpText(string optionsName)
        //{
        //    return $"To alter the frequency and volume of quiz questions go to Tools | Options | {optionsName}";
        //}
    }
}   