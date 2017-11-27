using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.WebDev
{
    internal class WebDevQuestions : IGetQuizQuestions
    {
        private const Category Category = Entities.Category.WebDev;

        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                #region mine
                //webkit=?
                #endregion
                #region jeopardy / web camp training kit
                Common.Get(Category, DifficultyLevel.Hard,
                    "How many HTML tags are defined in the original description of the markup language?",
                    "18",
                    "1",
                    "11",
                    "25"),
                #endregion
            };

            return quizQuestions;
        }
    }
}
