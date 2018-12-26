using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Senka_QAkurs.Helpers;
using Senka_QAkurs.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Senka_QAkurs.Steps
{
    public class PDPSteps : Base

    {
        [Given(@"user opens Dresses section")]
        public void GivenUserOpensSection()
        {
            HomePage hp = new HomePage(Driver);
            IList<IWebElement> dresses = Driver.FindElements(hp.DressesBtn);
            dresses[1].Click();

        }

        [Given(@"user selects a product")]
        public void GivenUserSelectsAProduct()
        {
            ProductListPage plp = new ProductListPage(Driver);
            IList<IWebElement> dressToBuy = Driver.FindElements(plp.dressesList);
            dressToBuy[0].Click();

        }

        [Given(@"increases quantity to (.*)")]
        public void GivenIncreasesQuantityTo(string qty)
        {
            //p0 = TestConstants.Quantity;
            Utilities ut = new Utilities(Driver);
            ProductDetailsPage pdp = new ProductDetailsPage(Driver);
            Driver.FindElement(pdp.quantity).Clear();
            ut.EnterTextInElement(pdp.quantity, qty);
            string productName = ut.ReturnTextFromElement(pdp.productName);
            ScenarioContext.Current.Add(TestConstants.ProductName, productName);

        }

        [When(@"user submits Add to cart button")]
        public void WhenUserSubmitsAddToCartButton()
        {
            Utilities ut = new Utilities(Driver);
            ProductDetailsPage pdp = new ProductDetailsPage(Driver);
            ut.ClickOnElement(pdp.addToCartBtn);

            // Driver.SwitchTo().Frame(Driver.FindElement(By.Id("layer_cart")));
            CartOverlayPage cop = new CartOverlayPage(Driver);
            ut.ClickOnElement(cop.proceedToCheckout);


        }

        [Then(@"product is added to cart")]
        public void ThenProductIsAddedToCart()
        {
            Utilities ut = new Utilities(Driver);
            ShoppingCartPage scp = new ShoppingCartPage(Driver);
            string productName = ScenarioContext.Current.Get<string>(TestConstants.ProductName);
            Assert.AreEqual(productName, ut.ReturnTextFromElement(scp.productInCart), "Product is not correct");
        }

        [Then(@"quantity of product is (.*)")]
        public void ThenQuantityOfProductIsCorrect(string qty)
        {
            Utilities ut = new Utilities(Driver);
            ShoppingCartPage scp = new ShoppingCartPage(Driver);
            string qtyInCart = ut.ReturnValueFromElement(scp.quantityInCart);
            Assert.AreEqual(qty, qtyInCart, "Quantity of product in cart is not correct");
        }



    }
}
