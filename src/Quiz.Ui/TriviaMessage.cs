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
    public class TriviaMessage
    {
        public delegate void MyEventHandler2(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectly);
        public event MyEventHandler2 PersistHiddenOptionsEventHandler2;//gregt rename to remove '2' suffix

        public HiddenOptionsDto ShowTrivia(string popUpTitle, DateTime lastPopUpDateTime, int popUpCountToday, int timeOutInMilliSeconds, string optionsName, bool suppressClosingWithoutSubmitingAnswerWarning, int totalQuestionsAnsweredCorrectly, int totalQuestionsAsked)
        {
            //return ShowTriviaMessage(popUpTitle, lastPopUpDateTime, popUpCountToday, timeOutInMilliSeconds, optionsName, suppressClosingWithoutSubmitingAnswerWarning, totalQuestionsAnsweredCorrectly, totalQuestionsAsked);
        //}

        //private HiddenOptionsDto ShowTriviaMessage(string popUpTitle, DateTime lastPopUpDateTime, int popUpCountToday, int timeOutInMilliSeconds, string optionsName, bool? suppressClosingWithoutSubmitingAnswerWarning, int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked)
        //{
            HiddenOptionsDto hiddenOptionsDto = null;

            var clientGateway = new ClientGateway();
            var gatewayResponse = clientGateway.GetGatewayResponse(timeOutInMilliSeconds, CommonConstants.TimeOutInMilliSecondsOptionLabel, optionsName);

            var triviaDialogGeekQuizDto = GetTriviaDialogGeekQuizDto(gatewayResponse);
            DisplayPopUpMessageGeekQuiz(triviaDialogGeekQuizDto, suppressClosingWithoutSubmitingAnswerWarning, totalQuestionsAnsweredCorrectly, totalQuestionsAsked);

            hiddenOptionsDto = GetHiddenOptionsDto(lastPopUpDateTime, popUpCountToday);

            return hiddenOptionsDto;
        }

        private static TriviaDialogDto GetTriviaDialogGeekQuizDto(GatewayResponse gatewayResponseGeekQuiz)
        {
            var triviaDialogGeekQuizDto =
                new TriviaDialogDto
                {
                    QuestionDifficulty = gatewayResponseGeekQuiz.DifficultyLevel,
                    MultipleChoiceAnswers = gatewayResponseGeekQuiz.MultipleChoiceAnswers,
                    MultipleChoiceCorrectAnswer = gatewayResponseGeekQuiz.MultipleChoiceCorrectAnswer,
                    QuizQuestion = gatewayResponseGeekQuiz.Question,
                    QuestionType = gatewayResponseGeekQuiz.QuestionType,
                };
            return triviaDialogGeekQuizDto;
        }

        void PersistHiddenOptionsGeekQuiz(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectly)
        {
            PersistHiddenOptionsEventHandler2?.Invoke(totalQuestionsAsked, totalQuestionsAnsweredCorrectly);
        }

        private void DisplayPopUpMessageGeekQuiz(TriviaDialogDto triviaDialogDto, bool? suppressClosingWithoutSubmitingAnswerWarning, int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked)
        {
            var triviaDialog = new VsixQuizDialog(triviaDialogDto.OptionsName)
            {
                AppTextBlockErrorDetails = { Text = triviaDialogDto.ErrorDetails },
                /////////////////////////Title = triviaDialogDto.PopUpTitle,
                _suppressClosingWithoutSubmitingAnswerWarning =
                        suppressClosingWithoutSubmitingAnswerWarning.HasValue
                            ? suppressClosingWithoutSubmitingAnswerWarning.Value
                            : false,
                AppTextBlockQuestionGeekQuiz = { Text = triviaDialogDto.MultipleChoiceCorrectAnswer },
                _questionType = triviaDialogDto.QuestionType,
                _totalQuestionsAnsweredCorrectly = totalQuestionsAnsweredCorrectly,
                _totalQuestionsAsked = totalQuestionsAsked
            };

            triviaDialog.PersistHiddenOptionsEventHandler += PersistHiddenOptionsGeekQuiz;

            if (!string.IsNullOrWhiteSpace(triviaDialogDto.QuestionDifficulty))
            {
                var run = new Run(triviaDialogDto.QuestionDifficulty);
                triviaDialog.AppTextBlockQuestionGeekQuiz.Inlines.Add(run);
            }

            if (!string.IsNullOrWhiteSpace(triviaDialogDto.QuizQuestion))
            {
                var run = new Run(triviaDialogDto.QuizQuestion)
                {
                    FontWeight = FontWeights.Bold
                };
                triviaDialog.AppTextBlockQuestionGeekQuiz.Inlines.Add(run);
            }

            if (!string.IsNullOrWhiteSpace(triviaDialog.AppTextBlockErrorDetails.Text))
            {
                triviaDialog.AppTextBlockErrorDetails.Visibility = Visibility.Visible;
            }

            if (triviaDialogDto.QuestionType != QuestionType.None)
            {
                triviaDialog.AppBtnGeekQuizSubmitMultiChoiceAnwser.Visibility = Visibility.Visible;

                if (triviaDialogDto.QuestionType == QuestionType.TrueFalse)
                {
                    var trueFollowedByFalseAnswers = triviaDialogDto.MultipleChoiceAnswers.OrderByDescending(x => x).Select(x => x).ToArray();
                    triviaDialog.RadioBtn1.Content = trueFollowedByFalseAnswers[0];
                    triviaDialog.RadioBtn2.Content = trueFollowedByFalseAnswers[1];
                }
                else
                {
                    var random = new Random();
                    var randomlySortedAnswers = triviaDialogDto.MultipleChoiceAnswers.OrderBy(x => random.Next()).Select(x => x).ToArray();
                    triviaDialog.RadioBtn1.Content = randomlySortedAnswers[0];
                    triviaDialog.RadioBtn2.Content = randomlySortedAnswers[1];
                    triviaDialog.RadioBtn3.Content = randomlySortedAnswers[2];
                    triviaDialog.RadioBtn4.Content = randomlySortedAnswers[3];
                }
            }

            GeekQuizSetRadioButtonVisibility(triviaDialog.RadioBtn1);
            GeekQuizSetRadioButtonVisibility(triviaDialog.RadioBtn2);
            GeekQuizSetRadioButtonVisibility(triviaDialog.RadioBtn3);
            GeekQuizSetRadioButtonVisibility(triviaDialog.RadioBtn4);

            if (totalQuestionsAnsweredCorrectly.HasValue && totalQuestionsAsked.HasValue)
            {
                var userStatus = triviaDialog.GetUserStatusGeekQuiz(totalQuestionsAnsweredCorrectly, totalQuestionsAsked);
                triviaDialog.AppTextBlockGeekQuizUserStatus.Text = userStatus;
                triviaDialog.AppTextBlockGeekQuizUserStatus.Visibility = Visibility.Visible;
            }

            //triviaDialog.Show();
            var window = new Window
            {
                Title = "My User Control Dialog",
                Content = triviaDialog,
                SizeToContent = SizeToContent.WidthAndHeight,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
           // var iconUri = new TriviaMessage().GetIconUri();
           // window.Icon = new BitmapImage(iconUri);
            window.ShowDialog();
        }

        private void GeekQuizSetRadioButtonVisibility(RadioButton radioButton)
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
