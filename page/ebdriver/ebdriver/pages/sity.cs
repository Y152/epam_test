using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
namespace ebdriver
{
    public class ObjectModel
    {
        private IWebDriver driver;
        DateTime date = DateTime.Now;
        private By d_city = By.XPath("//input[@name ='flights[0].from']");
        private By a_city = By.XPath("//input[@name ='flights[0].to']");
        private By t_date = By.XPath("//input[@name ='flights[0].dates']");
        By submit = By.XPath("//input[@name ='submit']");
        public ObjectModel(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void incity(string city)
        {
            driver.FindElement(d_city).Clear();
            driver.FindElement(d_city).SendKeys(city);
        }
        public void outcity(string city)
        {
            driver.FindElement(a_city).Clear();
            driver.FindElement(a_city).SendKeys(city);
        }
        public void Vdate()
        {
            driver.FindElement(t_date).Clear();
            driver.FindElement(t_date).SendKeys(date.ToString("dd.mm.yyyy"));
        }
        public void Enter_click()
        {
            driver.FindElement(submit).Click();
        }
    }
    public class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void goToPage()
        {
            driver.Navigate().GoToUrl("https://www.onetwotrip.com/");
        }
    }

}

