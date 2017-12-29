using VsixRatingChaser;
using VsixRatingChaser.Interfaces;

namespace Quiz.Rating
{
    public class ChaserGateway
    {
        public static IChaseVerdict Probe(IHiddenChaserOptions hiddenChaserOptions, IRatingInstructions ratingInstructions)
        {
            var chaser = new Chaser();
            var chaseVerdict = chaser.Chase(hiddenChaserOptions, ratingInstructions);
            return chaseVerdict;
        }
    }
}