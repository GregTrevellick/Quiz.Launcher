using Quiz.Questions;

namespace Quiz.Ui.Music
{
    public interface IQuizHelper
    {
        event QuizHelper.QuizHelperEventHandler PersistHiddenOptionsQuizHelperEventHandlerEventHandler;

        HiddenOptionsDto DisplayPopUpQuiz(QuizHelperDto quizHelperDto, IQuizQuestionApi quizQuestionApi);
    }
}