using System.Collections.Generic;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Categories.Geek.WebCampTrainingKit
{
    internal class WebCampTrainingKitQuestion
    {
        public List<WebCampTrainingKitAnswer> Answers { get; set; }
        public Category Category = Category.Geek; ////////////{ get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public string QuestionText { get; set; }
    }
}