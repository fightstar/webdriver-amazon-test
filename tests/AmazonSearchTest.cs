using AmazonSearch.helpers;
using AmazonSearch.pages;
using FluentAssertions;
using NUnit.Framework;

namespace AmazonSearch.tests
{
    public class Tests : TestsSetup
    {
        [TestCase("laptop",100)]
        [TestCase("phone", 30)]
        public void FirstLaptopPriceShouldBeGreaterThenValue(string productName,int price)
        {
            Driver.Navigate().GoToUrl(Settings.AmazonSiteUrl);
            LandingPage navigationBar = new LandingPage(Driver);
            var searchResults =  navigationBar.SearchProduct(productName);
            searchResults.GetProductPrice(0).Should().BeGreaterThan(price);
        }
    }
}