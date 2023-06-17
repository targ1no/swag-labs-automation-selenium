using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using CSharpAutomation.Config;
using CSharpAutomation.Pages;
using CSharpAutomation.Reports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace CSharpAutomation
{
    [Binding]
    public class LoginStepDefinitions 
    {
        private IWebDriver driver;
        private Login loginPage;
        private Home homePage;
        private ExtentTest test;

        [BeforeScenario]
        public void Setup()
        {
            driver = new ChromeDriver();
            loginPage = new Login(driver);
            homePage = new Home(driver);

            ExtentReportManager.InitializeReport();
            test = ExtentReportManager.CreateTest("Login Test", "System login test");
        }

        [Given(@"that user wants to login to the system")]
        public void GivenThatUserWantsToLoginToTheSystem()
        {
            string url = AppSettings.BaseUrl;
            loginPage.AccessWebsite(url);
        }

        [When(@"he enter the valid credentials")]
        public void WhenHeEnterTheValidCredentials()
        {
            loginPage.FillLoginCredentials();
        }

        [Then(@"it must be inserted in the HomePage of the system, logging in successfully")]
        public void ThenItMustBeInsertedInTheHomePageOfTheSystemLoggingInSuccessfully()
        {
            IWebElement productsTitle = homePage.TitleHomePage();
            string expectedTitle = "Products";
            string actualTitle = productsTitle.Text;

            Assert.AreEqual(expectedTitle, actualTitle);

            if (expectedTitle.Equals(actualTitle))
            {
                test.Pass("User was redirected to the home page and successfully logged in");
            }
            else
            {
                test.Fail("User was not redirected to home page and login failed");
            }
        }

        [AfterScenario]
        public void TearDown()
        {
            ExtentReportManager.FlushReport();
            driver.Quit();
        }
    }
}
