using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    public class ModalDialohsTests : BaseTest
    {
        [TestCase("This is a small modal. It has very less content", TestName = "Small Modal Window Test")]
        public void SmallModalWindowTest(string text)
        {
            MainPage.OpenDialogsPage();
            ModalDialogsPage.SmallModalWindowTest(text);
        }

        [TestCase("Lorem Ipsum is simply dummy text of the printing", TestName = "Large Modal Window Test")]
        public void LargeModalWindowTest(string text)
        {
            MainPage.OpenDialogsPage();
            ModalDialogsPage.LargeModalWindowTest(text);
        }
    }
}
