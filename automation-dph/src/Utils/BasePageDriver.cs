using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NLog;

namespace automation_dph.src.Utils
{
    public class BasePageDriver
    {
        protected IPage Page;
        protected PageTest PageTest;


        public BasePageDriver(IPage page, PageTest pageTest)
        {
            Page = page;
            PageTest = pageTest;
        }

        protected static ExtentSparkReporter Reports { get; private set; } = null!;
        protected static ExtentReports Extent { get; private set; } = null!;
        protected static Logger _logger = LogManager.GetCurrentClassLogger();

        public static ExtentReports GetInstance()
        {
            if (Extent == null)
            {
                Reports = new ExtentSparkReporter("/Users/jenmarmarquez/Documents/Repositories/dph-pw-net/automation-dph/automation-dph/reports/index.html");
                Extent = new ExtentReports();
                Extent.AttachReporter(Reports);
            }

            return Extent;
        }

        public async Task TakeAScreenshot(string testCaseName, string testCaseFolderName)
        {
            await Page.ScreenshotAsync(new PageScreenshotOptions()
            {
                Path = Path.Combine("/Users/jenmarmarquez/Documents/Repositories/dph-pw-net/automation-dph/automation-dph/screenshots", $"{testCaseFolderName}", $"{testCaseName}{Guid.NewGuid().ToString()[..3]} - screenshot.png")
            });
        }
    }
}