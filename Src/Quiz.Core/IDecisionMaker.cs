using System;

namespace Quiz.Core
{
    public interface IDecisionMaker
    {
        bool ShouldShowQuiz(int popUpCountToday, int maximumPopUpsWeekEnd, int maximumPopUpsWeekDay, DateTime lastPopUpDateTime, int popUpIntervalInMins);
    }
}