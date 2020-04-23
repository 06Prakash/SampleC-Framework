using NUnit.Framework;
using OpenQA.Selenium;
using SampleFramework.PageObjects.Utils;
using SampleFramework.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleFramework.Tests
{
    [TestFixture]
    [Category("SearchArea")]
    class GoogleSearchPageTest
    {
        IWebDriver driver;
        [SetUp]
        public void Setup() => driver = WebDriver.GetDriver();

        [Test]
        public void Test1()
        {
            var googleSearchPage = new GoogleSearchPage(driver);
            googleSearchPage.GoTo();
            Assert.IsTrue(googleSearchPage.isPageReached());
            Console.WriteLine("Reached the google search page..");
            string SearchString = "PageFactory";
            googleSearchPage.SearchInGoogle(SearchString);
            var ResultPage = new GoogleSearchResultPage(driver);
            Assert.IsTrue(ResultPage.FindSearchText(SearchString));
            Console.WriteLine("Google searched the exact text as needed..");
        }

        [TearDown]
        public void TearDown() => driver.Close();
    }
}
