using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SeleniumTesting.Data;

namespace SeleniumTesting.Steps
{
    [Binding]
    public class CraigslistDemoSteps
    {
        CraigslistSearch craigslistSearch = null;

        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = Props.CraigslistUrl;
            craigslistSearch = new CraigslistSearch(driver);
        }
        
        [Given(@"I enter '(.*)' into the searchbox")]
        public void GivenIEnterIntoTheSearchbox(string p0)
        {
            craigslistSearch.EnterSearchTerm(p0);
        }
        
        [Given(@"I click 'has image'")]
        public void GivenIClick(string p0)
        {
            craigslistSearch.ClickHasImage();
        }
        
        [Given(@"I enter the  price")]
        public void GivenIEnterThePrice(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            craigslistSearch.EnterPriceRange((decimal)data.MinPrice, (decimal)data.MaxPrice);
        }
        
        [Given(@"I scroll down")]
        public void GivenIScrollDown()
        {
            craigslistSearch.SearchFormPageDown();
        }
        
        [Given(@"I click the 'update search' button")]
        public void GivenIClickTheButton(string p0)
        {
            craigslistSearch.ClickUpdateSearch();
        }
        
        [Given(@"I click the top post")]
        public void GivenIClickTheTopPost()
        {
            craigslistSearch.ClickTopPostOfUpdatedSearch();
        }
        
        [Then(@"I should get the price and ad information")]
        public void ThenIShouldGetThePriceAndAdInformation()
        {
            var price = craigslistSearch.GetListingPrice();
            Props.Price = Convert.ToDecimal(price.Replace("$", ""));
            Props.Ad = craigslistSearch.GetAdContent();            
        }
        
        [Then(@"Save data to database")]
        public void ThenSaveDataToDatabase()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Log data to database")]
        public void ThenLogDataToDatabase()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should close the browser")]
        public void ThenIShouldCloseTheBrowser()
        {
            craigslistSearch.WebDriver.Dispose();
        }
    }
}
