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

        [Then(@"list of results including '(.*)' displays")]                    //Proverava da li se kljucna rec nalazi u rezultatima search-a
        public void ThenListOfResultsIncludingKeywordDisplays(string keyword)
        {
            Utilities ut = new Utilities(Driver);
            SearchResultsListPage srlp = new SearchResultsListPage(Driver);
            IList<IWebElement> results = Driver.FindElements(srlp.results);     //Kreiram listu IWebElemenata koja se zove reuslts
            int resultsCount = results.Count;                                   //Proveravam koliko ima rezultata pretrage i dodeljujem tu vrednost integeru resultsCount
            string title = "";                                                  //Inicijalizujem prazan string koji se zove title i koji cu smestati naslove elemenata
            for (int i = 0; i < resultsCount - 1; i++)
            {                                                                   //Za svaki rezultat iz liste rezultata, vrednost atributa title smestam u string title
                title = results[i].GetAttribute("title");                       //brojac i treba da bude za 1 manji od resultCount jer pocinje od 0

                Assert.True(title.Contains(keyword), "Proizvod '" +title+ "' ne sadrzi kljucnu rec");                           //i proveravam da li sadrzi kljucnu rec zadatu u SpecFlow-u
            }





        }
    }
}
