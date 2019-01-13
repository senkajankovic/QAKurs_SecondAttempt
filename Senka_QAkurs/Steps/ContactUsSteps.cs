using Senka_QAkurs.Helpers;
using Senka_QAkurs.Pages;
using System;
using TechTalk.SpecFlow;

namespace Senka_QAkurs.Steps
{
    [Binding]
    public class ContactUsSteps : Base
    {
       readonly Utilities ut = new Utilities(Driver);

        [StepDefinition(@"user clicks on Contact Us button")]
        public void GivenUserClicksOnContactUsButton()
        {
            //Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.ContactUsBtn);
        }

        [Given(@"enters data into mandatory fields")]
        public void GivenEntersDateIntoMandatoryFields()
        {
            //Utilities ut = new Utilities(Driver);
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.EnterTextInElement(cup.Email, ut.GenerateRandomEmail());
            ut.EnterTextInElement(cup.MessageBox, TestConstants.textMessage);
        }

        [Given(@"select '(.*)' from subject heading drop-down")]
        public void GivenSelectFromSubjectHeadeingDrop_Down(string p0)
        {
           // Utilities ut = new Utilities(Driver);
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.DropdownSelect(cup.SubjectHeadingDdwn, p0);
        }

        [When(@"user clicks Send button")]
        public void WhenUserClicksSendButton()
        {
           // Utilities ut = new Utilities(Driver);
            ContactUsPage cup = new ContactUsPage(Driver);
            ut.ClickOnElement(cup.submitMessageBtn);

        }

        [Then(@"'(.*)' message should be displayed")]
        public void ThenMessageShouldBeDisplayed(string p0)
        {
           // Utilities ut = new Utilities(Driver);
            ut.TextPresentInElement(p0);
        }

    }
}
