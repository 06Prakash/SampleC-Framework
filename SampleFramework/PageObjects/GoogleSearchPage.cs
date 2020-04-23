using NLog;
using OpenQA.Selenium;
using SampleFramework.Utils;
using SeleniumExtras.PageObjects;

namespace SampleFramework.PageObjects
{
    internal class GoogleSearchPage :  BasePageObjectClass
    {
        [FindsBy(How = How.XPath, Using = "//input[@title='Search']")]
        public IWebElement SearchInputArea;

        public GoogleSearchPage(IWebDriver driver) : base(driver) { }

        public void GoTo()
        {
            string Url = "https://www.google.co.in";
            Driver.Navigate().GoToUrl(Url);
            LogData.Log($"Navigated to the url {Url}", "Info");
        }

        internal void SearchInGoogle(string SearchString)
        {
            SearchInputArea = Driver.FindElement(By.XPath("//input[@title='Search']"));
            SearchInputArea.SendKeys(SearchString);
            SearchInputArea.SendKeys(Keys.Enter);
            LogData.Log($"Sent the string {SearchString} successfully", "Info");
        }

        internal bool? isPageReached()
        {
            ScreenshotTaker.TakeScreenShotNow(Driver);
            return Driver.Title.ToLower().Contains("google");
        }
    }
}
