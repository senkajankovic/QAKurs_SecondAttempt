using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senka_QAkurs.Pages
{
    class ProductListPage
    {
        readonly IWebDriver driver;

        public By dressesList = By.CssSelector(".right-block [title='Printed Dress']");
        public By resultsList = By.CssSelector(".product-container .product-name");
        public ProductListPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector(".container .breadcrumb [title='Women'")));

        }

    }
}
