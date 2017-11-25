using Quiz.Questions.Entities;

namespace Quiz.Questions.Interfaces
{
    public interface IQuizQuestionApi
    {
        QuizQuestion GetQuizQuestion(Category preferredCategoriesFromOptions, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName);
        DifficultyLevel GetDifficultyLevel(string textBlockDifficultyText);
    }
}