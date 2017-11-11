using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class WebCampTrainingKitQuestion
    {
        public string QuestionText { get; set; }
        public List<WebCampTrainingKitAnswer> Answers { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
    }
}