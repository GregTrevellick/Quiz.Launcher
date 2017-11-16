﻿using MoreLinq;
using Quiz.Ui.Core;
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

        //gregt long param list !!
        public HiddenOptionsDto GetHiddenOptionsDto(string popUpTitle, DateTime lastPopUpDateTime, int popUpCountToday, int timeOutInMilliSeconds, string optionsName, bool suppressClosingWithoutSubmitingAnswerWarning, 
            int totalQuestionsAnsweredCorrectlyEasy, int totalQuestionsAnsweredCorrectlyMedium, int totalQuestionsAnsweredCorrectlyHard, int totalQuestionsAsked, SearchEngine searchEngine)
        {
            var random = new Random();
            var remote = random.Next(1, 5);
            var gatewayResponse = new GatewayResponse();

            switch (remote)
            {
                case 1:
                case 2:
                    var questionsOpenTdb = new QuestionsOpenTdb();
                    gatewayResponse = questionsOpenTdb.GetGatewayResponse(timeOutInMilliSeconds, Constants.TimeOutInMilliSecondsOptionLabel, optionsName);
                    break;
                case 3:
                    var gatewayResponses = AllGateways.GatewayResponses;
                    gatewayResponse = gatewayResponses.RandomSubset(1).Single();
                    break;
                case 4:
                case 5:
                    var questionsOpenCocktail = new QuestionsCocktailHeroku();
                    gatewayResponse = questionsOpenCocktail.GetGatewayResponse(timeOutInMilliSeconds, Constants.TimeOutInMilliSecondsOptionLabel, optionsName);
                    break;
            }

            var quizDialogDto = GetQuizDialogDto(gatewayResponse);
            DisplayPopUpMessage(quizDialogDto, suppressClosingWithoutSubmitingAnswerWarning, 
                totalQuestionsAnsweredCorrectlyEasy, totalQuestionsAnsweredCorrectlyMedium, totalQuestionsAnsweredCorrectlyHard, totalQuestionsAsked, searchEngine);

            var hiddenOptionsDto = GetHiddenOptionsDto(lastPopUpDateTime, popUpCountToday);

            return hiddenOptionsDto;
        }

        private static QuizDialogDto GetQuizDialogDto(GatewayResponse gatewayResponse)
        {
            var quizDialogDto = new QuizDialogDto
            {
                MultipleChoiceAnswers = gatewayResponse.MultipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = gatewayResponse.MultipleChoiceCorrectAnswer,
                QuestionDifficulty = gatewayResponse.DifficultyLevel,
                QuestionType = gatewayResponse.QuestionType,
                QuizQuestion = gatewayResponse.Question,
                PopUpTitle = Vsix.Name,
            };

            return quizDialogDto;
        }

        void PersistHiddenOptions(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectlyEasy, int? totalQuestionsAnsweredCorrectlyMedium, int? totalQuestionsAnsweredCorrectlyHard)
        {
            PersistHiddenOptionsQuizHelperEventHandlerEventHandler?.Invoke(totalQuestionsAsked, totalQuestionsAnsweredCorrectlyEasy, totalQuestionsAnsweredCorrectlyMedium, totalQuestionsAnsweredCorrectlyHard);
        }

        private void DisplayPopUpMessage(QuizDialogDto quizDialogDto, bool? suppressClosingWithoutSubmitingAnswerWarning,
            int? totalQuestionsAnsweredCorrectlyEasy, int? totalQuestionsAnsweredCorrectlyMedium, int? totalQuestionsAnsweredCorrectlyHard, int? totalQuestionsAsked, SearchEngine searchEngine)
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
            vsixQuizDialog.QuestionText = quizDialogDto?.QuizQuestion.Trim();

            if (!string.IsNullOrWhiteSpace(vsixQuizDialog.TextBlockErrorDetails.Text))
            {
                vsixQuizDialog.TextBlockErrorDetails.Visibility = Visibility.Visible;
            }

            quizDialogDto.MultipleChoiceAnswers =
                quizDialogDto.MultipleChoiceAnswers.Where(x => !string.IsNullOrWhiteSpace(x));

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

            SetRadioButtonVisibility(vsixQuizDialog.RadioButton1);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton2);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton3);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton4);
            SetRadioButtonVisibility(vsixQuizDialog.RadioButton5);

            if (totalQuestionsAnsweredCorrectlyMedium.HasValue && totalQuestionsAsked.HasValue)
            {
                vsixQuizDialog.TextBlockTotalQuestionsAnsweredCorrectly.Text = totalQuestionsAnsweredCorrectlyMedium.ToString();
                vsixQuizDialog.TextBlockTotalQuestionsAsked.Text = totalQuestionsAsked.ToString();
                var percentageSuccess = GetPercentageSuccess(totalQuestionsAnsweredCorrectlyMedium, totalQuestionsAsked);
                var userStatus = vsixQuizDialog.GetUserStatus(percentageSuccess);
                vsixQuizDialog.TextBlockUserStatus.Text = userStatus;
                var userRank = vsixQuizDialog.GetUserRank(percentageSuccess);
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

            //gregt to be reinstated SetWindowIcon(window);

            window.ResizeMode = ResizeMode.CanResize;
            window.ShowDialog();
        }

        private void SetWindowIcon(Window window)
        {
            var iconUri = GetIconUri();
            window.Icon = new BitmapImage(iconUri);
        }

        private Uri GetIconUri()
        {
            var assemblyName = "Quiz.Ui";
            var packUri = $"pack://application:,,,/{assemblyName};component/Resources/vsixextensionicon_90x90_resource_bb6_icon.png";
            return new Uri(packUri, UriKind.RelativeOrAbsolute);
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

        public static int GetPercentageSuccess(int? totalQuestionsAnsweredCorrectly, int? totalQuestionsAsked)
        {
            int percentageSuccess;

            if (totalQuestionsAnsweredCorrectly.HasValue && totalQuestionsAsked.HasValue)
            {
                var percentage = ((double)totalQuestionsAnsweredCorrectly.Value / totalQuestionsAsked.Value) * 100;
                percentageSuccess = (int)Math.Round(percentage, MidpointRounding.AwayFromZero);
                if (percentageSuccess < 0)
                {
                    percentageSuccess = 0;
                }
            }
            else
            {
                percentageSuccess = 0;
            }

            return percentageSuccess;
        }
    }
}
