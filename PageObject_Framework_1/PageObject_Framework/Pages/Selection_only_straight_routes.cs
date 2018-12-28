using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace PageObject_Framework.Pages
{
    public class Selection_only_straight_routes
    {
        IWebDriver driver;
        WebDriverWait wait;

        [FindsBy(How = How.XPath, Using = @"//input[@name ='flights[0].dates']")]
        public IWebElement date { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name ='flights[0].from']")]
        public IWebElement fieldToEnterDepartureCountry { get; set; }
        [FindsBy(How = How.XPath, Using = @"//input[@name ='flights[0].to']")]
        public IWebElement enterDepartureCountry { get; set; }
        [FindsBy(How = How.ClassName, Using = "trigger")]
        public IWebElement clickPassengers { get; set; }
        [FindsBy(How = How.ClassName, Using = @"_8-1-14_6asgt")]
        public IWebElement clickP { get; set; }
        [FindsBy(How = How.ClassName, Using = "ui-dialog-titlebar-close")]
        public IWebElement closeWindow { get; set; }
     
        public Selection_only_straight_routes(IWebDriver browser)
        {
            driver = browser;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Manage().Window.Maximize();
            PageFactory.InitElements(browser, this);
        }

        public void Navigate()
        {
            driver.Navigate().GoToUrl("https://www.onetwotrip.com/");
        }
     
        public void Input_departue_and_destination_country(string departue_country, string destination_country)
        {
           // wait.Until(ExpectedConditions.ElementToBeClickable(fieldToEnterDepartureCountry));
            fieldToEnterDepartureCountry.Click();
            fieldToEnterDepartureCountry.SendKeys(departue_country);
         
            enterDepartureCountry.Click();
            enterDepartureCountry.SendKeys(destination_country);
        }
        public void Input_date(string input_date)
        {
          
            date.SendKeys(input_date);
            date.SendKeys(Keys.Enter);
        }
        public void clickpage()
        {
            clickP.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("_1nsHz")));

        }
     
    }
}
