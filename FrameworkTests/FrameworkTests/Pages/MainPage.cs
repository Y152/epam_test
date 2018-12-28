using System;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Linq;


namespace FrameworkTests.Pages
{
    class MainPage
    {
        private readonly IWebDriver driver;

        private readonly WebDriverWait wait;
        private readonly string mainUrl = "https://www.onetwotrip.com";

        [FindsBy(How = How.XPath, Using = @"//input[@name ='flights[0].from']")]
        private IWebElement cityFrom;

        [FindsBy(How = How.XPath, Using = @"//input[@name ='flights[0].to']")]
        private IWebElement cityTo;

        [FindsBy(How = How.XPath, Using = @"//input[@name ='flights[0].dates']")]
        private IWebElement clearReturnsDate;

        [FindsBy(How = How.XPath, Using = @"//input[@name ='flights[1].dates']")]
        private IWebElement returnsDate;

        [FindsBy(How = How.XPath, Using = @"/html/body/div[1]/div[2]/div/div/div[4]/div/div[2]/div[2]/div[2]/div/div[2]/div/div/form/div[1]/div[1]/label/div[2]")]
        private IWebElement loginError;
        

        [FindsBy(How = How.XPath, Using = @"/html/body/div[1]/div[2]/div/div/div[4]/div/div")]
        private IWebElement accountButton;

        [FindsBy(How = How.XPath, Using = @"//input[@name ='_6-3-1_2xGEV _6-3-1_1hxS2']")]
        private IWebElement emailField;

        [FindsBy(How = How.XPath, Using = @"//input[@name ='_3BMDqkxM53']")]
        private IWebElement loginButton;
                
        [FindsBy(How = How.XPath, Using = @"//input[@name ='_6-1-4_2OUUO']")]
        private IWebElement languageList;

        [FindsBy(How = How.XPath, Using = @"//input[@name ='_9-0-2_6asgt']")]
        private IWebElement buttonSearch;

        [FindsBy(How = How.XPath, Using = @"//input[@name ='_9-0-2_6asgt']")]
        private IWebElement agreeBox;

        [FindsBy(How = How.XPath, Using = @"//input[@name ='CjvSs']")]
        private IWebElement badSearch;

        public MainPage(IWebDriver Browser)
        {
            this.driver = Browser;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(120);
            driver.Manage().Window.Size = new System.Drawing.Size(driver.Manage().Window.Size.Width, driver.Manage().Window.Size.Height);
            PageFactory.InitElements(Browser, this);
        }

        public void ClearReturnsDate()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(clearReturnsDate));
            clearReturnsDate.Click();
        }

        public string GetReturnsDate()
        {
            return returnsDate.Text;
        }

        public void inputEmail(string email)
        {
            accountButton.Click();
            emailField.SendKeys(email);
            loginButton.Click();
        }
        public string GetIncorrectFormatError()
        {
            return loginError.Text;
        }

        public void ChooseEnglish()
        {
            languageList.SendKeys(Keys.Down + Keys.Enter);
        }

        public void ChooseDeutsch()
        {
            languageList.SendKeys(Keys.Down+Keys.Down + Keys.Enter);
        }

        public void ChooseEspanol()
        {
            languageList.SendKeys(Keys.Down + Keys.Down+Keys.Down + Keys.Enter);
        }

        public void ChooseItaliano()
        {
            languageList.SendKeys(Keys.Down+Keys.Down + Keys.Down + Keys.Down + Keys.Enter);
        }

        public string GetCurrentLanguage()
        {
            Thread.Sleep(3000);
            wait.Until(ExpectedConditions.ElementToBeClickable(buttonSearch));
            return buttonSearch.Text;
        }

        public string GetBadSearch()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(@"/html/body/div[1]/div/div[3]/div[1]/div[1]/div[2]/div/div[10]/div[2]/div[5]/div[2]/div[5]/div/div[1]")));
            return badSearch.Text;
        }

        

        public void GoToThisUrl()
        {
            driver.Navigate().GoToUrl(this.mainUrl);
        }

        public void ClickAgree()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(agreeBox));
            agreeBox.Click();
        }

        public void ClickSearchButton()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(buttonSearch));
            buttonSearch.Click();
        }

        public bool IsDisabledSearchBox()
        {
            return buttonSearch.Enabled ? false : true;
        }

        public bool EqualTabs()
        {
            return driver.WindowHandles.Last() == driver.WindowHandles.First() ? true : false;
        }

        public void SetMainData(string CityFrom, string CityTo)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(cityFrom));
            cityFrom.SendKeys(CityFrom);
            cityFrom.SendKeys(Keys.Enter);
            cityTo.SendKeys(CityTo);
            cityTo.SendKeys(Keys.Enter);

        }
    }
}

