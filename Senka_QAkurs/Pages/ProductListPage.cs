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

        public By FirstImageSelection = By.XPath("//*[@id='center_column']/ul/li[1]/div/div[1]/div/a[1]");

        public ProductListPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("category")));

        }

    }
}
