using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutomation.Pages
{
    internal class Home
    {
        private IWebDriver driver;

        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement TitleHomePage()
        {
            return driver.FindElement(By.ClassName("title"));
        }
    }
}
