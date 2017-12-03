using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Quiz.Core;
using Quiz.Questions;
using Quiz.Ui.Music.Options;

namespace Quiz.Ui.Music
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
        public const string PackageGuidString = "591fb568-f7ea-4646-8500-7277e7673c22";

        private DTE dte;
        private SolutionEvents solutionEvents;
        private GeneralOptionsDto generalOptionsDto;
        private WindowVisibilityEvents toolBoxWindowVisibilityEvents;

        protected override void Initialize()
        {
            base.Initialize();
            IServiceContainer serviceContainer = this as IServiceContainer;
            dte = serviceContainer.GetService(typeof(SDTE)) as DTE;
            generalOptionsDto = GetGeneralOptionsDto();

            AttachToWindowShowingEvent();
            AttachToSolutionOpenedOrClosedEvents();
        }

        private void AttachToWindowShowingEvent()
        {
            if (generalOptionsDto.ShowQuizUponOpeningStartPage)
            {
                var events2 = (Events2)dte.Events;
                //var toolBoxWindowFilter = dte.Windows.Item(Constants.vsWindowKindToolbox);
                toolBoxWindowVisibilityEvents = events2.get_WindowVisibilityEvents();//(toolBoxWindowFilter);
                toolBoxWindowVisibilityEvents.WindowShowing += windowVisibilityEvents_WindowShowing;
            }
        }

        private void windowVisibilityEvents_WindowShowing(Window window)
        {
            //System.Windows.Forms.MessageBox.Show("window.ObjectKind =" + window.ObjectKind + " window.Type=" + window.Type);
            if (window.Type == vsWindowType.vsWindowTypeToolWindow && window.Caption == "Start Page")
            {
                StartQuiz();
            }
        }

        private void AttachToSolutionOpenedOrClosedEvents()
        {
            if (generalOptionsDto.ShowQuizUponOpeningSolution)
            {
                if (solutionEvents == null)
                {
                    solutionEvents = dte.Events.SolutionEvents;
                }
                solutionEvents.Opened += StartQuiz;
            }

            if (generalOptionsDto.ShowQuizUponClosingSolution)
            {
                if (solutionEvents == null)
                {
                    solutionEvents = dte.Events.SolutionEvents;
                }
                solutionEvents.AfterClosing += StartQuiz;
            }
        }

        private void StartQuiz()
        {
            //TODO ChaseRatings();

            var shouldShowQuiz = new DecisionMaker().ShouldShowQuiz(generalOptionsDto);

            if (shouldShowQuiz)
            {
                var popUpTitle = Core.Constants.GetCaption(Vsix.Name, Vsix.Version);
                var quizHelper = new QuizHelper();
                quizHelper.PersistHiddenOptionsQuizHelperEventHandlerEventHandler += UpdateHiddenOptionsTotals;

                var quizHelperDto = new QuizHelperDto
                {
                    LastPopUpDateTime = generalOptionsDto.LastPopUpDateTime,
                    OptionsName = Vsix.Name,
                    PopUpCountToday = generalOptionsDto.PopUpCountToday,
                    PopUpTitle = popUpTitle,
                    PreferredCategoriesFromOptions = generalOptionsDto.PreferredCategoriesFromOptions,
                    SearchEngine = generalOptionsDto.SearchEngine,
                    SuppressClosingWithoutSubmitingAnswerWarning = generalOptionsDto.SuppressClosingWithoutSubmitingAnswerWarning,
                    TimeOutInMilliSeconds = generalOptionsDto.TimeOutInMilliSeconds,
                    TotalQuestionsAnsweredCorrectlyEasy = generalOptionsDto.TotalQuestionsAnsweredCorrectlyEasy,
                    TotalQuestionsAnsweredCorrectlyHard = generalOptionsDto.TotalQuestionsAnsweredCorrectlyHard,
                    TotalQuestionsAnsweredCorrectlyMedium = generalOptionsDto.TotalQuestionsAnsweredCorrectlyMedium,
                    TotalQuestionsAsked = generalOptionsDto.TotalQuestionsAsked,
                };

                var hiddenOptionsDto = quizHelper.GetHiddenOptionsDto(quizHelperDto, new QuizQuestionApi());

                if (hiddenOptionsDto != null)
                {
                    UpdateHiddenOptions(hiddenOptionsDto);
                }
            }
        }

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
                IncludeQuizCategoryCSharp = generalOptions.IncludeQuizCategoryCSharp,
                IncludeQuizCategoryDotNet = generalOptions.IncludeQuizCategoryDotNet,
                IncludeQuizCategoryGeek = generalOptions.IncludeQuizCategoryGeek,
                IncludeQuizCategoryJavascript = generalOptions.IncludeQuizCategoryJavascript,
                IncludeQuizCategoryWebDev = generalOptions.IncludeQuizCategoryWebDev,
                LastPopUpDateTime = hiddenOptions.LastPopUpDateTime,
                MaximumPopUpsWeekDay = generalOptions.MaximumPopUpsWeekDay.GetAsInteger(),
                MaximumPopUpsWeekEnd = generalOptions.MaximumPopUpsWeekEnd.GetAsInteger(),
                PopUpIntervalInMins = generalOptions.PopUpIntervalInMins.GetAsInteger(),
                PopUpCountToday = hiddenOptions.PopUpCountToday,
                SearchEngine = generalOptions.UseBingInsteadOfGoogle ? SearchEngine.Bing : SearchEngine.Google,
                ShowQuizUponOpeningStartPage = generalOptions.ShowQuizUponOpeningStartPage,
                ShowQuizUponClosingSolution = generalOptions.ShowQuizUponClosingSolution,
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


