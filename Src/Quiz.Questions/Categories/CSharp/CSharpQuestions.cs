using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.CSharp
{
    internal class CSharpQuestions : IGetQuizQuestions
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            //gregt very hard question
            //category &= ~Category.Unknown   https://stackoverflow.com/questions/4778166/how-to-remove-an-item-for-a-ord-enum

            var quizQuestions = new List<QuizQuestion>
            {
                Common.Get(Category.Geek, DifficultyLevel.Hard,
                    "What was the original name of the C# programming language?",
                    "Cool",
                    "Boo",
                    "C+++",
                    "Anders"),
                Common.Get(Category.Geek, DifficultyLevel.Medium,
                    "Which of the following is an example of Boxing in C#?",
                    "object bar = 42;",
                    "int foo = 12;",
                    "System.Box(56);",
                    "int foo = (int)bar;"),
            };

            return quizQuestions;
        }
    }
}
