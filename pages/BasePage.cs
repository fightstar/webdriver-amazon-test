using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace AmazonSearch.pages
{
    public abstract class BasePage
    {
        public IWebDriver Driver { get; set; }

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
       
    }
}