//using System;
//using System.ComponentModel.Design;
//using System.Diagnostics;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.Runtime.InteropServices;
//using Microsoft.VisualStudio;
//using Microsoft.VisualStudio.OLE.Interop;
//using Microsoft.VisualStudio.Shell;
//using Microsoft.VisualStudio.Shell.Interop;
//using Microsoft.Win32;

//namespace Quiz.Ui.Music
//{
//    /// <summary>
//    /// This is the class that implements the package exposed by this assembly.
//    /// </summary>
//    /// <remarks>
//    /// <para>
//    /// The minimum requirement for a class to be considered a valid package for Visual Studio
//    /// is to implement the IVsPackage interface and register itself with the shell.
//    /// This package uses the helper classes defined inside the Managed Package Framework (MPF)
//    /// to do it: it derives from the Package class that provides the implementation of the
//    /// IVsPackage interface and uses the registration attributes defined in the framework to
//    /// register itself and its components with the shell. These attributes tell the pkgdef creation
//    /// utility what data to put into .pkgdef file.
//    /// </para>
//    /// <para>
//    /// To get loaded into VS, the package must be referred by &lt;Asset Type="Microsoft.VisualStudio.VsPackage" ...&gt; in .vsixmanifest file.
//    /// </para>
//    /// </remarks>
//    [PackageRegistration(UseManagedResourcesOnly = true)]
//    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
//    [Guid(VSPackage.PackageGuidString)]
//    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
//    public sealed class VSPackage : Package
//    {
//        /// <summary>
//        /// VSPackage GUID string.
//        /// </summary>
//        public const string PackageGuidString = "3c00380e-3bb5-4944-b5f8-8442554a90f6";

//        /// <summary>
//        /// Initializes a new instance of the <see cref="VSPackage"/> class.
//        /// </summary>
//        public VSPackage()
//        {
//            // Inside this method you can place any initialization code that does not require
//            // any Visual Studio service because at this point the package object is created but
//            // not sited yet inside Visual Studio environment. The place to do all the other
//            // initialization is the Initialize method.
//        }

//        #region Package Members

//        /// <summary>
//        /// Initialization of the package; this method is called right after the package is sited, so this is the place
//        /// where you can put all the initialization code that rely on services provided by VisualStudio.
//        /// </summary>
//        protected override void Initialize()
//        {
//            base.Initialize();
//        }

//        #endregion
//    }
//}
