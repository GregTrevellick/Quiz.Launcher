//using Quiz.Questions.Entities;

//namespace Quiz.Ui
//{
//    public class GeneralOptionsGeekCategoryDto   //gregt inherit from GeneralOptionsDto ?
//    {
//        public bool IncludeQuizCategoryCSharp { get; set; }
//        public bool IncludeQuizCategoryDotNet { get; set; }
//        public bool IncludeQuizCategoryGeek { get; set; }
//        public bool IncludeQuizCategoryJavascript { get; set; }
//        public bool IncludeQuizCategoryWebDev { get; set; }

//        public GeekCategory PreferredGeekCategoriesFromOptions
//        {
//            get
//            {
//                GeekCategory preferredGeekCategoriesFromOptions = 0;

//                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryCSharp ? GeekCategory.CSharp : GeekCategory.Unknown;
//                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryDotNet ? GeekCategory.DotNet : GeekCategory.Unknown;
//                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryGeek ? GeekCategory.Geek : GeekCategory.Unknown;
//                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryJavascript ? GeekCategory.Javascript : GeekCategory.Unknown;
//                preferredGeekCategoriesFromOptions |= IncludeQuizCategoryWebDev ? GeekCategory.WebDev : GeekCategory.Unknown;

//                preferredGeekCategoriesFromOptions &= ~GeekCategory.Unknown;

//                return preferredGeekCategoriesFromOptions;
//            }
//        }
//    }
//}