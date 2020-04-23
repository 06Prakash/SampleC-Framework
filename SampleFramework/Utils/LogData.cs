using NLog;
using SampleFramework.PageObjects.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SampleFramework.Utils
{
    class LogData
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        public static void Log(string message, string level = "Debug")
        {
            string logMessage = $" >>TestName : {NUnit.Framework.TestContext.CurrentContext.Test.MethodName}<< ==> {message}";
            switch (level)
            {
                case "Trace":
                    _logger.Trace(logMessage);
                    break;
                case "Debug":
                    _logger.Debug(logMessage);
                    break;
                case "Info":
                    _logger.Info(logMessage);
                    break;
                case "Error":
                    _logger.Error(logMessage);
                    break;
                case "Fatal":
                    _logger.Fatal(logMessage);
                    break;
                default:
                    break;
            }
        }

        public static void Verify(bool Condition, string CaseUnderTest)
        {
            ScreenshotTaker.TakeScreenShotNow(WebDriver.GetDriver());
            string logMessage = $"{NUnit.Framework.TestContext.CurrentContext.Test.MethodName} => {CaseUnderTest} - ";
            if (Condition)
                Log($"{logMessage} Passed", "Info");
            else
                Log($"{logMessage} Failed", "Info");
        }
    }
}
