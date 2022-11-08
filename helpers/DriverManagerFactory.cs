namespace AmazonSearch.helpers
{
    public class DriverManagerFactory
    {
        public static DriverManager GetDriverManager(DriverType type)
        {
            DriverManager driverManager = null;

            switch (type)
            {
                case DriverType.Chrome:
                    driverManager = new ChromeDriverManager();
                    break;
            }

            return driverManager;
        }
    }
}