using GoogleSearchTest.Driver;
using GoogleSearchTest.Pages.DemoqaPages;
using GoogleSearchTest.Settings;
using NUnit.Framework;

namespace GoogleSearchTest.DriverTest
{
    public class BaseTest
    {
        private readonly string url = AppSettings.ReadSettings().URL;
        protected MainPage MainPage = new MainPage();
        protected FormsPage FormsPage = new FormsPage();
        protected SubmitFormPage SubmitFormPage = new SubmitFormPage();
        protected BrowserWindowsPage BrowserWindowsPage = new BrowserWindowsPage();
        protected AlertsPage AlertsPage = new AlertsPage();
        protected FramesPage FramesPage = new FramesPage();
        protected ModalDialogsPage ModalDialogsPage = new ModalDialogsPage();
        protected AccordianPage AccordianPage = new AccordianPage();
        protected AutoCompletePage AutoCompletePage = new AutoCompletePage();
        protected DataPage DataPage = new DataPage();
        protected ProgressBarPage ProgressBarPage = new ProgressBarPage();
        protected MenuPage MenuPage = new MenuPage();
        protected SelectMenu SelectMenu = new SelectMenu();

        [SetUp]
        public void SetUp() => MainPage.OpenPage(url);

        [OneTimeTearDown]
        public void OneTimeTearDown() => DriverFactory.QuitDriver();
    }
}
