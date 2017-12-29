using VsixRatingChaser.Interfaces;

namespace Quiz.Rating
{
    public class ExtensionDetailsDto : IExtensionDetailsDto
    {
        public string AuthorName { get; set; }
        public string ExtensionName { get; set; }
        public string MarketPlaceUrl { get; set; }
    }
}