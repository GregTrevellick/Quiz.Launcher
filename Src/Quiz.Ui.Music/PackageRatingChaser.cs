using System;
using System.Reflection;
using Quiz.Rating;
using VsixRatingChaser.Enums;
using VsixRatingChaser.Interfaces;
using static Quiz.Rating.ChaserGateway;

namespace Quiz.Ui.Music
{
    public class PackageRatingChaser
    {
        public void Hunt(IHiddenChaserOptions hiddenChaserOptions)
        {
            var imageByteArray = GetImageByteArray();

            var ratingInstructionsDto = new RatingInstructionsDto
            {
                AggressionLevel = AggressionLevel.High,
                CostCategory = CostCategory.Free,
                DialogType = DialogType.NonModal,
                ImageByteArray = imageByteArray,
                VsixAuthor = Vsix.Author,
                VsixName = Vsix.Name,
            };

            Probe(hiddenChaserOptions, ratingInstructionsDto);
        }

        //private Uri GetIconUri()
        //{
        //    var assemblyName = "Quiz.Ui.Music";
        //    var packUri = $"pack://application:,,,/{assemblyName};component/Resources/vsixextensionicon_90x90_resource_bb6_icon.ico";
        //    return new Uri(packUri, UriKind.RelativeOrAbsolute);
        //}

        private static byte[] GetImageByteArray()
        {
            byte[] imageByteArray;
            ////////////////////var imageResourceNameArray = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            var imageResourceName = "Trivial.Ui.GeekQuiz.Resources.VsixExtensionIcon_90x90_Embedded.png";//imageResourceNameArray[2];
            var assembly = Assembly.GetExecutingAssembly();
            var stream = assembly.GetManifestResourceStream(imageResourceName);
            if (stream == null)
            {
                imageByteArray = null;
            }
            else
            {
                using (stream)
                {
                    imageByteArray = new byte[stream.Length];
                    stream.Read(imageByteArray, 0, imageByteArray.Length);
                }
            }
            return imageByteArray;
        }

    }
}