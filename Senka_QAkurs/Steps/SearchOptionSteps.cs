using NUnit.Framework;
using OpenQA.Selenium;
using Senka_QAkurs.Helpers;
using Senka_QAkurs.Pages;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Senka_QAkurs.Steps
{
    [Binding]
    public class SearchOptionSteps : Base
    {

        [Given(@"user enters a word '(.*)' into serach box")]
        public void GivenUserEntersAWordIntoSerachBox(string keyword)
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.EnterTextInElement(hp.SearchBox, keyword);
        }

        [When(@"click on button search")]
        public void WhenClickOnButtonSearch()
        {
            Utilities ut = new Utilities(Driver);
            HomePage hp = new HomePage(Driver);
            ut.ClickOnElement(hp.SearchBtn);
        }

        [Then(@"list of results including '(.*)' displays")]
        public void ThenListOfResultsIncludingKeywordDisplays(string keyword)
        {
            Utilities ut = new Utilities(Driver);
            SearchResultsListPage srlp = new SearchResultsListPage(Driver);
            IList<IWebElement> results = Driver.FindElements(srlp.results);
            int resultsCount = results.Count;
            string title = null;
            for (int i = 0; i < resultsCount - 1; i++)
            {
                title = results[i].GetAttribute("title");

                Assert.True(title.Contains(keyword));
            }





        }
    }
}
