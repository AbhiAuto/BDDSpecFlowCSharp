using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    [Binding]
    class Program
    {
        public IWebDriver driver = BrowserManager.BrowserDriver();
        [Given(@"I have google web application")]
        public void GivenIHaveGoogleWebApplication()
        {
            driver.Navigate().GoToUrl(@"http://www.google.com/");
        }

       
        [Given(@"I enter ""(.*)"" in the search box")]
        public void GivenIEnterInTheSearchBox(string strText)
        {
            driver.FindElement(By.Id("userNameInput")).SendKeys("U65557@ust-global.com");
            driver.FindElement(By.Id("passwordInput")).SendKeys("Giri$4567");
            driver.FindElement(By.Id("submitButton")).Click();
            Task.Delay(5000);
            driver.FindElement(By.Name("button")).Click();
            Task.Delay(5000);
            driver.FindElement(By.Id("lst-ib")).SendKeys(strText);
        }

        [When(@"I click on google search button")]
        public void WhenIClickOnGoogleSearchButton()
        {
            driver.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }

        [Then(@"I should see links with details of BDD cucumber should be displayed")]
        public void ThenIShouldSeeLinksWithDetailsOfBDDCucumberShouldBeDisplayed()
        {
            driver.Close();
            driver.Quit();
        }

        [Then(@"I should see links with details of BDD cucumber should not be displayed")]
        public void ThenIShouldSeeLinksWithDetailsOfBDDCucumberShouldNotBeDisplayed()
        {
            driver.FindElement(By.Id("lst-i")).SendKeys(Keys.Enter);
        }
        
        }

  

}