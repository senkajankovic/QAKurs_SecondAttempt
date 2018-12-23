using OpenQA.Selenium;
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
        public void GivenIncreasesQuantityTo(string p0)
        {
            p0 = TestConstants.Quantity;
            Utilities ut = new Utilities(Driver);
            ProductDetailsPage pdp = new ProductDetailsPage(Driver);
            Driver.FindElement(pdp.quantity).Clear();
            ut.EnterTextInElement(pdp.quantity, p0);
        }

        [When(@"user submits Add to cart button")]
        public void WhenUserSubmitsAddToCartButton()
        {
            Utilities ut = new Utilities(Driver);
            ProductDetailsPage pdp = new ProductDetailsPage(Driver);
            ut.ClickOnElement(pdp.addToCartBtn);

        }

        [Then(@"product is added to cart")]
        public void ThenProductIsAddedToCart()
        {
        }

    }
}
