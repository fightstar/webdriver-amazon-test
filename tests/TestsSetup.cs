using AmazonSearch.helpers;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AmazonSearch.tests
{
    public class TestsSetup
    {
        private static DriverManager _driverManager;
        public static IWebDriver Driver;

        [OneTimeSetUp]
        public static void BeforeAllTests()
        {
            _driverManager = DriverManagerFactory.GetDriverManager(DriverType.Chrome);
            Driver = _driverManager.GetWebDriver();
        }

        [OneTimeTearDown]
        public static void AfterAllTests()
        {
            _driverManager.DestroyWebDriver();
        }
    }
}