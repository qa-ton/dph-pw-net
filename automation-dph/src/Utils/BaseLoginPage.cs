
namespace automation_dph.src.Utils
{
    public class BaseLoginPage
    {
        protected PageTest? PageTest { get; private set; }
        protected LoginPages LoginPages { get; private set; } = null!;
        protected IPage? Page { get; private set; }

        [TestInitialize]
        public async Task TestInit()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = true
                });


            Page = await browser.NewPageAsync();
            await Page.GotoAsync("https://staging.deliveries.ph/");

            // Page Object Model
            PageTest = new PageTest();
            LoginPages = new(Page, PageTest);
        }
    }
}