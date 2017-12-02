//using Quiz.Core;
//using Quiz.Questions.Entities;

//namespace Quiz.Ui.Core
//{
//    public class GeneralOptionsDto : HiddenOptionsDto
//    {
//        public bool IncludeQuizCategoryCSharp { get; set; } 
//        public bool IncludeQuizCategoryDotNet { get; set; } 
//        public bool IncludeQuizCategoryGeek { get; set; } 
//        public bool IncludeQuizCategoryJavascript { get; set; } 
//        public bool IncludeQuizCategoryWebDev { get; set; } 
//        public int MaximumPopUpsWeekDay { get; set; }
//        public int MaximumPopUpsWeekEnd { get; set; }
//        public int PopUpIntervalInMins { get; set; }
//        public SearchEngine SearchEngine { get; set; }
//        public bool ShowQuizUponClosingSolution { get; set; }
//        public bool ShowQuizUponOpeningStartPage { get; set; }
//        public bool ShowQuizUponOpeningSolution { get; set; }
//        public bool SuppressClosingWithoutSubmitingAnswerWarning { get; set; }
//        public int TimeOutInMilliSeconds { get; set; }

//        internal Category PreferredCategoriesFromOptions
//        {
//            get
//            {
//                Category preferredCategoriesFromOptions = 0;

//                preferredCategoriesFromOptions |= IncludeQuizCategoryCSharp ? Category.CSharp : Category.Unknown;
//                preferredCategoriesFromOptions |= IncludeQuizCategoryDotNet ? Category.DotNet : Category.Unknown;
//                preferredCategoriesFromOptions |= IncludeQuizCategoryGeek ? Category.Geek : Category.Unknown;
//                preferredCategoriesFromOptions |= IncludeQuizCategoryJavascript ? Category.Javascript : Category.Unknown;
//                preferredCategoriesFromOptions |= IncludeQuizCategoryWebDev ? Category.WebDev : Category.Unknown;

//                preferredCategoriesFromOptions &= ~Category.Unknown;

//                return preferredCategoriesFromOptions;
//            }
//        }
//    }
//}