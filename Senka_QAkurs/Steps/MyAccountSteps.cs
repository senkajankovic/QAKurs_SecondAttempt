using NUnit.Framework;
using Senka_QAkurs.Helpers;
using Senka_QAkurs.Pages;
using System;
using TechTalk.SpecFlow;

namespace Senka_QAkurs.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.SignIn);

        }

        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username,TestConstants.Username);
            ut.EnterTextInElement(ap.password,TestConstants.Password);
        }

        [StepDefinition(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signInBtn);

        }
        [Given(@"initiates a flow for creating page")]
        public void GivenInitiatesAFowForCreatingPage()
        {
            Utilities ut = new Utilities(Driver);
            AuthenticationPage ap = new AuthenticationPage(Driver);
            string randEmail = ut.GenerateRandomEmail();
            ut.EnterTextInElement(ap.email, randEmail);
            ut.ClickOnElement(ap.createAccountBtn);                
        }

        [Given(@"user enters all required data")]
        public void GivenUserEntersAllRequiredData()
        {
            Utilities ut = new Utilities(Driver);
            SignUpPage sup = new SignUpPage(Driver);
            ut.EnterTextInElement(sup.firstName, TestConstants.firstName);
            ut.EnterTextInElement(sup.lastName, TestConstants.lastName);

            string fullName = TestConstants.fullName + " " + TestConstants.lastName;
            ScenarioContext.Current.Add(TestConstants.fullName, fullName);
                
            ut.EnterTextInElement(sup.password, TestConstants.Password);
            ut.EnterTextInElement(sup.firstNameAddress, TestConstants.firstName);
            ut.EnterTextInElement(sup.lastNameAddress, TestConstants.lastName);
            ut.EnterTextInElement(sup.address, TestConstants.address);
            ut.EnterTextInElement(sup.city, TestConstants.city);

            ut.DropdownSelect(sup.state, TestConstants.state);

            ut.EnterTextInElement(sup.zipCode, TestConstants.zipCode);
            ut.EnterTextInElement(sup.phoneMobile, TestConstants.phoneMobile);

        }

        [When(@"submits the sign up form")]
        public void WhenSubmitsTheSignUpForm()
        {
            Utilities ut = new Utilities(Driver);
            SignUpPage sup = new SignUpPage(Driver);
            ut.ClickOnElement(sup.registerBtn);
        }


        [When(@"user opens my wishlist")]
        public void WhenUserOpensMyWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage map = new MyAccountPage(Driver);
            ut.ClickOnElement(map.wishlist);
        }

        [Then(@"can add new wishlist")]
        public void ThenCanAddNewWishlist()
        {
            Utilities ut = new Utilities(Driver);
            MyWishlistPage mwp = new MyWishlistPage(Driver);
            Assert.True(ut.ElementDisplayed(mwp.newWishlist));
        }


        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            Utilities ut = new Utilities(Driver);
            MyAccountPage map = new MyAccountPage(Driver);
            Assert.True(ut.ElementDisplayed(map.logOutBtn), "Log out failed");
        }
        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            Utilities ut = new Utilities(Driver);
            string _fullName = ScenarioContext.Current.Get<string>(TestConstants.fullName);
            Assert.True(ut.TextPresentInElement(_fullName).Displayed, "User's full name not displayed");               

        }

    }
}
