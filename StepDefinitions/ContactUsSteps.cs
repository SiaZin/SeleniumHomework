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
    public class ContactUsSteps
    {

        IWebDriver driver;
        String test_url = "https://www.epam.com/";
        [Given(@"User is on the Global English-language home page")]
        public void GivenUserIsOnTheGlobalEnglish_LanguageHomePage()
        {
            driver = new ChromeDriver("C:\\chromedriver");
            driver.Url = test_url;
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);

            IWebElement Cookie_accept = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/button/span"));
            Cookie_accept.Click();
        }
        
        [Given(@"User follows Contact Us")]
        public void GivenUserFollowsContactUs()
        {
            IWebElement ContactUs_buttom = driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/ul/li[1]/a/span"));
            ContactUs_buttom.Click();
        }
        
        [When(@"user enters the details")]
        public void WhenUserEntersTheDetails(Table table)
        {
         //   ScenarioContext.Current.Pending();
            var dictionary = Utils.TableExtensions.ToDictionary(table);
        //    var test = dictionary["First Name"];

            driver.FindElement(By.Name("user_first_name")).SendKeys(dictionary["First Name"]); 
            driver.FindElement(By.Name("user_last_name")).SendKeys(dictionary["Last Name"]); 
            driver.FindElement(By.Name("user_email")).SendKeys(dictionary["Email"]);
            driver.FindElement(By.Name("user_phone")).SendKeys(dictionary["Phone"]);

            IWebElement Hear = driver.FindElement(By.Id("_content_epam_en_about_who-we-are_contact_jcr_content_content-container_section_section-par_form_constructor_user_comment_how_hear_about-label"));
            Hear.Click();
            Hear.SendKeys(Keys.Enter);
           
        }
        
        [When(@"user clicks Submit")]
        public void WhenUserClicksSubmit()
        {
            IWebElement Submit_button = driver.FindElement(By.XPath("//*[@id='_content_epam_en_about_who - we - are_contact_jcr_content_content - container_section_section - par_form_constructor']/div[3]/div/div[2]/button"));
            Submit_button.Click();
        }

        [When(@"user clicks check box for processing personal information")]
        public void WhenUserClicksCheckBoxForProcessingPersonalInformation()
        {
            IWebElement Agree_box = driver.FindElement(By.XPath("//*[@id='_content_epam_en_about_who - we - are_contact_jcr_content_content - container_section_section - par_form_constructor']/div[2]/div/div/div/div/div[8]/div/div[2]/label"));
            Agree_box.Click();
        }
        
        [Then(@"user returns back on registration page")]
        public void ThenUserReturnsBackOnRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"user should see successful notification")]
        public void ThenUserShouldSeeSuccessfulNotification()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
