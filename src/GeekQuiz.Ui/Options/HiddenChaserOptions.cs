using System;
using Microsoft.VisualStudio.Shell;

//using VsixRatingChaser;

namespace GeekQuiz.Ui.Options
{
    public class HiddenChaserOptions : DialogPage//, IHiddenChaserOptions
    {
        public DateTime LastRatingRequest { get; set; }
        public int PackageLoadedCount { get; set; }
        public int RatingRequestCount { get; set; }      
    }
}