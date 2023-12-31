﻿

namespace automation_dph.src.Utils
{
	public class BasePageTest
	{
        protected IPage? Page { get; private set; }
        protected PageTest? PageTest { get; private set; }
        protected DataConfiguration DataConfiguration { get; private set; } = null!;
        protected LoginPages LoginPages { get; private set; } = null!;
        protected MyPostsPages MyPostsPages { get; private set; } = null!;
        protected SearchFilterAssertions SearchFilterAssertions { get; private set; } = null!;
        protected SearchFilter SearchFilter { get; private set; } = null!;
        protected MarkAsReturnedAssertions MarkAsReturnedAssertions { get; private set; } = null!;

        [TestInitialize]
        public async Task TestPageInit()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = true
                });

            Page = await browser.NewPageAsync();
            await Page.GotoAsync("https://Staging.deliveries.ph/");

            // Page Object Model
            PageTest = new PageTest();
            DataConfiguration = new(Page, PageTest);
            LoginPages = new(Page, PageTest);
            MyPostsPages = new(Page, PageTest);
            SearchFilterAssertions = new(Page, PageTest);
            SearchFilter = new(Page, PageTest);
            MarkAsReturnedAssertions = new(Page, PageTest);

            // Login
            await LoginPages.LoginToWebApplication(DataConfiguration.qaUsername, DataConfiguration.qaPassword);

        }

        [TestCleanup]
        public async Task TestPageCleanUp()
        {
            if (Page != null && !Page.IsClosed)
            {
                try
                {
                    await Page.CloseAsync();
                }
                catch (PlaywrightException ex)
                {
                    Console.WriteLine($"Error occured during page close: {ex.Message}");
                }
            }
        }

    }
}

