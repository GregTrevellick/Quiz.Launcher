using Quiz.Questions;

namespace Quiz.Ui
{
    public interface IQuizHelper
    {
        event QuizHelper.QuizHelperEventHandler PersistHiddenOptionsQuizHelperEventHandlerEventHandler;

        HiddenOptionsDto DisplayPopUpQuiz(QuizHelperDto quizHelperDto, IQuizQuestionApi quizQuestionApi);
    }
}