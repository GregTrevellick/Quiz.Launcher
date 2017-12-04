using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.CategoryQuestions.DotNet
{
    internal class DotNetQuestions : IGetQuizQuestions
    {
        private const Category Category = Entities.Category.DotNet;

        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                #region mine
                //Common.Get(Category, DifficultyLevel.Hard, "What is meant by DACPAC?",
                //"Data-tier Application Component Packages",
                //"Todo",
                //"Todo",
                //"Todo",
                //"Todo"),
                Common.Get(Category, DifficultyLevel.Hard, "Are you a .Netter ?",
                    "Yes",
                    "No",
                    "Don't know",
                    "Don't care",
                    "What is .Net ?"),
                #endregion

                #region web camp training kit
                Common.Get(Category, DifficultyLevel.Medium, "When was .NET first released?",
                    "2002",
                    "2000",
                    "2001",
                    "2003"),
                Common.Get(Category, DifficultyLevel.Hard, "How many loop constructs are there in C#?",
                    "4",
                    "2",
                    "3",
                    "5"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "Which release of the .NET Framework introduced support for dynamic languages?",
                    "4.0",
                    "1.1",
                    "2.0",
                    "3.5"),
                Common.Get(Category, DifficultyLevel.Easy,
                    "Which of the following is NOT a value type in the .NET Framework Common Type System?",
                    "System.String",
                    "System.Integer",
                    "System.DateTime",
                    "System.Float"),
                #endregion
            };

            return quizQuestions;
        }
    }
}


