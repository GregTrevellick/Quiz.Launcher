using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Quiz.Ui.Core;
using Quiz.Ui.Options;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using EnvDTE80;

namespace Quiz.Ui
{
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
    [ProvideAutoLoad(UIContextGuids80.NoSolution)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration(productName: "#110", productDetails: "#112", productId: Vsix.Version, IconResourceID = 400)]
    [Guid(Vsix.Id)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    [ProvideOptionPage(typeof(GeneralOptions), Vsix.Name, Core.Constants.CategorySubLevelGeneral, 0, 0, true)]
    public sealed class VSPackage : Package
    {
        public const string PackageGuidString = "64f118a1-8d56-45f4-a39f-8972bb67fb2f";

        private DTE dte;
        private SolutionEvents solutionEvents;
        private GeneralOptionsDto generalOptionsDto;
        //private WindowEvents windowEvents;
        //private DocumentEvents documentEvents;
        private EnvDTE80.WindowVisibilityEvents windowVisibilityEvents;

        protected override void Initialize()
        {
            base.Initialize();
            IServiceContainer serviceContainer = this as IServiceContainer;
            dte = serviceContainer.GetService(typeof(SDTE)) as DTE;
            generalOptionsDto = GetGeneralOptionsDto();

            //OnIdeOpened();
            OnStartPageOpened();
            OnSolutionOpened();
        }

        //private void OnIdeOpened()
        //{
        //    if (generalOptionsDto.ShowQuizUponOpeningIde)
        //    {
        //        StartQuiz();
        //    }
        //}

        private void OnStartPageOpened()
        {
            if (generalOptionsDto.ShowQuizUponOpeningStartPage)
            {
                //windowEvents = dte.Events.WindowEvents;
                //windowEvents = dte.Events.get_WindowEvents();
                //windowEvents.WindowCreated += OnWindowCreated;



                EnvDTE80.Events2 events2;

                events2 = (EnvDTE80.Events2)dte.Events;

                windowVisibilityEvents = events2.get_WindowVisibilityEvents();

                windowVisibilityEvents.WindowShowing += new _dispWindowVisibilityEvents_WindowShowingEventHandler(windowVisibilityEvents_WindowShowing);
                windowVisibilityEvents.WindowHiding += new _dispWindowVisibilityEvents_WindowHidingEventHandler(windowVisibilityEvents_WindowHiding);
            }
        }

        //MASSIVE CREDIT TO https://www.mztools.com/articles/2011/MZ2011010.aspx


        private void windowVisibilityEvents_WindowShowing(EnvDTE.Window window)
        {
            if (window.Type != vsWindowType.vsWindowTypeDocument)
            {
                System.Windows.Forms.MessageBox.Show("Showing toolwindow of kind " + window.ObjectKind + " and caption '" + window.Caption + "'");
            }
        }

        private void windowVisibilityEvents_WindowHiding(EnvDTE.Window window)
        {
            if (window.Type != vsWindowType.vsWindowTypeDocument)
            {
                System.Windows.Forms.MessageBox.Show("Hiding toolwindow of kind " + window.ObjectKind + " and caption '" + window.Caption + "'");
            }
        }

        //private void OnDocumentOpening(Document document)
        //{
        //    //if (null != window.Document && window.Document.FullName == "Start Page")
        //    if (document.Name == "Start Page")
        //    {
        //        StartQuiz();
        //    }
        //}

        //public void OnWindowCreated(Window window)
        //{
        //    //if (null != window.Document && window.Document.FullName == "Start Page")
        //    if (window.Caption == "Start Page")
        //    {
        //        StartQuiz();
        //    }
        //}

        private void OnSolutionOpened()
        {
            if (generalOptionsDto.ShowQuizUponOpeningSolution)
            {
                solutionEvents = dte.Events.SolutionEvents;
                solutionEvents.Opened += StartQuiz;
            }

            if (generalOptionsDto.ShowQuizUponClosingSolution)
            {
                solutionEvents = dte.Events.SolutionEvents;
                solutionEvents.AfterClosing += StartQuiz;
            }
        }

        private void StartQuiz()
        {
            //ChaseRatings();

            ////////////////////////////////////generalOptionsDto = GetGeneralOptionsDto();

            var shouldShowQuiz = new DecisionMaker().ShouldShowQuiz(generalOptionsDto);

            if (shouldShowQuiz)
            {
                var popUpTitle = Core.Constants.GetCaption(Vsix.Name, Vsix.Version);
                var quizHelper = new QuizHelper();
                quizHelper.PersistHiddenOptionsQuizHelperEventHandlerEventHandler += UpdateHiddenOptionsTotals;

                var hiddenOptionsDto = quizHelper.GetHiddenOptionsDto(popUpTitle, generalOptionsDto.LastPopUpDateTime, generalOptionsDto.PopUpCountToday, generalOptionsDto.TimeOutInMilliSeconds, Vsix.Name, generalOptionsDto.SuppressClosingWithoutSubmitingAnswerWarning,
                    generalOptionsDto.TotalQuestionsAnsweredCorrectlyEasy, generalOptionsDto.TotalQuestionsAnsweredCorrectlyMedium, generalOptionsDto.TotalQuestionsAnsweredCorrectlyHard, generalOptionsDto.TotalQuestionsAsked, generalOptionsDto.SearchEngine);

                if (hiddenOptionsDto != null)
                {
                    UpdateHiddenOptions(hiddenOptionsDto);
                }
            }
        }

        //private void ChaseRatings()
        //{
        //    var hiddenChaserOptions = (IHiddenChaserOptions)GetDialogPage(typeof(HiddenChaserOptions));
        //    var imageByteArray = GetImageByteArray();
        //    var ratingInstructionsDto = new RatingInstructionsDto
        //    {
        //        AggressionLevel = AggressionLevel.High,
        //        CostCategory = CostCategory.Free,
        //        DialogType = DialogType.NonModal,
        //        ImageByteArray = imageByteArray,
        //        VsixAuthor = Vsix.Author,
        //        VsixName = Vsix.Name,
        //    };
        //    RatingChaser.ChaseRatings(hiddenChaserOptions, ratingInstructionsDto);
        //}     

        private void UpdateHiddenOptionsTotals(int? totalQuestionsAsked, int? totalQuestionsAnsweredCorrectlyEasy, int? totalQuestionsAnsweredCorrectlyMedium, int? totalQuestionsAnsweredCorrectlyHard)
        {
            var hiddenOptions = (HiddenOptions)GetDialogPage(typeof(HiddenOptions));
            hiddenOptions.TotalQuestionsAnsweredCorrectlyEasy = totalQuestionsAnsweredCorrectlyEasy.HasValue ? totalQuestionsAnsweredCorrectlyEasy.Value : 0;
            hiddenOptions.TotalQuestionsAnsweredCorrectlyMedium = totalQuestionsAnsweredCorrectlyMedium.HasValue ? totalQuestionsAnsweredCorrectlyMedium.Value : 0;
            hiddenOptions.TotalQuestionsAnsweredCorrectlyHard = totalQuestionsAnsweredCorrectlyHard.HasValue ? totalQuestionsAnsweredCorrectlyHard.Value : 0;
            hiddenOptions.TotalQuestionsAsked = totalQuestionsAsked.HasValue ? totalQuestionsAsked.Value : 0;
            hiddenOptions.SaveSettingsToStorage();
        }

        private void UpdateHiddenOptions(HiddenOptionsDto hiddenOptionsDto)
        {
            var hiddenOptions = (HiddenOptions)GetDialogPage(typeof(HiddenOptions));
            hiddenOptions.LastPopUpDateTime = hiddenOptionsDto.LastPopUpDateTime;
            hiddenOptions.PopUpCountToday = hiddenOptionsDto.PopUpCountToday;
            hiddenOptions.SaveSettingsToStorage();
        }

        private GeneralOptionsDto GetGeneralOptionsDto()
        {
            var generalOptions = (GeneralOptions)GetDialogPage(typeof(GeneralOptions));
            var hiddenOptions = (HiddenOptions)GetDialogPage(typeof(HiddenOptions));

            return new GeneralOptionsDto
            {
                LastPopUpDateTime = hiddenOptions.LastPopUpDateTime,
                //MaximumPopUpsPerDay = generalOptions.MaximumPopUpsPerDay.GetAsInteger(),
                MaximumPopUpsWeekDay = generalOptions.MaximumPopUpsWeekDay.GetAsInteger(),
                MaximumPopUpsWeekEnd = generalOptions.MaximumPopUpsWeekEnd.GetAsInteger(),
                PopUpIntervalInMins = generalOptions.PopUpIntervalInMins.GetAsInteger(),
                PopUpCountToday = hiddenOptions.PopUpCountToday,
                SearchEngine = generalOptions.UseBingInsteadOfGoogle ? SearchEngine.Bing : SearchEngine.Google,
                //ShowQuizUponOpeningIde = generalOptions.ShowQuizUponOpeningIde,
                ShowQuizUponOpeningStartPage = generalOptions.ShowQuizUponOpeningStartPage,
                //ShowQuizUponClosingSolution = generalOptions.ShowQuizUponClosingSolution,
                ShowQuizUponOpeningSolution = generalOptions.ShowQuizUponOpeningSolution,
                SuppressClosingWithoutSubmitingAnswerWarning = generalOptions.SuppressClosingWithoutSubmitingAnswerWarning,
                TimeOutInMilliSeconds = generalOptions.TimeOutInMilliSeconds.GetAsInteger(),
                TotalQuestionsAnsweredCorrectlyEasy = hiddenOptions.TotalQuestionsAnsweredCorrectlyEasy,
                TotalQuestionsAnsweredCorrectlyMedium = hiddenOptions.TotalQuestionsAnsweredCorrectlyMedium,
                TotalQuestionsAnsweredCorrectlyHard = hiddenOptions.TotalQuestionsAnsweredCorrectlyHard,
                TotalQuestionsAsked = hiddenOptions.TotalQuestionsAsked,
            };
        }
    }
}

//private static byte[] GetImageByteArray()
//{
//    byte[] imageByteArray;
//    ////////////////////var imageResourceNameArray = Assembly.GetExecutingAssembly().GetManifestResourceNames();
//    var imageResourceName = "Trivial.Ui.GeekQuiz.Resources.VsixExtensionIcon_90x90_Embedded.png";//imageResourceNameArray[2];
//    var assembly = Assembly.GetExecutingAssembly();
//    var stream = assembly.GetManifestResourceStream(imageResourceName);
//    if (stream == null)
//    {
//        imageByteArray = null;
//    }
//    else
//    {
//        using (stream)
//        {
//            imageByteArray = new byte[stream.Length];
//            stream.Read(imageByteArray, 0, imageByteArray.Length);
//        }
//    }
//    return imageByteArray;
//}