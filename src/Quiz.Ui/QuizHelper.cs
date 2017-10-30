using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using Quiz.Ui.Core;
using Quiz.Ui.Gateway;

namespace Quiz.Ui
{
    public class QuizHelper
    {
        public delegate void MyEventHandler2(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectly);
        public event MyEventHandler2 PersistHiddenOptionsEventHandler2;//gregt rename to remove '2' suffix

        public HiddenOptionsDto ShowQuiz(string popUpTitle, DateTime lastPopUpDateTime, int popUpCountToday, int timeOutInMilliSeconds, string optionsName, bool suppressClosingWithoutSubmitingAnswerWarning, int totalQuestionsAnsweredCorrectly, int totalQuestionsAsked)
        {
            HiddenOptionsDto hiddenOptionsDto = null;

            var clientGateway = new ClientGateway();
            var gatewayResponse = clientGateway.GetGatewayResponse(timeOutInMilliSeconds, Constants.TimeOutInMilliSecondsOptionLabel, optionsName);

            var quizDialogDto = GetQuizDialogDto(gatewayResponse);
            DisplayPopUpMessage(quizDialogDto, suppressClosingWithoutSubmitingAnswerWarning, totalQuestionsAnsweredCorrectly, totalQuestionsAsked);

            hiddenOptionsDto = GetHiddenOptionsDto(lastPopUpDateTime, popUpCountToday);

            return hiddenOptionsDto;
        }

        private static QuizDialogDto GetQuizDialogDto(GatewayResponse gatewayResponse)
        {
            var quizDialogDto =
                new QuizDialogDto
                {
                    MultipleChoiceAnswers = gatewayResponse.MultipleChoiceAnswers,
                    MultipleChoiceCorrectAnswer = gatewayResponse.MultipleChoiceCorrectAnswer,
                    QuestionDifficulty = gatewayResponse.DifficultyLevel,
                    QuestionType = gatewayResponse.QuestionType,
                    QuizQuestion = gatewayResponse.Question,
                };
            return quizDialogDto;
        }

        void PersistHiddenOptions(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectly)
        {
            PersistHiddenOptionsEventHandler2?.Invoke(totalQuestionsAsked, totalQuestionsAnsweredCorrectly);
        }

        private void DisplayPopUpMessage(QuizDialogDto quizDialogDto, bool? suppressClosingWithoutSubmitingAnswerWarning, int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked)
        {
            var vsixQuizDialog = new VsixQuizDialog
            {
                TextBlockErrorDetails = { Text = quizDialogDto.ErrorDetails },
                /////////////////////////Title = quizDialogDto.PopUpTitle,
                SuppressClosingWithoutSubmitingAnswerWarning =
                        suppressClosingWithoutSubmitingAnswerWarning.HasValue
                            ? suppressClosingWithoutSubmitingAnswerWarning.Value
                            : false,
                QuestionType = quizDialogDto.QuestionType,
                TotalQuestionsAnsweredCorrectly = totalQuestionsAnsweredCorrectly,
                TotalQuestionsAsked = totalQuestionsAsked,
                CorrectAnswer = quizDialogDto.MultipleChoiceCorrectAnswer
            };

            vsixQuizDialog.PersistHiddenOptionsEventHandler += PersistHiddenOptions;

            if (!string.IsNullOrWhiteSpace(quizDialogDto.QuestionDifficulty))
            {
                var run = new Run(quizDialogDto.QuestionDifficulty);
                vsixQuizDialog.TextBlockQuestion.Inlines.Add(run);
            }

            if (!string.IsNullOrWhiteSpace(quizDialogDto.QuizQuestion))
            {
                var run = new Run(quizDialogDto.QuizQuestion)
                {
                    FontWeight = FontWeights.Bold
                };
                vsixQuizDialog.TextBlockQuestion.Inlines.Add(run);
            }

            if (!string.IsNullOrWhiteSpace(vsixQuizDialog.TextBlockErrorDetails.Text))
            {
                vsixQuizDialog.TextBlockErrorDetails.Visibility = Visibility.Visible;
            }

            if (quizDialogDto.QuestionType != QuestionType.None)
            {
                vsixQuizDialog.ButtonSubmitMultiChoiceAnwser.Visibility = Visibility.Visible;

                if (quizDialogDto.QuestionType == QuestionType.TrueFalse)
                {
                    var trueFollowedByFalseAnswers = quizDialogDto.MultipleChoiceAnswers.OrderByDescending(x => x).Select(x => x).ToArray();
                    vsixQuizDialog.RadioButton1.Content = trueFollowedByFalseAnswers[0];
                    vsixQuizDialog.RadioButton2.Content = trueFollowedByFalseAnswers[1];
                }
                else
                {
                    var random = new Random();
                    var randomlySortedAnswers = quizDialogDto.MultipleChoiceAnswers.OrderBy(x => random.Next()).Select(x => x).ToArray();
                    vsixQuizDialog.RadioButton1.Content = randomlySortedAnswers[0];
                    vsixQuizDialog.RadioButton2.Content = randomlySortedAnswers[1];
                    vsixQuizDialog.RadioButton3.Content = randomlySortedAnswers[2];
                    vsixQuizDialog.RadioButton4.Content = randomlySortedAnswers[3];
                }
            }

            SetRadioButtonVisibility(vsixQuizDialog.RadioButton1);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton2);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton3);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton4);

            if (totalQuestionsAnsweredCorrectly.HasValue && totalQuestionsAsked.HasValue)
            {
                var userStatus = vsixQuizDialog.GetUserStatus(totalQuestionsAnsweredCorrectly, totalQuestionsAsked);
                vsixQuizDialog.TextBlockUserStatus.Text = userStatus;
                vsixQuizDialog.TextBlockUserStatus.Visibility = Visibility.Visible;
            }

            //triviaDialog.Show();
            var window = new Window
            {
                Title = "My User Control Dialog",
                Content = vsixQuizDialog,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            // var iconUri = new TriviaMessage().GetIconUri();
            // window.Icon = new BitmapImage(iconUri);
            window.ResizeMode = ResizeMode.CanResize;
            window.ShowDialog();
        }

        private void SetRadioButtonVisibility(RadioButton radioButton)
        {
            if (radioButton.Content != null && !string.IsNullOrWhiteSpace(radioButton.Content.ToString()))
            {
                radioButton.Visibility = Visibility.Visible;
            }
        }

        private HiddenOptionsDto GetHiddenOptionsDto(DateTime lastPopUpDateTime, int popUpCountToday)
        {
            var hiddenOptionsDto = new HiddenOptionsDto();

            var baseDateTime = DateTime.Now;

            if (IsANewDay(lastPopUpDateTime, baseDateTime))
            {
                hiddenOptionsDto.PopUpCountToday = 1;
            }
            else
            {
                hiddenOptionsDto.PopUpCountToday = popUpCountToday + 1;
            }

            hiddenOptionsDto.LastPopUpDateTime = baseDateTime;

            return hiddenOptionsDto;
        }

        private bool IsANewDay(DateTime lastPopUpDateTime, DateTime baseDateTime)
        {
            //If last pop up was yesterday, then we have gone past midnight, so this is first pop up for today
            return lastPopUpDateTime.Date < baseDateTime.Date;
        }

        public Uri GetIconUri()
        {
            var assemblyName = Assembly.GetExecutingAssembly().GetName();
            var imageSubDirectory = "";//appName.ToString();
            var packUri = $"pack://application:,,,/{assemblyName.Name};component/Resources/{imageSubDirectory}/VsixExtensionIcon_16x16.png";
            return new Uri(packUri);
        }
    }
}
