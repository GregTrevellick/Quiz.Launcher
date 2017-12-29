//using VsixRatingChaser;
//using VsixRatingChaser.Enums;
//using VsixRatingChaser.Interfaces;

//namespace Quiz.Core.Ratings
//{
//    public class RatingChaser
//    {
//        public static IChaseVerdict ChaseRatings(IHiddenChaserOptions hiddenChaserOptions)
//        {
//            var ratingInstructions = new RatingInstructionsDto();
//            ratingInstructions.AggressionLevel = AggressionLevel.High;
//            ratingInstructions.CostCategory = CostCategory.Free;
//            ratingInstructions.DialogType = DialogType.Modal;
//            ratingInstructions.VsixAuthor = "gregt";
//            ratingInstructions.VsixName = "open in";

//            var chaser = new Chaser();
//            var chaseVerdict = chaser.Chase(hiddenChaserOptions, ratingInstructions);
//            return chaseVerdict;
//        }
//    }
//}