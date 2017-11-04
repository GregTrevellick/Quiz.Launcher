﻿using Quiz.Ui.Core;
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
        public int? TotalQuestionsAnsweredCorrectly;
        public int? TotalQuestionsAsked;

        public delegate void MyEventHandler(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectly);
        public event MyEventHandler PersistHiddenOptionsEventHandler;

        private readonly string _optionsName;
        private bool _userStatusTotalsIncremented;

        public VsixQuizDialog()
        {
            _optionsName = Vsix.Name;
            _userStatusTotalsIncremented = false;

            InitializeComponent();
            DataContext = this;//gregt is this relevant ? should it be leveraged ?
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
                            response = null;
                        }
                    }
                }
            }

            ActOnAnswerGiven(response);
        }

        private void ActOnAnswerGiven(string response)
        {
            #region Extract to new method "ProcessAnswerToQuestion"
            QuizReplyEmoticonCorrect.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonIncorrect.Visibility = Visibility.Collapsed;

            var isResponseCorrect = IsResponseCorrect(response);

            if (isResponseCorrect)
            {
                TextBlockQuizReply.Text = "Well done - correct answer.";
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
            #endregion

            SetBingleHyperLink();

            #region extract to new method "RefreshAndPersistStatistics"
            if (!_userStatusTotalsIncremented && TotalQuestionsAsked.HasValue)
            {
                TotalQuestionsAsked++;
                _userStatusTotalsIncremented = true;
            }

            var percentageSuccess = GetPercentageSuccess(TotalQuestionsAnsweredCorrectly, TotalQuestionsAsked);

            TextBlockTotalQuestionsAsked.Text = TotalQuestionsAsked.ToString();
            TextBlockTotalQuestionsAnsweredCorrectly.Text= TotalQuestionsAnsweredCorrectly.ToString();
            TextBlockUserStatus.Text = GetUserStatus(percentageSuccess);
            TextBlockUserRank.Text = GetUserRank(percentageSuccess);

            PersistHiddenOptionsEventHandler?.Invoke(TotalQuestionsAsked, TotalQuestionsAnsweredCorrectly);
            #endregion
        }

        private void SetBingleHyperLink()
        {
            var useBing = false; //gregt get from options
            var engine = useBing ? "bing" : "google";
            var searchTerm = WebUtility.UrlEncode(QuestionText);
            var uri = $"https://www.{engine}.com/search?q={searchTerm}";

            HyperLinkBingle.NavigateUri = new Uri(uri);
            HyperLinkBingle.Inlines.Clear();
            HyperLinkBingle.Inlines.Add("bingle");

            TextBlockBingle.Visibility = Visibility.Visible;
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

        private void EnableSubmitButton()
        {
            ButtonSubmitMultiChoiceAnwser.IsEnabled = true;
        }

        private void HyperLinkBingle_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
