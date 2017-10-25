using System;

namespace Quiz.Ui.Core
{
    public class HiddenOptionsDto
    {
        public DateTime LastPopUpDateTime { get; set; }
        public int PopUpCountToday { get; set; }
        public int TotalQuestionsAnsweredCorrectly { get; set; }
        public int TotalQuestionsAsked { get; set; }
    }
}