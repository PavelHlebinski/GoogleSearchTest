using GoogleSearchTest.DriverTest;
using NUnit.Framework;

namespace GoogleSearchTest.Tests
{
    class AccordianTest : BaseTest
    {
        [TestCase("Widgets", "Accordian", "text of the printing and typesetting industry.", "Lorem Ipsum is not simply", "will be distracted", TestName = "Accordian text Test")]
        public void AccordianTextTest(string mainButtonName, string expnadButtonName, string firstText, string secondText, string thirdtext)
        {
            MainPage.OpenPageForTests(mainButtonName, expnadButtonName);
            AccordianPage.IsAccordianTextPresent(firstText, secondText, thirdtext);
        }
    }
}
