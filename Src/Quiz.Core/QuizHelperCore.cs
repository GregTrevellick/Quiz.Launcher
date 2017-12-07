using Quiz.Questions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz.Core
{
    public class QuizHelperCore
    {
        public static QuizDialogDto GetQuizDialogDto(QuizQuestion quizQuestion, string vsixName)
        {
            var quizDialogDto = new QuizDialogDto
            {
                MultipleChoiceAnswers = quizQuestion.MultipleChoiceAnswers,
                MultipleChoiceCorrectAnswer = quizQuestion.MultipleChoiceCorrectAnswer,
                QuestionDifficulty = quizQuestion.DifficultyLevel,
                QuestionType = quizQuestion.QuestionType,
                QuizQuestion = quizQuestion.Question,
                PopUpTitle = vsixName,
            };

            return quizDialogDto;
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

        public static string GetUserStatus(int percentageSuccess)
        {
            var successRate = $"{percentageSuccess}%";
            return successRate;
        }

        public static string GetUserRank(int percentageSuccess)
        {
            var userStatusDescription = percentageSuccess.UserStatusDescription();
            return userStatusDescription;
        }

        public static int GetPopUpCountToday(DateTime lastPopUpDateTime, int popUpCountToday, DateTime baseDateTime)//gregtlo unit test reqd
        {
            int result;

            if (IsANewDay(lastPopUpDateTime, baseDateTime))
            {
                result = 1;
            }
            else
            {
                result = popUpCountToday + 1;
            }

            return result;
        }

        private static bool IsANewDay(DateTime lastPopUpDateTime, DateTime baseDateTime)
        {
            //If last pop up was yesterday, then we have gone past midnight, so this is first pop up for today
            return lastPopUpDateTime.Date < baseDateTime.Date;
        }

        public static string[] GetRandomlySortedAnswers(IEnumerable<string> multipleChoiceAnswers)
        {
            var random = new Random();
            var randomlySortedAnswers = multipleChoiceAnswers.OrderBy(x => random.Next()).Select(x => x).ToArray(); 
            return randomlySortedAnswers;
        }

        public static string[] GetTrueFollowedByFalseAnswers(IEnumerable<string> multipleChoiceAnswers)
        {
            var trueFollowedByFalseAnswers = multipleChoiceAnswers.OrderByDescending(x => x).Select(x => x).ToArray(); 
            return trueFollowedByFalseAnswers;
        }

        public static IEnumerable<string> GetPopulatedAnswers(IEnumerable<string> multipleChoiceAnswers)
        {
            var result = multipleChoiceAnswers.Where(x => !string.IsNullOrWhiteSpace(x));
            return result;
        }
    }
}