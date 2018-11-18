using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            ObjectModel enter = new ObjectModel(driver);
            HomePage homePage = new HomePage(driver);
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            homePage.goToPage();
            enter.incity("MSQ");
            enter.outcity("MSQ");
            enter.Vdate();
            enter.Enter_click();
            Assert.AreEqual(driver.FindElement(By.ClassName("dropdown-item-empty")).Text, "Unfortunately, we do not fly to/from Minsk");
            driver.Quit();
            }
    }
}
