using OpenQA.Selenium;

namespace AmazonSearch.helpers
{
    public abstract class DriverManager
    {
        protected IWebDriver Driver;

        protected abstract void CreateWebDriver();

        public void DestroyWebDriver()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver = null;
            }
        }

        public IWebDriver GetWebDriver()
        {
            if (Driver == null) CreateWebDriver();

            return Driver;
        }
    }
}