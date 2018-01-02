using VsixRatingChaser.Dtos;
using VsixRatingChaser.Interfaces;
using static Quiz.Rating.ChaserGateway;

namespace Quiz.Ui
{
    public class PackageRatingChaser
    {
        public void Hunt(IRatingDetailsDto ratingDetailsDto)
        {
            var extensionDetailsDto = new ExtensionDetailsDto
            {
                AuthorName = Vsix.Author,
                ExtensionName = Vsix.Name,
                MarketPlaceUrl = "https://marketplace.visualstudio.com/items?itemName=GregTrevellick.DailyGeekQuiz"
            };

            Probe(ratingDetailsDto, extensionDetailsDto);
        }
    }
}