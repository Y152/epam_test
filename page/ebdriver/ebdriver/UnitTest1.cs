
using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium;

using OpenQA.Selenium.Remote;

using OpenQA.Selenium.Support;

using OpenQA.Selenium.Support.UI;

using System.Threading;

using System.Globalization;

namespace ebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        // Выбор одного города в качестве места отправления и прибытия

      

        public void TestMethod1()

        {

            IWebDriver driver = new ChromeDriver();

            sity enter = new sity(driver);

            HomePage homePage = new HomePage(driver);

            homePage.goToPage();
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            driver.FindElement(By.XPath("//a[@href='/ru/']")).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[@class ='searchFormABWayControlItem oneway']")));

            driver.FindElement(By.XPath("//li[@class ='searchFormABWayControlItem oneway']")).Click();





            enter.Enter_dcity("Минск");


     enter.Enter_acity("Минск");

            enter.Enter_date();

       

            enter.Enter_result_click();

            Assert.AreEqual(driver.FindElement(By.ClassName("dropdown-item-empty")).Text, "Unfortunately, we do not fly to/from Minsk");



            driver.Close();

            driver.Quit();

        }
    }
}
