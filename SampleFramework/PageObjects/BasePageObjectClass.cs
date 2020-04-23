using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SampleFramework.PageObjects
{
    internal class BasePageObjectClass
    {
        protected IWebDriver Driver { get; set; }

        public BasePageObjectClass(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}
