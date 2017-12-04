using Quiz.Core;
using Quiz.Questions.Entities;

namespace Quiz.Ui
{
    public class QuizHelperDto : QuizHelperBaseDto
    {
        public GeekCategory PreferredGeekCategoriesFromOptions;

        public Category Category
        {
            get
            {
                var categoryToSupply = CategoryHelper.GetCategoryToSupply(PreferredGeekCategoriesFromOptions);
                return categoryToSupply;
            }
        }
    }
}