using VsixRatingChaser;
using VsixRatingChaser.Dtos;
using VsixRatingChaser.Interfaces;

namespace Quiz.Rating
{
    public class ChaserGateway
    {
        public static ChaseOutcomeDto Probe(IRatingDetailsDto ratingDetailsDto, ExtensionDetailsDto extensionDetailsDto)
        {
            var chaser = new Chaser();
            var chaseOutcomeDto = chaser.Chase(ratingDetailsDto, extensionDetailsDto);
            return chaseOutcomeDto;
        }
    }
}