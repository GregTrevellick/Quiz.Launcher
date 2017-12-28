using System;

namespace Quiz.Core
{
    public class DecisionMaker : IDecisionMaker
    {
        public bool ShouldShowQuiz(int popUpCountToday, int maximumPopUpsWeekEnd, int maximumPopUpsWeekDay, DateTime lastPopUpDateTime, int popUpIntervalInMins)
        {
            var dateTimeNow = DateTime.Now;

            if (!HaveExceededTodaysPopUpCount(popUpCountToday, maximumPopUpsWeekEnd, maximumPopUpsWeekDay, dateTimeNow))
            {
                if (LastPopUpMoreThanXMinutesAgo(lastPopUpDateTime, popUpIntervalInMins, dateTimeNow))
                {
                    return true;
                }
            }

            return false;
        }

        private bool HaveExceededTodaysPopUpCount(int popUpCountToday, int maximumPopUpsWeekEnd, int maximumPopUpsWeekDay, DateTime dateTimeNow)
        {
            var isWeekend = IsWeekend(dateTimeNow);
            bool haveExceededPopUpCountToday;

            if (isWeekend)
            {
                haveExceededPopUpCountToday = HaveExceededTodaysPopUpCount(popUpCountToday, maximumPopUpsWeekEnd);
            }
            else
            {
                haveExceededPopUpCountToday = HaveExceededTodaysPopUpCount(popUpCountToday, maximumPopUpsWeekDay);
            }

            return haveExceededPopUpCountToday;
        }

        private bool IsWeekend(DateTime dateTimeNow)
        {
            return dateTimeNow.DayOfWeek == DayOfWeek.Saturday ||
                   dateTimeNow.DayOfWeek == DayOfWeek.Sunday;
        }

        internal bool HaveExceededTodaysPopUpCount(int popUpCountToday, int maximumPopUps)
        {
            return popUpCountToday >= maximumPopUps;
        }

        internal bool LastPopUpMoreThanXMinutesAgo(DateTime lastPopUpDateTime, int popUpIntervalInMins, DateTime dateTimeNow)
        {
            var acceptableLastPopUpDateTime = dateTimeNow.AddMinutes(-1 * popUpIntervalInMins);
            var result = lastPopUpDateTime <= acceptableLastPopUpDateTime;
            return result;
        }
    }
}
