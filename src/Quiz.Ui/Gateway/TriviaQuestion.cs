using System.Collections.Generic;

namespace Quiz.Ui.Gateway
{
    public class TriviaQuestion
    {
        public string Question { get; set; }
        public List<TriviaAnswer> Answers { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
    }
}