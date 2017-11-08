using Quiz.Ui.Core;
using Quiz.Ui.Gateway;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Quiz.Ui
{
    public partial class VsixQuizDialog : UserControl
    {
        public string CorrectAnswer;
        public string QuestionText;
        public QuestionType QuestionType;
        public bool SuppressClosingWithoutSubmitingAnswerWarning;
        public int? TotalQuestionsAnsweredCorrectlyEasy;
        public int? TotalQuestionsAnsweredCorrectlyMedium;
        public int? TotalQuestionsAnsweredCorrectlyHard;
        public int? TotalQuestionsAsked;
        public SearchEngine SearchEngine;

        public delegate void MyEventHandler(int? totalQuestionsAsked,
            int? totalQuestionsAnsweredCorrectlyEasy,
            int? totalQuestionsAnsweredCorrectlyMedium,
            int? totalQuestionsAnsweredCorrectlyHard);
        public event MyEventHandler PersistHiddenOptionsEventHandler;

        private readonly string _optionsName;
        private bool _userStatusTotalsIncremented;

        public VsixQuizDialog()
        {
            _optionsName = Vsix.Name;
            _userStatusTotalsIncremented = false;

            InitializeComponent();
            //////DataContext = this;
            Loaded += UserControl1_Loaded;

#if DEBUG
            ButtonAgain.Visibility = Visibility.Visible;
#endif
        }

#if DEBUG
        private void ButtonAgain_OnClick(object sender, RoutedEventArgs e)
        {
            var quizHelper = new QuizHelper();
            var random = new Random();
            var totalQuestionsAnsweredCorrectlyEasy = random.Next(1, 100);
            var totalQuestionsAnsweredCorrectlyMedium = random.Next(1, 100);
            var totalQuestionsAnsweredCorrectlyHard = random.Next(1, 100);
            quizHelper.GetHiddenOptionsDto("Again1", DateTime.Now, 789, 5000, "Again2", true,
                totalQuestionsAnsweredCorrectlyEasy,
                totalQuestionsAnsweredCorrectlyMedium,
                totalQuestionsAnsweredCorrectlyHard,
                100, SearchEngine.Google);
        }
#endif

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow((DependencyObject)sender);

            if (parentWindow != null)
            {
                parentWindow.Close();
            }
        }

        void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Closing += window_Closing;
        }
        
        void window_Closing(object sender, global::System.ComponentModel.CancelEventArgs e)
        {
            //Intercept the closing of window (top right hand corner 'X' or bespoke close button ) and cancel the close if appropriate (i.e. when no answer yet supplied, so user probably closing prematurely by mistake)
            var shouldCloseWindow = ShouldCloseWindow();

            if (!shouldCloseWindow)
            { 
                e.Cancel = false;
            }
        }
        
        private bool ShouldCloseWindow()
        {
            var shouldCloseWindow = true;

            if (ButtonSubmitMultiChoiceAnwser.IsEnabled)
            {
                if (!SuppressClosingWithoutSubmitingAnswerWarning)
                {
                    var closeWithoutSubmitingAnswer = MessageBoxes.ConfirmCloseWithoutSubmitingAnswer(_optionsName);

                    if (!closeWithoutSubmitingAnswer)
                    {
                        shouldCloseWindow = false;
                    }
                }
            }

            return shouldCloseWindow;
        }

        private void ButtonHelp_OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBlockHelp.Visibility == Visibility.Visible)
            {
                TextBlockHelp.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextBlockHelp.Text = Constants.HelpText(_optionsName);
                TextBlockHelp.Visibility = Visibility.Visible;
            }
        }

        private void ButtonSubmitMultiChoiceAnwser_OnClick(object sender, RoutedEventArgs e)
        {
            string response;

            if (RadioButton1.IsChecked == true)
            {
                response = RadioButton1.Content.ToString();
            }
            else
            {
                if (RadioButton2.IsChecked == true)
                {
                    response = RadioButton2.Content.ToString();
                }
                else
                {
                    if (RadioButton3.IsChecked == true)
                    {
                        response = RadioButton3.Content.ToString();
                    }
                    else
                    {
                        if (RadioButton4.IsChecked == true)
                        {
                            response = RadioButton4.Content.ToString();
                        }
                        else
                        {
                            if (RadioButton5.IsChecked == true)
                            {
                                response = RadioButton5.Content.ToString();
                            }
                            else
                            {
                                response = null;
                            }
                        }
                    }
                }
            }

            ActOnAnswerGiven(response);
        }

        private void ActOnAnswerGiven(string response)
        {
            ProcessAnswerToQuestion(response);

            SetBingleHyperLink(SearchEngine);

            RefreshAndPersistStatistics();
        }

        private void ProcessAnswerToQuestion(string response)
        {
            QuizReplyEmoticonCorrect.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonIncorrect.Visibility = Visibility.Collapsed;

            var isResponseCorrect = IsResponseCorrect(response);

            if (isResponseCorrect)
            {
                TextBlockQuizReply.Text = "Well done - correct answer.";
                SetQuizReplyColour(Colors.Green);
                ButtonSubmitMultiChoiceAnwser.IsEnabled = false;
                QuizReplyEmoticonCorrect.Visibility = Visibility.Visible;

                if (!_userStatusTotalsIncremented)
                {
                    var dl = DifficultyLevel.Medium;
                    switch (dl)
                    {
                        case DifficultyLevel.Easy:
                            if (TotalQuestionsAnsweredCorrectlyEasy.HasValue)
                            {
                                TotalQuestionsAnsweredCorrectlyEasy++;
                            }
                            break;
                        case DifficultyLevel.Medium:
                            if (TotalQuestionsAnsweredCorrectlyMedium.HasValue)
                            {
                                TotalQuestionsAnsweredCorrectlyMedium++;
                            }
                            break;
                        case DifficultyLevel.Hard:
                            if (TotalQuestionsAnsweredCorrectlyHard.HasValue)
                            {
                                TotalQuestionsAnsweredCorrectlyHard++;
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }                                                                
                }
            }
            else
            {
                TextBlockQuizReply.Text = "Oh dear - wrong answer.";

                if (QuestionType == QuestionType.MultiChoice)
                {
                    TextBlockQuizReply.Text += $" The correct answer is {CorrectAnswer}";
                }

                ButtonSubmitMultiChoiceAnwser.IsEnabled = false;
                SetQuizReplyColour(Colors.Red);
                QuizReplyEmoticonIncorrect.Visibility = Visibility.Visible;
            }

            TextBlockQuizReply.Visibility = Visibility.Visible;
        }

        private void RefreshAndPersistStatistics()
        {
            if (!_userStatusTotalsIncremented && TotalQuestionsAsked.HasValue)
            {
                TotalQuestionsAsked++;
                _userStatusTotalsIncremented = true;
            }

            var percentageSuccess = GetPercentageSuccess(
                TotalQuestionsAnsweredCorrectlyEasy +
                TotalQuestionsAnsweredCorrectlyMedium +
                TotalQuestionsAnsweredCorrectlyHard,
                TotalQuestionsAsked);

            TextBlockTotalQuestionsAsked.Text = TotalQuestionsAsked.ToString();
            var totalQuestionsAnsweredCorrectly =
                TotalQuestionsAnsweredCorrectlyEasy +
                TotalQuestionsAnsweredCorrectlyMedium +
                TotalQuestionsAnsweredCorrectlyHard;
            TextBlockTotalQuestionsAnsweredCorrectly.Text = totalQuestionsAnsweredCorrectly.ToString();
            TextBlockUserStatus.Text = GetUserStatus(percentageSuccess);
            TextBlockUserRank.Text = GetUserRank(percentageSuccess);

            PersistHiddenOptionsEventHandler?.Invoke(TotalQuestionsAsked, 
                TotalQuestionsAnsweredCorrectlyEasy,
                TotalQuestionsAnsweredCorrectlyMedium,
                TotalQuestionsAnsweredCorrectlyHard);
        }

        private void SetBingleHyperLink(SearchEngine searchEngine)
        {
            var searchTerm = WebUtility.UrlEncode(QuestionText);

            var uri = $"https://www.{searchEngine}.com/search?q={searchTerm}";

            HyperLinkBingle.NavigateUri = new Uri(uri);
            HyperLinkBingle.Inlines.Clear();
            HyperLinkBingle.Inlines.Add("bingle");

            TextBlockBingle.Visibility = Visibility.Visible;
        }

        private void HyperLinkBingle_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        internal string GetUserStatus(int percentageSuccess)
        {
            var successRate = $"{percentageSuccess}%";
            return successRate;
        }

        internal string GetUserRank(int percentageSuccess)
        {
            var userStatusDescription = percentageSuccess.UserStatusDescription();
            return userStatusDescription;
        }

        internal int GetPercentageSuccess(int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked)
        {
            int percentageSuccess;

            if (totalQuestionsAsked == 0 ||
                !totalQuestionsAnsweredCorrectly.HasValue ||
                !totalQuestionsAsked.HasValue)//gregt unit test reqd
            {
                percentageSuccess = 0;
            }
            else
            {
                //gregt unit test required
                double percentage = ((double) totalQuestionsAnsweredCorrectly.Value / totalQuestionsAsked.Value) * 100;
                percentageSuccess = (int) Math.Round(percentage, MidpointRounding.AwayFromZero);
            }

            return percentageSuccess;
        }

        private void SetQuizReplyColour(Color color)
        {
            TextBlockQuizReply.Foreground = new SolidColorBrush(color);
        }

        private bool IsResponseCorrect(string response)
        {
            var rightAnswer = response == CorrectAnswer;
            return rightAnswer;
        }

        private void RadioButton1_OnChecked(object sender, RoutedEventArgs e)
        {
            EnableSubmitButton();
        }

        private void RadioButton2_OnChecked(object sender, RoutedEventArgs e)
        {
            EnableSubmitButton();
        }

        private void RadioButton3_OnChecked(object sender, RoutedEventArgs e)
        {
            EnableSubmitButton();
        }

        private void RadioButton4_OnChecked(object sender, RoutedEventArgs e)
        {
            EnableSubmitButton();
        }

        private void RadioButton5_OnChecked(object sender, RoutedEventArgs e)
        {
            EnableSubmitButton();
        }

        private void EnableSubmitButton()
        {
            ButtonSubmitMultiChoiceAnwser.IsEnabled = true;
        }

    }
}
