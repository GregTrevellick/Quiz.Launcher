using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
    }
}