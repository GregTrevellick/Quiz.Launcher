using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.WebDev
{
    internal class WebDevQuestions
    {
        public static IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                Common.Get(Category.Geek, DifficultyLevel.Hard,
                    "How many HTML tags are defined in the original description of the markup language?",
                    "18",
                    "1",
                    "11",
                    "25"),
            };

            return quizQuestions;
        }
    }
}
