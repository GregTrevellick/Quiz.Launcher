using System;
using Quiz.Questions.Entities;

namespace Quiz.Questions.Interfaces
{
    public interface IQuizQuestionApi
    {
        DifficultyLevel GetDifficultyLevel(string textBlockDifficultyText);
        QuizQuestion GetQuizQuestion(Category preferredCategoriesFromOptions, int timeOutInMilliSeconds, string timeOutInMilliSecondsOptionLabel, string optionName);
        void HandleUnexpectedError(Exception ex);
    }
}