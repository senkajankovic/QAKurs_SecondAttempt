using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senka_QAkurs.Pages
{
    class FooterPage
    {
        readonly IWebDriver driver;

        public FooterPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("footer")));
        }

        public void ClickOnLink (string link)
        {
            By linkTitle = By.CssSelector(".toggle-footer [title='" + link + "'");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(linkTitle)).Click();

        }
               

            public bool IsOnCorrectPage (string pageName)
        {
            By linkedPage = By.Id(""+pageName+"");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(linkedPage)).Displayed;
        }
    }
}
