﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senka_QAkurs.Pages
{
    class ProductDetailsPage
    {
        readonly IWebDriver driver;
        public By quantity = By.Id("quantity_wanted");
        public By addToCartBtn = By.Id("add_to_cart");
        public By productName = By.XPath("//*[@id='center_column']/div/div/div[3]/h1");
        public By productReference = By.Id("product_reference");
        public ProductDetailsPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("product")));
        }
    }
}
