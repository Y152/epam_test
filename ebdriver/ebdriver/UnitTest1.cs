
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
        public void Metodtest()
        {
            IWebDriver Driver = new ChromeDriver();
            DateTime date = DateTime.Now;
            string today_date = date.ToString("dd.mm.yyyy");
            Driver.Navigate().GoToUrl("https://www.onetwotrip.com/");
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            //Driver.FindElement(By.XPath("//a[@href='/ru/']")).Click();
            //Driver.FindElement(By.XPath("//li[@class ='searchFormABWayControlItem oneway']")).Click();

            Driver.FindElement(By.XPath("//input[@name ='flights[0].from']")).Click();
            Driver.FindElement(By.XPath("//input[@name ='flights[0].from']")).SendKeys("Минск");

            Driver.FindElement(By.XPath("//input[@name ='flights[0].to']")).Click();
            Driver.FindElement(By.XPath("//input[@name ='flights[0].to']")).SendKeys("Москва");

            Driver.FindElement(By.XPath("//input[@name ='flights[0].dates']")).Click();
            Driver.FindElement(By.XPath("//input[@name ='flights[0].dates']")).SendKeys(today_date);


            Driver.FindElement(By.XPath("//input[@name ='submit']")).Click();
            Assert.AreEqual(Driver.FindElement(By.ClassName("_1MgNS")).Text, "Минск");
            
            Driver.Quit();

        }
    }
}
