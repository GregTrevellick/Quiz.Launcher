using VsixRatingChaser.Dtos;
using VsixRatingChaser.Interfaces;
using static Quiz.Rating.ChaserGateway;

namespace Quiz.Ui.Music
{
    public class PackageRatingChaser
    {
        public void Hunt(IRatingDetailsDto ratingDetailsDto)
        {
            var extensionDetailsDto = new ExtensionDetailsDto
            {
                AuthorName = Vsix.Author,
                ExtensionName = Vsix.Name,
                MarketPlaceUrl = "https://marketplace.visualstudio.com/items?itemName=GregTrevellick.OpeninPaintNET"
            };

            Probe(ratingDetailsDto, extensionDetailsDto);
        }
    }
}