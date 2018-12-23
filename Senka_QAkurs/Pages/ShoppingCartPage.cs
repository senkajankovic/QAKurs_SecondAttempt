using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senka_QAkurs.Pages
{
    class ShoppingCartPage
    {
        readonly IWebDriver driver;
        public By productInCart = By.CssSelector(".cart_description .product-name");
        public By quantityInCart = By.CssSelector(".cart_quantity .cart_quantity_input ");
        public ShoppingCartPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id("order")));
        }
    }
}
