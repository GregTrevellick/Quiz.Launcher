using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.DotNet
{
    internal class DotNetQuestions : IGetQuizQuestions
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                Common.Get(Category.Geek, DifficultyLevel.Medium, "When was .NET first released?",
                    "2002",
                    "2000",
                    "2001",
                    "2003"),
                Common.Get(Category.Geek, DifficultyLevel.Hard, "How many loop constructs are there in C#?",
                    "4",
                    "2",
                    "3",
                    "5"),
                Common.Get(Category.Geek, DifficultyLevel.Medium,
                    "Which release of the .NET Framework introduced support for dynamic languages?",
                    "4.0",
                    "1.1",
                    "2.0",
                    "3.5"),
                Common.Get(Category.Geek, DifficultyLevel.Easy,
                    "Which of the following is NOT a value type in the .NET Framework Common Type System?",
                    "System.String",
                    "System.Integer",
                    "System.DateTime",
                    "System.Float"),
            };

            return quizQuestions;
        }
    }
}
