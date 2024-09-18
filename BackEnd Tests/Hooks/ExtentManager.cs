

using AventStack.ExtentReports.Reporter.Configuration;

namespace AventStack.ExtentReports.Tests.Parallel
{
    public class ExtentManager
    {
        private static readonly Lazy<ExtentReports> _lazy = new Lazy<ExtentReports>(() => new ExtentReports());

        public static ExtentReports Instance { get { return _lazy.Value; } }

        static ExtentManager()
        {
            var htmlReporter = new Reporter.ExtentHtmlReporter($"{System.AppDomain.CurrentDomain.BaseDirectory}/../../../TestResults/" + "index.html");
            htmlReporter.Config.ReportName = "Automation Tests";
            htmlReporter.Config.Theme = Theme.Dark;
            Instance.AttachReporter(htmlReporter);
        }

        private ExtentManager()
        {
        }
    }
}