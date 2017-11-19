using System;
using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Quiz.Ui.Core;
using Quiz.Ui.Options;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell.Flavor;

namespace Quiz.Ui
{
    [ProvideAutoLoad(UIContextGuids80.SolutionExists)]
    ////////////////////////////////////////////////[ProvideAutoLoad(UIContextGuids80.NoSolution)]
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

        //////////////////////////////////////////////////[System.Runtime.InteropServices.DispId(304)]
        //////////////////////////////////////////////////[get: System.Runtime.InteropServices.DispId(304)]
        //////////////////////////////////////////////////public EnvDTE.WindowEvents WindowEvents[EnvDTE.Window WindowFilter = null] { get; }

        //////////////////////////////////////////////////[public System.ContextStaticAttribute WithEvents WindowEvents As EnvDTE.WindowEvents;
        //////////////////////////////////////////////////[public WindowEvents_WindowActivated(ByVal GotFocus As EnvDTE.Window, ByVal LostFocus As EnvDTE.Window) Handles WindowEvents.WindowActivated;

        protected override void Initialize()
        {
            base.Initialize();

            IServiceContainer serviceContainer = this as IServiceContainer;
            dte = serviceContainer.GetService(typeof(SDTE)) as DTE;

            ////////////////////////////////////////////////[//this is the window we want to attach an event handler
            ////////////////////////////////////////////////[var w1 = dte.Windows.Item(EnvDTE.Constants.vsWindowKindSolutionExplorer) as Window;

            ////////////////////////////////////////////////////////////////dte.Events.CommandBarEvents
            ////////////////////////////////////////////////////////////////dte.Events.CommandEvents
            ////////////////////////////////////////////////////////////////dte.Events.DTEEvents.
            ////////////////////////////////////////////////////////////////dte.Events.SelectionEvents

            ////////////////////////////////////////////////////////////////https://docs.microsoft.com/en-gb/visualstudio/extensibility/adding-user-control-to-the-start-page
            ////////////////////////////////////////////////////////////////private void WebFrame_Navigated(object sender, EventArgs e)
            ////////////////////////////////////////////////////////////////{ }

            ////////////////////////////////////////////////////////////////https://docs.microsoft.com/en-gb/visualstudio/extensibility/adding-visual-studio-commands-to-a-start-page
            ////////////////////////////////////////////////////////////////< Button Content = "Web Search"
            ////////////////////////////////////////////////////////////////Command = "{x:Static vscom:VSCommands.ExecuteCommand}"
            ////////////////////////////////////////////////////////////////CommandParameter = "View.WebBrowser www.bing.com" />

            ////////////////////////////////////////////////////////////////  //dte.Windows.Item(EnvDTE.Constants.vsWindowKindOutput);
            ////////////////////////////////////////////////////////////////var a =  dte.Windows.Item(typeof(EnvDTE.vsStartUp)).;

            ////////////////////////////////////////////////////////////////  IVsActivityLog log = GetService(typeof(SVsActivityLog)) as IVsActivityLog;
            ////////////////////////////////////////////////////////////////  if (log == null) return;
            ////////////////////////////////////////////////////////////////  int hr = log.LogEntry((UInt32)__ACTIVITYLOG_ENTRYTYPE.ALE_INFORMATION,
            ////////////////////////////////////////////////////////////////      this.ToString(),
            ////////////////////////////////////////////////////////////////      string.Format(CultureInfo.CurrentCulture, "Called for: {0}", this.ToString()));

            ////////////////////////////////////////////////////////////////OleMenuCommandService commandService = this.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            ////////////////////////////////////////////////////////////////if (commandService != null)
            ////////////////////////////////////////////////////////////////{

            ////////////////////////////////////////////////////////////////    //CommandID menuCommandID = new CommandID(MenuGroup, CommandId);
            ////////////////////////////////////////////////////////////////    //EventHandler eventHandler = this.ShowMessageBox;
            ////////////////////////////////////////////////////////////////    //OleMenuCommand menuItem = new OleMenuCommand(ShowMessageBox, menuCommandID);
            ////////////////////////////////////////////////////////////////    //menuItem.BeforeQueryStatus += new EventHandler(OnBeforeQueryStatus);
            ////////////////////////////////////////////////////////////////    //commandService.AddCommand(menuItem);
            ////////////////////////////////////////////////////////////////}
            
            solutionEvents = dte.Events.SolutionEvents;
            
            generalOptionsDto = GetGeneralOptionsDto();

            if (generalOptionsDto.ShowQuizUponOpeningSolution)
            {
                solutionEvents.Opened += OnSolutionOpenedAndOrClosed;
            }

            if (generalOptionsDto.ShowQuizUponClosingSolution)
            {
                solutionEvents.AfterClosing += OnSolutionOpenedAndOrClosed;
            }
        }

        //////////////////////////////////////////////////////////https://docs.microsoft.com/en-gb/visualstudio/extensibility/changing-the-text-of-a-menu-command
        //////////////////////////////////////////////////////////private ChangeMenuText(Package package)
        //////////////////////////////////////////////////////////{
        //////////////////////////////////////////////////////////    if (package == null)
        //////////////////////////////////////////////////////////    {
        //////////////////////////////////////////////////////////        throw new ArgumentNullException(nameof(package));
        //////////////////////////////////////////////////////////    }

        //////////////////////////////////////////////////////////    this.package = package;

        //////////////////////////////////////////////////////////    OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
        //////////////////////////////////////////////////////////    if (commandService != null)
        //////////////////////////////////////////////////////////    {
        //////////////////////////////////////////////////////////        CommandID menuCommandID = new CommandID(MenuGroup, CommandId);
        //////////////////////////////////////////////////////////        FlavoredProject.EventHandler<> eventHandler = this.ShowMessageBox;
        //////////////////////////////////////////////////////////        OleMenuCommand menuItem = new OleMenuCommand(ShowMessageBox, menuCommandID);
        //////////////////////////////////////////////////////////        menuItem.BeforeQueryStatus +=
        //////////////////////////////////////////////////////////            new FlavoredProject.EventHandler<>(OnBeforeQueryStatus);
        //////////////////////////////////////////////////////////        commandService.AddCommand(menuItem);
        //////////////////////////////////////////////////////////    }
        //////////////////////////////////////////////////////////}

        private void OnSolutionOpenedAndOrClosed()
        {
            //ChaseRatings();

            generalOptionsDto = GetGeneralOptionsDto();

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
                MaximumPopUpsWeekDay = generalOptions.MaximumPopUpsWeekDay.GetAsInteger(),
                MaximumPopUpsWeekEnd = generalOptions.MaximumPopUpsWeekEnd.GetAsInteger(),
                PopUpIntervalInMins = generalOptions.PopUpIntervalInMins.GetAsInteger(),
                PopUpCountToday = hiddenOptions.PopUpCountToday,
                SearchEngine = generalOptions.UseBingInsteadOfGoogle ? SearchEngine.Bing : SearchEngine.Google,
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