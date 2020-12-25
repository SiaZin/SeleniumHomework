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
    public class VideosOnTheConsultDesignPageSteps
    {

        IWebDriver driver;
        String test_url = "https://www.epam.com/";

        [Given(@"user is on the Global English-language home page")]
        public void GivenUserIsOnTheGlobalEnglish_LanguageHomePage()
        {
            driver = new ChromeDriver("C:\\chromedriver");
            driver.Navigate().GoToUrl(test_url);
            driver.Manage().Window.Maximize();
        }
        
        [Given(@"user accept cookie")]
        public void GivenUserAcceptCookie()
        {
            IWebElement Cookie_accept = driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div/div/div[2]/button/span"));
            Cookie_accept.Click();
        }

        [Given(@"user follows Consult & Design")]
        public void GivenUserFollowsConsultDesign()
        {
            //ждем загрузуи страницы и наводим на Services
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[1]/span[1]/a")));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            //нажимаем на элемент из выпавшего списка
            IWebElement Consult_Design = driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[1]/div/div/div/a"));
            Consult_Design.Click();
        }

        [When(@"user pushes the play buttom")]
        public void WhenUserPushesThePlayButtom()
        {
            IWebElement PlayButton = driver.FindElement(By.CssSelector(".video-showcase__player-section.overlay"));
            PlayButton.Click();
        }
        
        [When(@"click on FullScreen icon")]
        public void WhenClickOnFullScreenIcon()
        {
            // наводим на видео чтобы показалась кнопка FullScreen
            IWebElement Video = driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[7]/section/div/div[3]/div/div/div[1]/video"));
            Actions action2 = new Actions(driver);
            action2.MoveToElement(Video).Perform();

            //нажимаем на кнопку 
            IWebElement FullScreen_button = driver.FindElement(By.Id("fullscreen-button"));
            FullScreen_button.Click();
        }
        
        [When(@"user move to another slide section")]
        public void WhenUserMoveToAnotherSlideSection()
        {
            //IWebElement NextSlide = driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[7]/section/div/div[3]/div/div/div[2]/div/div[2]/button[2]"));
            IWebElement NextSlide = driver.FindElement(By.ClassName("owl-next"));
            NextSlide.Click();
        }
        
        [When(@"user chooses the Last video")]
        public void WhenUserChoosesTheLastVideo()
        {
            IWebElement PlayButtom_sec = driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[7]/section/div/div[3]/div/div/div[2]/div/div[1]/div/div[7]/div/div[1]/div"));
            PlayButtom_sec.Click();
        }
        
        [Then(@"the First video is displayed")]
        public void ThenTheFirstVideoIsDisplayed()
        {
            IWebElement Video = driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[7]/section/div/div[3]/div/div/div[1]/video"));
            Assert.IsTrue(Video.Displayed);
            System.Threading.Thread.Sleep(5000); 
            driver.Close();
            
        }
        
        [Then(@"the Last video is displayed")]
        public void ThenTheLastVideoIsDisplayed()
        {
            IWebElement Video_sec = driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[7]/section/div/div[3]/div/div/div[1]"));
            Assert.IsTrue(Video_sec.Displayed);
            System.Threading.Thread.Sleep(5000);
            driver.Close();
        }
    }
}
