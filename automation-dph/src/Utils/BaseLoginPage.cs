
namespace automation_dph.src.Utils
{
    public class BaseLoginPage
    {
        protected PageTest? PageTest { get; private set; }
        protected LoginPages LoginPages { get; private set; } = null!;
        protected DataConfiguration DataConfiguration { get; private set; } = null!;
        protected LoginAssertions LoginAssertions { get; private set; } = null!;
        protected Login Login { get; private set; } = null!;
        protected MyPostsPages MyPostsPages { get; private set; } = null!;
        protected LoginApiPages LoginApiPages { get; private set; } = null!;
        protected LoginApi LoginApi { get; private set; } = null!;
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
            DataConfiguration = new(Page, PageTest);
            LoginAssertions = new(Page, PageTest);
            Login = new(Page, PageTest);
            MyPostsPages = new(Page, PageTest);
            LoginApiPages = new(Page, PageTest);
            LoginApi = new(Page, PageTest);
        }
    }
}