using Senka_QAkurs.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Senka_QAkurs.Steps
{
    public class CartSteps : Base

    {
        [Given(@"user opens '(.*)' section")]
        public void GivenUserOpensSection(string p0)
        {
            
        }

        [Given(@"user selects a product")]
        public void GivenUserSelectsAProduct()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"increases quantity to (.*)")]
        public void GivenIncreasesQuantityTo(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"user submits Add to cart button")]
        public void WhenUserSubmitsAddToCartButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"product is added to cart")]
        public void ThenProductIsAddedToCart()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
