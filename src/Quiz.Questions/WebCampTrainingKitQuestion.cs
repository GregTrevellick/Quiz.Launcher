using System.Collections.Generic;

namespace Quiz.Questions
{
    public class WebCampTrainingKitQuestion
    {
        public string QuestionText { get; set; }
        public List<WebCampTrainingKitAnswer> Answers { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
    }
}