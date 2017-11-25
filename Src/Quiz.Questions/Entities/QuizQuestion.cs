using System.Collections.Generic;

namespace Quiz.Questions.Entities
{
    public class QuizQuestion 
    {
        public Category Category { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }
        public IEnumerable<string> MultipleChoiceAnswers { get; set; }
        public string MultipleChoiceCorrectAnswer { get; set; }
        public string Question { get; set; }
        public QuestionType QuestionType { get; set; }
        public string ErrorDetails { get; set; }
    }
}
