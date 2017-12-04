using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.Javascript
{
    internal class JavascriptQuestions : IGetQuizQuestions
    {
        private const Category Category = Entities.Category.Javascript;

        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                #region mine
                //Ecma?
                //iife?
                #endregion
             
                #region web camp training kit
                Common.Get(Category, DifficultyLevel.Medium, "Which is not actually a Thing.js?",
                    "Horseradish.js",
                    "Mustache.js",
                    "Hammer.js",
                    "Uglify.js"),
                Common.Get(Category, DifficultyLevel.Medium,
                    "What is the value of an Object + Array in JavaScript?",
                    "0",
                    "Array",
                    "Object",
                    "Type Error"),
                Common.Get(Category, DifficultyLevel.Hard,
                    "Which of the following ECMA standards represents the standardization of JavaScript?",
                    "ECMA-262",
                    "ECMA-123",
                    "ECMA-301",
                    "ECMA-431"),
                #endregion
            };

            return quizQuestions;
        }
    }
}
