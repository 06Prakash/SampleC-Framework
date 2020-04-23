using OpenQA.Selenium;
using SampleFramework.Utils;

namespace SampleFramework.PageObjects
{
    internal class GoogleSearchResultPage : BasePageObjectClass
    {
        public GoogleSearchResultPage(IWebDriver driver) : base(driver) { }

        internal bool? FindSearchText(string SearchText)
        {
            ScreenshotTaker.TakeScreenShotNow(Driver);
            return Driver.FindElement(By.XPath($"//*[contains(text(),{SearchText})]")).Displayed;
        }
    }
}