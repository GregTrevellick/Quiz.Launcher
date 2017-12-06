using Quiz.Core;
using Quiz.Questions;
using Quiz.Questions.Entities;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace Quiz.Ui
{
    public class QuizHelper
    {
        public delegate void QuizHelperEventHandler(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectlyEasy, int? totalQuestionsAnsweredCorrectlyMedium, int? totalQuestionsAnsweredCorrectlyHard);
        public event QuizHelperEventHandler PersistHiddenOptionsQuizHelperEventHandlerEventHandler;

        public HiddenOptionsDto GetHiddenOptionsDto(QuizHelperDto quizHelperDto, IQuizQuestionApi quizQuestionApi)
        {       
            var quizQuestion = quizQuestionApi.GetQuizQuestion(quizHelperDto.Category, quizHelperDto.TimeOutInMilliSeconds, Constants.TimeOutInMilliSecondsOptionLabel, quizHelperDto.OptionsName);

            if (!string.IsNullOrEmpty(quizQuestion?.ErrorDetails) &&
                !string.IsNullOrEmpty(quizQuestion.Question) &&
                !string.IsNullOrEmpty(quizQuestion.MultipleChoiceCorrectAnswer) &&
                quizQuestion.MultipleChoiceAnswers.Any())
            {
                var quizDialogDto = QuizHelperCore.GetQuizDialogDto(quizQuestion, Vsix.Name);

                DisplayPopUpMessage(quizDialogDto, quizHelperDto);

                var hiddenOptionsDto = QuizHelper.GetHiddenOptionsDto(quizHelperDto.LastPopUpDateTime, quizHelperDto.PopUpCountToday);

                return hiddenOptionsDto;
            }

            return null;
        }

        void PersistHiddenOptions(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectlyEasy, int? totalQuestionsAnsweredCorrectlyMedium, int? totalQuestionsAnsweredCorrectlyHard)
        {
            PersistHiddenOptionsQuizHelperEventHandlerEventHandler?.Invoke(totalQuestionsAsked, totalQuestionsAnsweredCorrectlyEasy, totalQuestionsAnsweredCorrectlyMedium, totalQuestionsAnsweredCorrectlyHard);
        }

        private void DisplayPopUpMessage(QuizDialogDto quizDialogDto, QuizHelperDto quizHelperDto)
        {
            var vsixQuizDialog = new VsixQuizDialog
            {
                CorrectAnswer = quizDialogDto.MultipleChoiceCorrectAnswer,
                QuestionType = quizDialogDto.QuestionType,
                SearchEngine = quizHelperDto.SearchEngine,
                SuppressClosingWithoutSubmitingAnswerWarning = quizHelperDto.SuppressClosingWithoutSubmitingAnswerWarning,
                TotalQuestionsAnsweredCorrectlyEasy = quizHelperDto.TotalQuestionsAnsweredCorrectlyEasy,
                TotalQuestionsAnsweredCorrectlyMedium = quizHelperDto.TotalQuestionsAnsweredCorrectlyMedium,
                TotalQuestionsAnsweredCorrectlyHard = quizHelperDto.TotalQuestionsAnsweredCorrectlyHard,
                TotalQuestionsAsked = quizHelperDto.TotalQuestionsAsked,
            };

            vsixQuizDialog.TextBlockErrorDetails.Text = quizDialogDto.ErrorDetails;

            vsixQuizDialog.PersistHiddenOptionsEventHandler += PersistHiddenOptions;

            vsixQuizDialog.TextBlockDifficulty.Text = "Difficulty: " + quizDialogDto.QuestionDifficulty;

            var run = new Run(quizDialogDto.QuizQuestion)
            {
                FontWeight = FontWeights.Bold
            };
            vsixQuizDialog.TextBlockQuestion.Inlines.Add(run);
            vsixQuizDialog.QuestionText = quizDialogDto.QuizQuestion?.Trim();

            if (!string.IsNullOrWhiteSpace(vsixQuizDialog.TextBlockErrorDetails.Text))
            {
                vsixQuizDialog.TextBlockErrorDetails.Visibility = Visibility.Visible;
            }

            quizDialogDto.MultipleChoiceAnswers = QuizHelperCore.GetPopulatedAnswers(quizDialogDto.MultipleChoiceAnswers);

            if (quizDialogDto.QuestionType == QuestionType.TrueFalse)
            {
                RandomlyPopulateUiTrueFalseAnswers(quizDialogDto, vsixQuizDialog);
            }
            else
            {
                RandomlyPopulateUiMultiChoiceAnswers(quizDialogDto, vsixQuizDialog);
            }

            SetRadioButtonVisibility(vsixQuizDialog.RadioButton1);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton2);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton3);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton4);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton5);

            vsixQuizDialog.TextBlockTotalQuestionsAnsweredCorrectly.Text = quizHelperDto.TotalQuestionsAnsweredCorrectlyMedium.ToString();
            vsixQuizDialog.TextBlockTotalQuestionsAsked.Text = quizHelperDto.TotalQuestionsAsked.ToString();
            var percentageSuccess = QuizHelperCore.GetPercentageSuccess(quizHelperDto.TotalQuestionsAnsweredCorrectlyMedium, quizHelperDto.TotalQuestionsAsked);
            var userStatus = QuizHelperCore.GetUserStatus(percentageSuccess);
            vsixQuizDialog.TextBlockUserStatus.Text = userStatus;
            var userRank = QuizHelperCore.GetUserRank(percentageSuccess);
            vsixQuizDialog.TextBlockUserRank.Text = userRank;

            //triviaDialog.Show();
            var window = new Window
            {
                Title = quizDialogDto.PopUpTitle,
                Content = vsixQuizDialog,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };

            SetWindowIcon(window);

            window.ResizeMode = ResizeMode.CanResize;
            window.ShowDialog();
        }

        private static void RandomlyPopulateUiTrueFalseAnswers(QuizDialogDto quizDialogDto, VsixQuizDialog vsixQuizDialog)
        {
            var trueFollowedByFalseAnswers = QuizHelperCore.GetTrueFollowedByFalseAnswers(quizDialogDto.MultipleChoiceAnswers);
            vsixQuizDialog.RadioButton1.Content = trueFollowedByFalseAnswers[0];
            vsixQuizDialog.RadioButton2.Content = trueFollowedByFalseAnswers[1];
        }

        private static void RandomlyPopulateUiMultiChoiceAnswers(QuizDialogDto quizDialogDto, VsixQuizDialog vsixQuizDialog)
        {
            var randomlySortedAnswers = QuizHelperCore.GetRandomlySortedAnswers(quizDialogDto.MultipleChoiceAnswers);

            if (randomlySortedAnswers.Length >= 1)
            {
                vsixQuizDialog.RadioButton1.Content = randomlySortedAnswers[0].Trim();
            }
            if (randomlySortedAnswers.Length >= 2)
            {
                vsixQuizDialog.RadioButton2.Content = randomlySortedAnswers[1].Trim();
            }
            if (randomlySortedAnswers.Length >= 3)
            {
                vsixQuizDialog.RadioButton3.Content = randomlySortedAnswers[2].Trim();
            }
            if (randomlySortedAnswers.Length >= 4)
            {
                vsixQuizDialog.RadioButton4.Content = randomlySortedAnswers[3].Trim();
            }
            if (randomlySortedAnswers.Length >= 5)
            {
                vsixQuizDialog.RadioButton5.Content = randomlySortedAnswers[4].Trim();
            }
        }

        private void SetWindowIcon(Window window)
        {
            var iconUri = GetIconUri();
            window.Icon = new BitmapImage(iconUri);
        }

        private Uri GetIconUri()
        {
            var assemblyName = "Quiz.Ui";
            var packUri = $"pack://application:,,,/{assemblyName};component/Resources/vsixextensionicon_90x90_resource_bb6_icon.ico";
            return new Uri(packUri, UriKind.RelativeOrAbsolute);
        }

        private void SetRadioButtonVisibility(RadioButton radioButton)
        {
            if (radioButton.Content != null && !string.IsNullOrWhiteSpace(radioButton.Content.ToString()))
            {
                radioButton.Visibility = Visibility.Visible;
            }
        }


        public static HiddenOptionsDto GetHiddenOptionsDto(DateTime lastPopUpDateTime, int popUpCountToday)
        {
            var hiddenOptionsDto = new HiddenOptionsDto();

            var baseDateTime = DateTime.Now;

            hiddenOptionsDto.PopUpCountToday = QuizHelperCore.GetPopUpCountToday(lastPopUpDateTime, popUpCountToday, baseDateTime);
            hiddenOptionsDto.LastPopUpDateTime = baseDateTime;

            return hiddenOptionsDto;
        }
    }
}
