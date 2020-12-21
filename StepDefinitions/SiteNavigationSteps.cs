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
    public class SiteNavigationSteps
    {
        IWebDriver driver;
        String test_url = "https://www.epam.com/";

        [Given(@"I am on home page")]
        public void GivenIAmOnHomePage()
        {
            driver = new ChromeDriver("C:\\chromedriver");
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"I click on (.*)")]
        public void WhenIClickOnButton(string p0)
        {
            IWebElement MyLink = driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/a"));

            if(p0.Contains("how"))
            {
                 MyLink = driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[2]/span/a"));
            }
            if(p0.Contains("insights"))
            {
                 MyLink = driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[4]/span/a"));
            }

            MyLink.Click();
        }
        
        [Then(@"the page should be (.*)")]
        public void ThenThePageShouldBe(string p1)
        {
            String URL = driver.Url;
            Console.WriteLine(URL);
            Assert.AreEqual(URL, p1);
            driver.Close();
        }
    }
}
