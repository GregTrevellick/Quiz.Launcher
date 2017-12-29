using VsixRatingChaser.Interfaces;

namespace Quiz.Rating
{
    public class RatingInstructionsDto : IRatingInstructions
    {
        public string VsixAuthor { get; set; }
        public string VsixName { get; set; }
    }
}