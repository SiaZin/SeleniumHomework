using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace Laba.StepDefinitions
{
    [Binding]
    public class InstagramPageSteps
    {
        IWebDriver driver;
        String test_url = "https://www.epam.com/";

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            driver = new ChromeDriver("C:\\chromedriver");
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }
        
        [When(@"I click accept cookies")]
        public void WhenIClickAcceptCookies()
        {
            IWebElement Cookie_accept = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/button/span"));
            Cookie_accept.Click();
        }
        
        [Then(@"Link for Instagram Button should be https://www\.instagram\.com/epamsystems/")]
        public void ThenLinkForInstagramButtonShouldBeHttpsWww_Instagram_ComEpamsystems()
        {
            String URL;
            String true_url = "https://www.instagram.com/epamsystems/";
            URL = driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[1]/footer/div/div[2]/ul[2]/li[4]/a")).GetAttribute("href");

            Console.WriteLine(URL);
            Assert.AreEqual(URL, true_url);
        }

        [Then(@"close the Chrome browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Close();
        }
    }
}
