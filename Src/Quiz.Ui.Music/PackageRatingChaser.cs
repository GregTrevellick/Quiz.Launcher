using Quiz.Rating;
using VsixRatingChaser.Interfaces;
using static Quiz.Rating.ChaserGateway;

namespace Quiz.Ui.Music
{
    public class PackageRatingChaser
    {
        public void Hunt(IHiddenChaserOptions hiddenChaserOptions)
        {
            var ratingInstructionsDto = new RatingInstructionsDto
            {
                VsixAuthor = Vsix.Author,
                VsixName = Vsix.Name,
            };

            Probe(hiddenChaserOptions, ratingInstructionsDto);
        }
    }
}