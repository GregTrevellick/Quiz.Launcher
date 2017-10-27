using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Quiz.Ui.Core;
using Quiz.Ui.Gateway;

namespace Quiz.Ui
{
    public partial class VsixQuizDialog : UserControl
    {
        public string _correctAnswer;
        private string _optionsName;
        public QuestionType _questionType;
        public bool _suppressClosingWithoutSubmitingAnswerWarning;
        public int? _totalQuestionsAnsweredCorrectly;
        public int? _totalQuestionsAsked;
        private bool _userStatusTotalsIncremented;
        public delegate void MyEventHandler(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectly);
        public event MyEventHandler PersistHiddenOptionsEventHandler;

        public VsixQuizDialog()
        {
        }

        public VsixQuizDialog(string optionsName)
        {
            _optionsName = optionsName;
            _userStatusTotalsIncremented = false;

            InitializeComponent();
            DataContext = this;
            StackPanelQuiz.Visibility = Visibility.Visible;
            this.Loaded += UserControl1_Loaded;
        }

        void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Closing += window_Closing;
        }

        void window_Closing(object sender, global::System.ComponentModel.CancelEventArgs e)
        {
            //do something before the window is closed...
            e.Cancel = true;
            ButtonClose_OnClick(sender, null);
        }

        private void ButtonHelp_OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBlockHelp2.Visibility == Visibility.Visible)
            {
                TextBlockHelp2.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextBlockHelp2.Text = $"To alter frequency and volume of delivery go to Tools | Options | {_optionsName}";
                TextBlockHelp2.Visibility = Visibility.Visible;
            }
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            var shouldClose = true;

            if (_questionType != QuestionType.None)
            {
                if (ButtonSubmitMultiChoiceAnwser.IsEnabled)
                {
                    if (!_suppressClosingWithoutSubmitingAnswerWarning)
                    {
                        var closeWithoutSubmitingAnswer = MessageBoxes.ConfirmCloseWithoutSubmitingAnswer(_optionsName);

                        if (!closeWithoutSubmitingAnswer)
                        {
                            shouldClose = false;
                        }
                    }
                }
            }

            if (shouldClose)
            {
                //Close();
                //((Window) sender).Close();
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
                            response = null;
                        }
                    }
                }
            }

            ActOnAnswerGiven(response);
        }

        private void ActOnAnswerGiven(string response)
        {
            QuizReplyEmoticonCorrect.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonIncorrect.Visibility = Visibility.Collapsed;

            var isResponseCorrect = IsResponseCorrect(response);

            if (isResponseCorrect)
            {
                TextBlockQuizReply.Text = "Well,done - correct answer !";
                SetQuizReplyColour(Colors.Green);
                ButtonSubmitMultiChoiceAnwser.IsEnabled = false;
                QuizReplyEmoticonCorrect.Visibility = Visibility.Visible;

                if (!_userStatusTotalsIncremented && _totalQuestionsAnsweredCorrectly.HasValue)
                {
                    _totalQuestionsAnsweredCorrectly++;
                }
            }
            else
            {
                if (response == null)
                {
                    TextBlockQuizReply.Text = "No cheating please - you must supply an answer.";
                    SetQuizReplyColour(Colors.Orange);
                }
                else
                {
                    TextBlockQuizReply.Text = "Oh dear - wrong answer.";

                    if (_questionType == QuestionType.MultiChoice)
                    {
                        TextBlockQuizReply.Text += $" The correct answer is {_correctAnswer}";
                    }

                    ButtonSubmitMultiChoiceAnwser.IsEnabled = false;
                    SetQuizReplyColour(Colors.Red);
                    QuizReplyEmoticonIncorrect.Visibility = Visibility.Visible;
                }
            }

            TextBlockQuizReply.Visibility = Visibility.Visible;

            if (!_userStatusTotalsIncremented && _totalQuestionsAsked.HasValue)
            {
                _totalQuestionsAsked++;
                _userStatusTotalsIncremented = true;
            }
            var userStatus = GetUserStatus(_totalQuestionsAnsweredCorrectly, _totalQuestionsAsked);
            TextBlockUserStatus.Text = userStatus;

            PersistHiddenOptionsEventHandler?.Invoke(_totalQuestionsAsked, _totalQuestionsAnsweredCorrectly);
        }

        internal string GetUserStatus(int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked)
        {
            int percentageSuccess;

            if (totalQuestionsAsked == 0 ||
                !totalQuestionsAnsweredCorrectly.HasValue ||
                !totalQuestionsAsked.HasValue)
            {
                percentageSuccess = 0;
            }
            else
            {
                //gregt unit test required
                double percentage = ((double)totalQuestionsAnsweredCorrectly.Value / totalQuestionsAsked.Value) * 100;
                percentageSuccess = (int)Math.Round(percentage, MidpointRounding.AwayFromZero);
            }

            var userStatusDescription = percentageSuccess.UserStatusDescription();

            var ranking = "Your rank: " + userStatusDescription;

            var successRate = percentageSuccess + "% success rate (" +
                              totalQuestionsAnsweredCorrectly + " out of " +
                              totalQuestionsAsked + ")";

            var userStatus = ranking + " " + successRate;

            return userStatus;
        }

        private void SetQuizReplyColour(Color color)
        {
            TextBlockQuizReply.Foreground = new SolidColorBrush(color);
        }

        private bool IsResponseCorrect(string response)
        {
            var rightAnswer = response == _correctAnswer;
            return rightAnswer;
        }
    }
}
