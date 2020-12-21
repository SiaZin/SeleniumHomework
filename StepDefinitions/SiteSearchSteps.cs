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
    public class SiteSearchSteps
    {

        IWebDriver driver;
        String test_url = "https://www.epam.com/";

        [Given(@"I am on the Global English-language home page")]
        public void GivenIAmOnTheGlobalEnglish_LanguageHomePage()
        {
            driver = new ChromeDriver("C:\\chromedriver");
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }
        
        [When(@"I use the search bar")]
        public void WhenIClickOnTheSearchBar()
        {
            IWebElement icon = driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/ul/li[3]/div/button"));
            icon.Click();
        }
        
        [When(@"I search for (.*)")]
        public void WhenISearchFor(string p1)
        {
            IWebElement search_bar = driver.FindElement(By.XPath("//*[@id='new_form_search']"));
            search_bar.SendKeys(p1);
        }
        
        [When(@"I press find button")]
        public void WhenIPressFindButton()
        {
            IWebElement f_button = driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/ul/li[3]/div/div/form/button"));
            f_button.Click();
        }
        
        [When(@"I enter Russian words")]
        public void WhenIEnterRussianWords()
        {
            IWebElement search_bar = driver.FindElement(By.XPath("//*[@id='new_form_search']"));
            search_bar.SendKeys("Тульские пряники");
        }
        
        [Then(@"I should see (.*) as the number of the results for my request")]
        public void ThenIShouldSeeAsTheNumberOfTheResultsForMyRequest(string p0)
        {
            var result = driver.FindElement(By.ClassName("search-results__counter")).Text;
            Assert.That((result.Contains(p0)), Is.True);
            Console.WriteLine("Chrome - Test 1 Passed");
        }
        
        [Then(@"Error message is displayed")]
        public void ThenErrorMessageIsDisplayed()
        {
            var search_exeption = driver.FindElement(By.XPath("//*[@id='main']/div[1]/div/section/div/div[2]/section/div[1]")).Text;
            Assert.That(search_exeption.Contains("Sorry, but your search returned no results. Please try another query."), Is.True);
            Console.WriteLine("Chrome - Test 2 Passed");
        }

        [Then(@"close the browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Close();
        }

    }
}
