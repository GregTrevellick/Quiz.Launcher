using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.CSharp
{
    internal class CSharpQuestions : IGetQuizQuestions
    {
        private const Category Category = Entities.Category.CSharp;

        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                #region mine
                Common.Get(Category, DifficultyLevel.Hard,
                    "The following valid C# code:   var weekDays &= ~WeekDays.Sunday   ?",
                    "true",
                    "false"),
                #endregion
                #region web camp training kit
                Common.Get(Category, DifficultyLevel.Hard,
                    "What was the original name of the C# programming language?",
                    "Cool",
                    "Boo",
                    "C+++",
                    "Anders"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Which of the following is an example of Boxing in C#?",
                    "object bar = 42;",
                    "int foo = 12;",
                    "System.Box(56);",
                    "int foo = (int)bar;"),
                #endregion
            };

            return quizQuestions;
        }
    }
}
