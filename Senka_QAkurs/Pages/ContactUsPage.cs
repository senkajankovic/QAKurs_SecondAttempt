using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senka_QAkurs.Pages
{
    class ContactUsPage
    {
        readonly IWebDriver driver;

        public By SubjectHeadingDdwn = By.Id("id_contact");
        public By Email = By.Id("email");
        public By MessageBox = By.Id("message");
        public By submitMessageBtn = By.Id("submitMessage");
       
        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName("contact-form-box")));
        }
    }
}
