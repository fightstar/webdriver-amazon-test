using OpenQA.Selenium.Chrome;

namespace AmazonSearch.helpers
{
    public class ChromeDriverManager : DriverManager
    {
        protected override void CreateWebDriver()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            Driver = new ChromeDriver(Settings.ChromeDriverFolder, options);
        }
    }
}