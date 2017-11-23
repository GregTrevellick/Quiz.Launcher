using System.Collections.Generic;

namespace Quiz.Questions.WebCampTrainingKit
{
    public class WebCampTrainingKitQuestion
    {
        public List<WebCampTrainingKitAnswer> Answers { get; set; }
        public Category Category { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public string QuestionText { get; set; }
    }
}