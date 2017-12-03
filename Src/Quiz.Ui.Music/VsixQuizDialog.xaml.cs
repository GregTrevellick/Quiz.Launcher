//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace Quiz.Ui.Music
//{
//    /// <summary>
//    /// Interaction logic for VsixQuizDialog.xaml
//    /// </summary>
//    public partial class VsixQuizDialog : UserControl
//    {
//        public VsixQuizDialog()
//        {
//            InitializeComponent();
//        }
//    }
//}



using System;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;
using Quiz.Core;
using Quiz.Questions;
using Quiz.Questions.Entities;

namespace Quiz.Ui.Music
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

        public delegate void MyEventHandler(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectlyEasy, int? totalQuestionsAnsweredCorrectlyMedium, int? totalQuestionsAnsweredCorrectlyHard);
        public event MyEventHandler PersistHiddenOptionsEventHandler;

        private string errorDetails;
        private readonly string _optionsName;
        private bool _userStatusTotalsIncremented;

        public VsixQuizDialog()
        {
            _optionsName = Vsix.Name;
            _userStatusTotalsIncremented = false;

            InitializeComponent();
            //////DataContext = this;
            Loaded += UserControl1_Loaded;

            SetHelpHyperLink();
            SetSupplyAQuestionHyperLink();
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
                e.Cancel = true;
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

        private void ButtonSubmitMultiChoiceAnwser_OnClick(object sender, RoutedEventArgs e)
        {
            string response;
            int chosenAnswerNumber = 0;

            if (RadioButton1.IsChecked == true)
            {
                response = RadioButton1.Content.ToString();
                chosenAnswerNumber = 1;
            }
            else
            {
                if (RadioButton2.IsChecked == true)
                {
                    response = RadioButton2.Content.ToString();
                    chosenAnswerNumber = 2;
                }
                else
                {
                    if (RadioButton3.IsChecked == true)
                    {
                        response = RadioButton3.Content.ToString();
                        chosenAnswerNumber = 3;
                    }
                    else
                    {
                        if (RadioButton4.IsChecked == true)
                        {
                            response = RadioButton4.Content.ToString();
                            chosenAnswerNumber = 4;
                        }
                        else
                        {
                            if (RadioButton5.IsChecked == true)
                            {
                                response = RadioButton5.Content.ToString();
                                chosenAnswerNumber = 5;
                            }
                            else
                            {
                                response = null;
                            }
                        }
                    }
                }
            }

            var difficultyLevel = new QuizQuestionApi().GetDifficultyLevel(TextBlockDifficulty.Text);

            ActOnAnswerGiven(response, chosenAnswerNumber, difficultyLevel);
        }

        private void ActOnAnswerGiven(string response, int chosenAnswerNumber, DifficultyLevel difficultyLevel)
        {
            ProcessAnswerToQuestion(response, chosenAnswerNumber, difficultyLevel);

            SetBingleHyperLink(SearchEngine);

            RefreshAndPersistStatistics();
        }

        private void ProcessAnswerToQuestion(string response, int chosenAnswerNumber, DifficultyLevel difficultyLevel)
        {
            HideControls();

            var isResponseCorrect = IsResponseCorrect(response);

            if (isResponseCorrect)
            {
                ShowGreenTick(chosenAnswerNumber);

                TextBlockQuizReply.Text = "Correct!";
                SetQuizReplyColour(Colors.Green);

                if (!_userStatusTotalsIncremented)
                {
                    IncrementTotal(difficultyLevel);
                }
            }
            else
            {
                ShowRedCross(chosenAnswerNumber);

                if (QuestionType == QuestionType.MultiChoice)
                {
                    TextBlockQuizReply.Text = $"The correct answer is {CorrectAnswer}";
                }

                SetQuizReplyColour(Colors.Red);
            }

            TextBlockQuizReply.Visibility = Visibility.Visible;

            if (string.IsNullOrEmpty(errorDetails))
            {
                TextBlockErrorDetails.Text = string.Empty;
                TextBlockErrorDetails.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextBlockErrorDetails.Text = errorDetails;
                TextBlockErrorDetails.Visibility = Visibility.Visible;
            }
        }

        private void IncrementTotal(DifficultyLevel difficultyLevel)
        {
            switch (difficultyLevel)
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
                    errorDetails = new QuizQuestionApi().HandleArgumentOutOfRangeException(nameof(difficultyLevel), (int)difficultyLevel);
                    break;
            }
        }

        private void ShowRedCross(int chosenAnswerNumber)
        {
            switch (chosenAnswerNumber)
            {
                case 1:
                    QuizReplyEmoticonIncorrect1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    QuizReplyEmoticonIncorrect2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    QuizReplyEmoticonIncorrect3.Visibility = Visibility.Visible;
                    break;
                case 4:
                    QuizReplyEmoticonIncorrect4.Visibility = Visibility.Visible;
                    break;
                case 5:
                    QuizReplyEmoticonIncorrect5.Visibility = Visibility.Visible;
                    break;
                default:
                    errorDetails = new QuizQuestionApi().HandleArgumentOutOfRangeException(nameof(chosenAnswerNumber), chosenAnswerNumber);
                    break;
            }
        }

        private void ShowGreenTick(int chosenAnswerNumber)
        {
            switch (chosenAnswerNumber)
            {
                case 1:
                    QuizReplyEmoticonCorrect1.Visibility = Visibility.Visible;
                    break;
                case 2:
                    QuizReplyEmoticonCorrect2.Visibility = Visibility.Visible;
                    break;
                case 3:
                    QuizReplyEmoticonCorrect3.Visibility = Visibility.Visible;
                    break;
                case 4:
                    QuizReplyEmoticonCorrect4.Visibility = Visibility.Visible;
                    break;
                case 5:
                    QuizReplyEmoticonCorrect5.Visibility = Visibility.Visible;
                    break;
                default:
                    errorDetails = new QuizQuestionApi().HandleArgumentOutOfRangeException(nameof(chosenAnswerNumber), chosenAnswerNumber);
                    break;
            }
        }

        private void HideControls()
        {
            QuizReplyEmoticonCorrect1.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonCorrect2.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonCorrect3.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonCorrect4.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonCorrect5.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonIncorrect1.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonIncorrect2.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonIncorrect3.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonIncorrect4.Visibility = Visibility.Collapsed;
            QuizReplyEmoticonIncorrect5.Visibility = Visibility.Collapsed;
            ButtonSubmitMultiChoiceAnwser.IsEnabled = false;
            RadioButton1.IsEnabled = false;
            RadioButton2.IsEnabled = false;
            RadioButton3.IsEnabled = false;
            RadioButton4.IsEnabled = false;
            RadioButton5.IsEnabled = false;
        }

        private void RefreshAndPersistStatistics()
        {
            if (!_userStatusTotalsIncremented && TotalQuestionsAsked.HasValue)
            {
                TotalQuestionsAsked++;
                _userStatusTotalsIncremented = true;
            }

            var totalQuestionsAnsweredCorrectly = TotalQuestionsAnsweredCorrectlyEasy + TotalQuestionsAnsweredCorrectlyMedium + TotalQuestionsAnsweredCorrectlyHard;

            var percentageSuccess = QuizHelperCore.GetPercentageSuccess(totalQuestionsAnsweredCorrectly, TotalQuestionsAsked);

            TextBlockTotalQuestionsAsked.Text = TotalQuestionsAsked.ToString();
            TextBlockTotalQuestionsAnsweredCorrectly.Text = totalQuestionsAnsweredCorrectly.ToString();
            TextBlockUserStatus.Text = QuizHelperCore.GetUserStatus(percentageSuccess);
            TextBlockUserRank.Text = QuizHelperCore.GetUserRank(percentageSuccess);

            PersistHiddenOptionsEventHandler?.Invoke(TotalQuestionsAsked, TotalQuestionsAnsweredCorrectlyEasy, TotalQuestionsAnsweredCorrectlyMedium, TotalQuestionsAnsweredCorrectlyHard);
        }

        private void SetBingleHyperLink(SearchEngine searchEngine)
        {
            var searchTerm = WebUtility.UrlEncode(QuestionText);

            var uri = $"https://www.{searchEngine}.com/search?q={searchTerm}";

            HyperLinkBingle.NavigateUri = new Uri(uri);
            HyperLinkBingle.Inlines.Clear();
            HyperLinkBingle.Inlines.Add("Bingle it!");

            TextBlockBingle.Visibility = Visibility.Visible;
        }

        private void SetHelpHyperLink()
        {
            var uri = "https://github.com/GregTrevellick/OpenInApp.Launcher/blob/master/CHANGELOG.md";
            HyperLinkHelp.NavigateUri = new Uri(uri);
            HyperLinkHelp.Inlines.Clear();
            HyperLinkHelp.Inlines.Add("Help");
        }

        private void SetSupplyAQuestionHyperLink()
        {
            var uri = "https://github.com/GregTrevellick/SolutionOpenPopUp/blob/master/CHANGELOG.md";
            HyperLinkSupplyAQuestion.NavigateUri = new Uri(uri);
            HyperLinkSupplyAQuestion.Inlines.Clear();
            HyperLinkSupplyAQuestion.Inlines.Add("Submit a question");
        }

        private void HyperLinkBingle_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            LaunchUri(e);
        }

        private void HyperLinkHelp_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            LaunchUri(e);
        }

        private void HyperLinkSupplyAQuestion_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            LaunchUri(e);
        }

        private void LaunchUri(RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
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
