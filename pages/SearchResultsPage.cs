using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using OpenQA.Selenium;

namespace AmazonSearch.pages
{
    public class SearchResultsPage : BasePage
    {
        public SearchResultsPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement Content => Driver.FindElement(By.CssSelector(".s-main-slot"));

        private IList<IWebElement> Results => Content.FindElements(By.CssSelector("div.a-section.a-spacing-small.a-spacing-top-small:not(.s-padding-left-small.s-padding-right-small)"));

        public decimal GetProductPrice(int productNumberInResults)
        {
            var fullPriceElement = Results[productNumberInResults].FindElement(By.CssSelector("span.a-price:not(.a-text-price) span.a-offscreen"));

            var fullPrice = fullPriceElement.GetAttribute("innerHTML");
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            decimal amount =
                decimal.Parse(fullPrice, NumberStyles.Currency, culture);
            return amount;
        }

    }
}
