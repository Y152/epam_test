using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace PageObject_Framework.Pages
{
    [TestFixture]
    public class AviaTests
    {
        public IWebDriver driver;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
        }

        [TearDown]
        public void TeardownTest()
        {
            driver.Quit();
        }

        [Test]
        public void AviaTest_Direct_route_selection()
        {
            SearchAvia search_avia = new SearchAvia(driver);
            search_avia.Navigate();
            search_avia.Close_Sendpulse();
            search_avia.Input_departue_and_destination_country("Пекин", "Нью-Йорк");
            search_avia.Input_date("21.11.2018");
            search_avia.Selection_only_straight_route();
            search_avia.Choise_2_passengers();
            Assert.AreEqual(driver.FindElement(By.ClassName("nemo-flights-results__flightsGroup__leg__selector__footer__transfers__notransfers")).Text, "Без пересадок", "Warning: Showing flights with transfers");
        }
    }
}
