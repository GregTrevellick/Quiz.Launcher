using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Quiz.Ui.Core;
using Quiz.Ui.Options;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using EnvDTE80;
using Quiz.Questions;
using Quiz.Questions.Entities;

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