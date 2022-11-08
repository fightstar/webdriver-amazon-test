using Microsoft.Extensions.Configuration;

namespace AmazonSearch.helpers
{
    public static class Settings
    {
        private static readonly IConfigurationRoot Config = new ConfigurationBuilder().AddJsonFile("appconfig.json")
            .Build();

        public static string ChromeDriverFolder => Config["ChromeDriverFolder"];
        public static string AmazonSiteUrl => "https://www.amazon.com/";
    }
}