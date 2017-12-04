using System;
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

        //public static HiddenOptionsDto GetHiddenOptionsDto(DateTime lastPopUpDateTime, int popUpCountToday)
        //{
        //    var hiddenOptionsDto = new HiddenOptionsDto();

        //    var baseDateTime = DateTime.Now;

        //    if (IsANewDay(lastPopUpDateTime, baseDateTime))
        //    {
        //        hiddenOptionsDto.PopUpCountToday = 1;
        //    }
        //    else
        //    {
        //        hiddenOptionsDto.PopUpCountToday = popUpCountToday + 1;
        //    }

        //    hiddenOptionsDto.LastPopUpDateTime = baseDateTime;

        //    return hiddenOptionsDto;
        //}

        public static bool IsANewDay(DateTime lastPopUpDateTime, DateTime baseDateTime)
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
    }
}
