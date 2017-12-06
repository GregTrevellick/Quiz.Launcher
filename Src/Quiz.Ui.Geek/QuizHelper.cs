using MoreLinq;
using Quiz.Core;
using Quiz.Questions.Entities;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using Quiz.Questions;

namespace Quiz.Ui
{
    public class QuizHelper
    {
        public delegate void QuizHelperEventHandler(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectlyEasy, int? totalQuestionsAnsweredCorrectlyMedium, int? totalQuestionsAnsweredCorrectlyHard);
        public event QuizHelperEventHandler PersistHiddenOptionsQuizHelperEventHandlerEventHandler;

        public HiddenOptionsDto GetHiddenOptionsDto(QuizHelperDto quizHelperDto, IQuizQuestionApi quizQuestionApi)
        {       
            var quizQuestion = quizQuestionApi.GetQuizQuestion(quizHelperDto.Category, quizHelperDto.TimeOutInMilliSeconds, Constants.TimeOutInMilliSecondsOptionLabel, quizHelperDto.OptionsName);

            var quizDialogDto = QuizHelperCore.GetQuizDialogDto(quizQuestion, Vsix.Name);

            //gregt surround with "if (quizDialogDto.MultipleChoiceAnswers.Any())"
            DisplayPopUpMessage(quizDialogDto, quizHelperDto.SuppressClosingWithoutSubmitingAnswerWarning,
                quizHelperDto.TotalQuestionsAnsweredCorrectlyEasy, quizHelperDto.TotalQuestionsAnsweredCorrectlyMedium, quizHelperDto.TotalQuestionsAnsweredCorrectlyHard, quizHelperDto.TotalQuestionsAsked, quizHelperDto.SearchEngine);

            var hiddenOptionsDto = QuizHelper.GetHiddenOptionsDto(quizHelperDto.LastPopUpDateTime, quizHelperDto.PopUpCountToday);

            return hiddenOptionsDto;
        }

        void PersistHiddenOptions(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectlyEasy, int? totalQuestionsAnsweredCorrectlyMedium, int? totalQuestionsAnsweredCorrectlyHard)
        {
            PersistHiddenOptionsQuizHelperEventHandlerEventHandler?.Invoke(totalQuestionsAsked, totalQuestionsAnsweredCorrectlyEasy, totalQuestionsAnsweredCorrectlyMedium, totalQuestionsAnsweredCorrectlyHard);
        }

        private void DisplayPopUpMessage(QuizDialogDto quizDialogDto, bool? suppressClosingWithoutSubmitingAnswerWarning,
            int? totalQuestionsAnsweredCorrectlyEasy, int? totalQuestionsAnsweredCorrectlyMedium, int? totalQuestionsAnsweredCorrectlyHard, int? totalQuestionsAsked, SearchEngine searchEngine)//gregt long list of params
        {
            var vsixQuizDialog = new VsixQuizDialog
            {
                CorrectAnswer = quizDialogDto.MultipleChoiceCorrectAnswer,
                QuestionType = quizDialogDto.QuestionType,
                SearchEngine = searchEngine,
                SuppressClosingWithoutSubmitingAnswerWarning = suppressClosingWithoutSubmitingAnswerWarning.HasValue ? suppressClosingWithoutSubmitingAnswerWarning.Value : false,
                TotalQuestionsAnsweredCorrectlyEasy = totalQuestionsAnsweredCorrectlyEasy,
                TotalQuestionsAnsweredCorrectlyMedium = totalQuestionsAnsweredCorrectlyMedium,
                TotalQuestionsAnsweredCorrectlyHard = totalQuestionsAnsweredCorrectlyHard,
                TotalQuestionsAsked = totalQuestionsAsked,
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

            quizDialogDto.MultipleChoiceAnswers = quizDialogDto.MultipleChoiceAnswers.Where(x => !string.IsNullOrWhiteSpace(x));//gregt dedupe

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

            if (totalQuestionsAnsweredCorrectlyMedium.HasValue && totalQuestionsAsked.HasValue)
            {
                vsixQuizDialog.TextBlockTotalQuestionsAnsweredCorrectly.Text = totalQuestionsAnsweredCorrectlyMedium.ToString();
                vsixQuizDialog.TextBlockTotalQuestionsAsked.Text = totalQuestionsAsked.ToString();
                var percentageSuccess = QuizHelperCore.GetPercentageSuccess(totalQuestionsAnsweredCorrectlyMedium, totalQuestionsAsked);
                var userStatus = QuizHelperCore.GetUserStatus(percentageSuccess);
                vsixQuizDialog.TextBlockUserStatus.Text = userStatus;
                var userRank = QuizHelperCore.GetUserRank(percentageSuccess);
                vsixQuizDialog.TextBlockUserRank.Text = userRank;
            }

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

        private static void RandomlyPopulateUiTrueFalseAnswers(QuizDialogDto quizDialogDto, VsixQuizDialog vsixQuizDialog)//gregt dedupe
        {
            var trueFollowedByFalseAnswers = quizDialogDto.MultipleChoiceAnswers.OrderByDescending(x => x).Select(x => x).ToArray();
            vsixQuizDialog.RadioButton1.Content = trueFollowedByFalseAnswers[0];
            vsixQuizDialog.RadioButton2.Content = trueFollowedByFalseAnswers[1];
        }

        private static void RandomlyPopulateUiMultiChoiceAnswers(QuizDialogDto quizDialogDto, VsixQuizDialog vsixQuizDialog)
        {
            var random = new Random();
            var randomlySortedAnswers =
                quizDialogDto.MultipleChoiceAnswers.OrderBy(x => random.Next()).Select(x => x).ToArray();//gregt dedupe

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
