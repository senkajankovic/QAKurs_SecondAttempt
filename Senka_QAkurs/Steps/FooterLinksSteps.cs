using NUnit.Framework;
using Senka_QAkurs.Helpers;
using Senka_QAkurs.Pages;
using System;
using TechTalk.SpecFlow;

namespace Senka_QAkurs.Steps
{
    [Binding]
    public class FooterLinksSteps : Base
    {
        [When(@"user clicks on '(.*)'")]
        public void WhenUserClicksOn(string p0)
        {
            FooterPage fp = new FooterPage(Driver);
            fp.ClickOnLink(p0);
        }

        [Then(@"correct page '(.*)' opens")]
        public void ThenCorrectPageOpens(string p0)
        {
            FooterPage fp = new FooterPage(Driver);
            Assert.True(fp.IsOnCorrectPage(p0), "Wrong page is opened");   
        }
    }
}
