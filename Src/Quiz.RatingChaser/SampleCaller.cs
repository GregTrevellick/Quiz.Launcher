//using Microsoft.VisualStudio.Shell;
//using System;
//using VsixRatingChaser;
//using VsixRatingChaser.Dtos;
//using VsixRatingChaser.Enums;
//using VsixRatingChaser.Interfaces;

//namespace MyVsix
//{
//    public class MyVsixRatingDetailsDto : DialogPage, IRatingDetailsDto
//    {
//        public DateTime PreviousRatingRequest { get; set; }
//        public int RatingRequestCount { get; set; }
//    }

//    public class SampleCaller
//    {
//        public static ChaseOutcome MyVsixSampleCall()
//        {
//            var ratingDetailsDto = (IRatingDetailsDto)Microsoft.VisualStudio.Shell.GetDialogPage(typeof(MyVsixRatingDetailsDto));

//            var extensionDetailsDto = new ExtensionDetailsDto
//            {
//                AuthorName = "Greg Trevellick",
//                ExtensionName = "Open in Paint.NET",
//                MarketPlaceUrl = "https://marketplace.visualstudio.com/items?itemName=GregTrevellick.OpeninPaintNET"
//            };

//            var chaser = new Chaser();

//            return chaser.Chase(ratingDetailsDto, extensionDetailsDto);
//        }
//    }
//}