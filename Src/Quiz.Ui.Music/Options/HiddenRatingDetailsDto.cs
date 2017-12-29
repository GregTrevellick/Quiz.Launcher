using System;
using Microsoft.VisualStudio.Shell;
using VsixRatingChaser.Interfaces;

namespace Quiz.Ui.Music.Options
{
    public class HiddenRatingDetailsDto : DialogPage, IRatingDetailsDto
    {
        public DateTime LastRatingRequest { get; set; }
        public int RatingRequestCount { get; set; }      
    }
}