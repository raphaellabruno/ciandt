using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ciandt.Configs
{
    public class WebDriver
    {
        public static IWebDriver driver { get; set; }

        public void SetUp()
        {
            driver = new ChromeDriver(".");//(SeleniumUteis.SeleniumUteis.getPathSeleniumDriver());
            driver.Navigate().GoToUrl("https://shop.googlemerchandisestore.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }        
        public void Dispose()
        {
            driver.Quit();
        }

    }
}
