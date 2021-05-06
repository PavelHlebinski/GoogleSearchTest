using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    class AccordianTest : BaseTest
    {
        [TestCase("text of the printing and typesetting industry.", "Lorem Ipsum is not simply", "will be distracted", TestName = "Accordian text Test")]
        public void AccordianTextTest(string firstText, string secondText, string thirdtext)
        {
            MainPage.OpenAccordianPage();
            AccordianPage.IsAccordianTextPresent(firstText, secondText, thirdtext);
        }
    }
}
