using Quiz.Core;
using Quiz.Questions.Entities;

namespace Quiz.Ui
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

        public GeekCategory PreferredGeekCategoriesFromOptions
        {
            get
            {
                GeekCategory preferredGeekCategoriesFromOptions = 0;

                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryCSharp ? GeekCategory.CSharp : GeekCategory.Unknown;
                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryDotNet ? GeekCategory.DotNet : GeekCategory.Unknown;
                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryGeek ? GeekCategory.Geek : GeekCategory.Unknown;
                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryJavascript ? GeekCategory.Javascript : GeekCategory.Unknown;
                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryWebDev ? GeekCategory.WebDev : GeekCategory.Unknown;

                preferredGeekCategoriesFromOptions &= ~GeekCategory.Unknown;

                return preferredGeekCategoriesFromOptions;
            }
        }
    }
}