using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class ModalDialohsTests : BaseTest
    {
        [TestCase("Alerts, Frame & Windows", "Modal Dialogs", "This is a small modal. It has very less content", TestName = "Small Modal Window Test")]
        public void SmallModalWindowTest(string mainButtonName, string expnadButtonName, string text)
        {
            MainPage.OpenPage(mainButtonName, expnadButtonName);
            ModalDialogsPage.SmallModalWindowTest(text);
        }

        [TestCase("Alerts, Frame & Windows", "Modal Dialogs", "Lorem Ipsum is simply dummy text of the printing", TestName = "Large Modal Window Test")]
        public void LargeModalWindowTest(string mainButtonName, string expnadButtonName, string text)
        {
            MainPage.OpenPage(mainButtonName, expnadButtonName);
            ModalDialogsPage.LargeModalWindowTest(text);
        }
    }
}
