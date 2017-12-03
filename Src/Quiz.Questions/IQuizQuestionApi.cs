using Quiz.Questions.Entities;

namespace Quiz.Questions
{
    public interface IQuizQuestionApi
    {
        DifficultyLevel GetDifficultyLevel(string textBlockDifficultyText);
        QuizQuestion GetQuizQuestion(Category singleCategory, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName);
        string HandleArgumentOutOfRangeException(string argumentName, int argumentValue);
    }
}