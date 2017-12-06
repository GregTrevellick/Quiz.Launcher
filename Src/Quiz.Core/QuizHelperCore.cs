using System;
using System.Linq;
using Quiz.Questions.Entities;

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

        private static bool IsANewDay(DateTime lastPopUpDateTime, DateTime baseDateTime)
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

        public static int GetPopUpCountToday(DateTime lastPopUpDateTime, int popUpCountToday, DateTime baseDateTime)//gregt unit test reqd
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

        public static string[] GetRandomlySortedAnswers(QuizDialogDto quizDialogDto)//gregt unit test reqd
        {
            var random = new Random();
            var randomlySortedAnswers = quizDialogDto.MultipleChoiceAnswers.OrderBy(x => random.Next()).Select(x => x).ToArray(); 
            return randomlySortedAnswers;
        }

        public static string[] GetTrueFollowedByFalseAnswers(QuizDialogDto quizDialogDto)//gregt unit test reqd
        {
            var trueFollowedByFalseAnswers = quizDialogDto.MultipleChoiceAnswers.OrderByDescending(x => x).Select(x => x).ToArray(); 
            return trueFollowedByFalseAnswers;
        }
    }
}
