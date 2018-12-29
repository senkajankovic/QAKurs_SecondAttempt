using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senka_QAkurs.Pages
{
    class HomePage
    {
        readonly IWebDriver driver;

        public By SignIn = By.ClassName("login");
        public By ContactUsBtn = By.Id("contact-link");
        public By DressesBtn = By.CssSelector(".sf-menu [title='Dresses']");
        public By SearchBox = By.Id("search_query_top");
        public By SearchBtn = By.CssSelector("#searchbox .btn");
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("index")));
        }
        
    }
}
