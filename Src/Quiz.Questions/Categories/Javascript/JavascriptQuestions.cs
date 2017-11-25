using System.Collections.Generic;
using Quiz.Questions.Entities;
using Quiz.Questions.Interfaces;

namespace Quiz.Questions.Categories.Javascript
{
    internal class JavascriptQuestions : IGetQuizQuestions
    {
        public IEnumerable<QuizQuestion> GetQuizQuestions()
        {
            var quizQuestions = new List<QuizQuestion>
            {
                Common.Get(Category.Geek, DifficultyLevel.Medium, "Which is not actually a Thing.js?",
                    "Horseradish.js",
                    "Mustache.js",
                    "Hammer.js",
                    "Uglify.js"),
                Common.Get(Category.Geek, DifficultyLevel.Medium,
                    "What is the value of an Object + Array in JavaScript?",
                    "0",
                    "Array",
                    "Object",
                    "Type Error"),
                Common.Get(Category.Geek, DifficultyLevel.Hard,
                    "Which of the following ECMA standards represents the standardization of JavaScript?",
                    "ECMA-262",
                    "ECMA-123",
                    "ECMA-301",
                    "ECMA-431"),
            };

            return quizQuestions;
        }
    }
}
