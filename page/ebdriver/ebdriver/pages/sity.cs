using OpenQA.Selenium;

using OpenQA.Selenium.Support.PageObjects;

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

    public class sity

    {

        private IWebDriver driver;
        DateTime date = DateTime.Now;
        


        By d_city = By.XPath("//input[@name ='from0']");

        By a_city = By.XPath("//input[@name ='to0']");

        By t_date = By.XPath("//input[@name ='date0']");

        By enter_result = By.XPath("//input[@name ='submit']");



        public sity(IWebDriver driver)

        {

            this.driver = driver;

            PageFactory.InitElements(driver, this);

        }



        public void Enter_dcity(string city)

        {

            driver.FindElement(d_city).Clear();

            driver.FindElement(d_city).SendKeys(city);

        }



        public void Enter_acity(string city)

        {

            driver.FindElement(a_city).Clear();

            driver.FindElement(a_city).SendKeys(city);

        }
        public void Enter_date()

        {

            driver.FindElement(t_date).Clear();

            driver.FindElement(t_date).SendKeys(date.ToString("dd.mm.yyyy"));
        }



        public void Enter_result_click()

        {

            driver.FindElement(enter_result).Click();

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

