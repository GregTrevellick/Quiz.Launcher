﻿using System;
using Microsoft.VisualStudio.Shell;

namespace Quiz.Ui.Options
{
    public class HiddenOptions : DialogPage
    {
        public DateTime LastPopUpDateTime { get; set; }
        public int PopUpCountToday { get; set; }
        public int TotalQuestionsAnsweredCorrectly { get; set; }
        public int TotalQuestionsAsked { get; set; }
    }
}