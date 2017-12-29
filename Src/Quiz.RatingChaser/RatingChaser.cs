using VsixRatingChaser;
using VsixRatingChaser.Interfaces;

namespace Quiz.RatingChaser
{
    public class RatingChaser
    {
        public static IChaseVerdict ChaseRatings(IHiddenChaserOptions hiddenChaserOptions, IRatingInstructions ratingInstructions)
        {
            var chaser = new Chaser();
            var chaseVerdict = chaser.Chase(hiddenChaserOptions, ratingInstructions);
            return chaseVerdict;
        }
    }
}