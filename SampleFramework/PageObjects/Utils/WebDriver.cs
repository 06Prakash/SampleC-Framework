using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFramework.PageObjects.Utils
{
    public class WebDriver
    {
        public static IWebDriver GetDriver()
        {
            var ChromeDriverPath = $"{AppDomain.CurrentDomain.BaseDirectory}";
            IWebDriver driver = new ChromeDriver(ChromeDriverPath);
            return driver;
        }
    }
}
