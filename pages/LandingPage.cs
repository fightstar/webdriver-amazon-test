using OpenQA.Selenium;

namespace AmazonSearch.pages
{
    public class LandingPage : BasePage
    {
        public LandingPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement SearchTextBox => Driver.FindElement(By.Id("twotabsearchtextbox"));
        private IWebElement SearchButton => Driver.FindElement(By.Id("nav-search-submit-button"));

        public SearchResultsPage SearchProduct(string text)
        {
            SearchTextBox.SendKeys(text);
            SearchButton.Click();
            return new SearchResultsPage(Driver);
        }

    }
}