using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAutomation.Reports
{
    internal class ExtentReportManager
    {
        private static ExtentReports extent;

        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter(@"..\..\Reports\TestReport.html");
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        public static ExtentTest CreateTest(string testName, string testDescription)
        {
            return extent.CreateTest(testName, testDescription);
        }

        public static void FlushReport()
        {
            extent.Flush();
        }
    }
}
