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
        public string CorrectAnswer;
        private readonly string _optionsName;
        public QuestionType QuestionType;
        public bool SuppressClosingWithoutSubmitingAnswerWarning;
        public int? TotalQuestionsAnsweredCorrectly;
        public int? TotalQuestionsAsked;
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

            if (QuestionType != QuestionType.None)
            {
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
            }

            return shouldCloseWindow;
        }

        private void ButtonHelp_OnClick(object sender, RoutedEventArgs e)
        {
            if (TextBlockHelp2.Visibility == Visibility.Visible)
            {
                TextBlockHelp2.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextBlockHelp2.Text = Constants.HelpText(_optionsName);//$"To alter the frequency and volume of quiz questions go to Tools | Options | {}";
                TextBlockHelp2.Visibility = Visibility.Visible;
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

                if (!_userStatusTotalsIncremented && TotalQuestionsAnsweredCorrectly.HasValue)
                {
                    TotalQuestionsAnsweredCorrectly++;
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

                    if (QuestionType == QuestionType.MultiChoice)
                    {
                        TextBlockQuizReply.Text += $" The correct answer is {CorrectAnswer}";
                    }

                    ButtonSubmitMultiChoiceAnwser.IsEnabled = false;
                    SetQuizReplyColour(Colors.Red);
                    QuizReplyEmoticonIncorrect.Visibility = Visibility.Visible;
                }
            }

            TextBlockQuizReply.Visibility = Visibility.Visible;

            if (!_userStatusTotalsIncremented && TotalQuestionsAsked.HasValue)
            {
                TotalQuestionsAsked++;
                _userStatusTotalsIncremented = true;
            }
            var userStatus = GetUserStatus(TotalQuestionsAnsweredCorrectly, TotalQuestionsAsked);
            TextBlockUserStatus.Text = userStatus;

            PersistHiddenOptionsEventHandler?.Invoke(TotalQuestionsAsked, TotalQuestionsAnsweredCorrectly);
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
            var rightAnswer = response == CorrectAnswer;
            return rightAnswer;
        }
    }
}
