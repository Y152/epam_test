using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

using OpenQA.Selenium.Support.UI;


namespace PageObject_Framework.Pages
{
    [TestFixture]
    public class AviaTests
    {
        IWebDriver driver;
        WebDriverWait wait;
        [SetUp]
        public void SetupTest()
        {
            driver = Driver.DriverInstance.GetInstance();

        }

        [TearDown]
        public void TeardownTest()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        [Test]
        public void Selection_straight_route()
        {
            Selection_only_straight_routes search_avia = new Selection_only_straight_routes(driver);
            search_avia.Navigate();
            search_avia.Input_departue_and_destination_country("Минск", "Москва");
            search_avia.Input_date("21.12.2018");
            search_avia.clickpage();
            Assert.AreEqual(driver.FindElement(By.ClassName("_8-1-14_6asgt")).Text, "Минск", "error: not found");
        }
    }
}
