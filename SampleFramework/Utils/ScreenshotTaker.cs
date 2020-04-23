using OpenQA.Selenium;
using System;

namespace SampleFramework.Utils
{
    class ScreenshotTaker
    {
        public static void TakeScreenShotNow(IWebDriver driver)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string testFullName = NUnit.Framework.TestContext.CurrentContext.Test.MethodName;
            string Runname = $"{testFullName} {DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss")}";
            string screenshotfilename = "D:\\Screenshots\\" + Runname + ".jpg";
            ss.SaveAsFile(screenshotfilename);
        }
    }
}
