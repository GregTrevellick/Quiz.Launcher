using System;
using Microsoft.VisualStudio.Shell;

namespace Quiz.Ui.Music.Options
{
    public class HiddenOptions : DialogPage
    {
        public DateTime LastPopUpDateTime { get; set; }
        public int PopUpCountToday { get; set; }
        public int TotalQuestionsAnsweredCorrectlyEasy { get; set; }
        public int TotalQuestionsAnsweredCorrectlyMedium { get; set; }
        public int TotalQuestionsAnsweredCorrectlyHard { get; set; }
        public int TotalQuestionsAsked { get; set; }
    }
}