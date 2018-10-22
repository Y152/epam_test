
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

        public void inability_to_order_past_date()

        {

            IWebDriver Driver = new ChromeDriver();
            DateTime date = DateTime.Now;



            string today_date = date.ToString("dd.mm.yyyy");
            Driver.Navigate().GoToUrl("https://www.onetwotrip.com/");
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='/ru/']")));
            Driver.FindElement(By.XPath("//a[@href='/ru/']")).Click();


            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//li[@class ='searchFormABWayControlItem oneway']")));
            Driver.FindElement(By.XPath("//li[@class ='searchFormABWayControlItem oneway']")).Click();


          


            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@name ='from0']")));
            Driver.FindElement(By.XPath("//input[@name ='from0']")).Click();
            Driver.FindElement(By.XPath("//input[@name ='from0']")).SendKeys("Минск");

            Driver.FindElement(By.XPath("//input[@name ='to0']")).Click();
            Driver.FindElement(By.XPath("//input[@name ='to0']")).SendKeys("Москва");

            Driver.FindElement(By.XPath("//input[@name ='date0']")).Click();
            Driver.FindElement(By.XPath("//input[@name ='date0']")).SendKeys(today_date);


            Driver.FindElement(By.XPath("//input[@name ='submit']")).Click();

            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//div[@class='_1tBwH']")));
           //Driver.FindElement(By.XPath("//div[@class='_1tBwH']")).Click();

            Driver.Quit();

        }
    }
}
