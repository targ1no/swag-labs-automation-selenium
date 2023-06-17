using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutomation.Pages
{
    internal class Login
    {
        private IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AccessWebsite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        // ELEMENTS
        private IWebElement Username()
        {
            return driver.FindElement(By.Id("user-name"));
        }

        private IWebElement Password()
        {
            return driver.FindElement(By.Id("password"));
        }

        private IWebElement LoginButton()
        {
            return driver.FindElement(By.Id("login-button"));
        }

        // ACTIONS
        public void FillLoginCredentials()
        {
            Username().SendKeys("standard_user");
            Password().SendKeys("secret_sauce");
            LoginButton().Click();
        }
    }
}
